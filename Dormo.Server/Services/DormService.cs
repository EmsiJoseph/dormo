using Dormo.Server.Data;
using Dormo.Server.Data.DTOs;
using Dormo.Server.Data.Models;
using Dormo.Server.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Dormo.Server.Constants;
using Dormo.Server.Data.Requests;
using Dormo.Server.Exceptions;
using Dormo.Server.Extensions;
using Dormo.Server.Utils;

namespace Dormo.Server.Services;

public class DormService : IDormService
{
    private readonly ApplicationDbContext _context;

    public DormService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<DormDto?> CreateAsync(DormRequest request)
    {
        ValidateDormRequest(request);

        var dorm = new Dorm
        {
            Name = request.Name,
            Description = request.Description,
            Address = request.Address,
            Latitude = request.Latitude,
            Longitude = request.Longitude,
            OwnerId = request.OwnerId!,
            CategoryId = request.CategoryId,
            IsAvailable = true,
            CreatedAt = DateTime.UtcNow
        };

        return await _context.ExecuteWithValidationAsync(async () =>
        {
            _context.Dorms.Add(dorm);
            await _context.SaveChangesAsync();
            return await GetByIdAsync(dorm.Id);
        });
    }

    public async Task<DormDto?> GetByIdAsync(int id, bool includeDeleted = false)
    {
        var query = _context.Dorms
            .Include(d => d.Images)
            .Include(d => d.DormTags).ThenInclude(dt => dt.Tag)
            .Include(d => d.DormAmenities).ThenInclude(da => da.Amenity)
            .Include(d => d.Category)
            .AsQueryable();

        if (!includeDeleted)
            query = query.Where(d => !d.IsDeleted);

        var dorm = await query.FirstOrDefaultAsync(d => d.Id == id);
        if (dorm == null)
            throw AppException.NotFound("Dorm", id);

        return MapToDormDto(dorm);
    }

    public async Task<PaginatedDto<DormListingDto>> GetAllAsync(DormFilter filter)
    {
        // Validate and normalize filter
        filter ??= new DormFilter();
        filter.Page = filter.Page <= 0 ? 1 : filter.Page;
        filter.PageSize = filter.PageSize <= 0 ? 10 : filter.PageSize > 50 ? 50 : filter.PageSize;

        // Create optimized query for filtering only
        var baseQuery = _context.Dorms
            .AsNoTracking()
            .Where(d => !filter.IncludeDeleted ? !d.IsDeleted : true);

        // Apply filters without eager loading
        var filteredQuery = ApplyFiltersToBaseQuery(baseQuery, filter);

        // Always ensure a deterministic ordering - fixed the ordering logic
        IOrderedQueryable<Dorm> orderedQuery;
        
        if (!string.IsNullOrEmpty(filter.SortBy))
        {
            // Use the sorting method that returns IOrderedQueryable
            orderedQuery = ApplySorting(filteredQuery, filter.SortBy, filter.IsDescending);
        }
        else
        {
            // Apply default ordering if no sort specified
            orderedQuery = filteredQuery.OrderBy(d => d.Id);
        }
        
        // Add secondary ordering for consistent paging
        orderedQuery = orderedQuery.ThenBy(d => d.Id);

        // Get count using optimized query
        var totalItems = await filteredQuery.CountAsync();

        // Apply pagination to the ordered query
        var pageNumber = filter.Page ?? 1;
        var pageSize = filter.PageSize ?? 10;
        var pagedQuery = orderedQuery
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize);

        // Only include the most essential related data
        var detailedQuery = pagedQuery
            .Include(d => d.Category)
            .Include(d => d.Images)
            .Include(d => d.Rooms.Where(r => r.IsAvailable))
            .AsSplitQuery();

        // Execute query and map to lightweight DTO
        var dorms = await detailedQuery.ToListAsync();
        var mappedDorms = dorms.Select(MapToDormListingDto);

        return new PaginatedDto<DormListingDto>
        {
            Items = mappedDorms,
            TotalItems = totalItems,
            Page = pageNumber,
            PageSize = pageSize,
            HasNext = pageNumber * pageSize < totalItems
        };
    }
    public async Task<bool> UpdateAsync(DormDto dto)
    {
        ValidateDormRequest(dto);

        return await _context.ExecuteWithValidationAsync(async () =>
        {
            var dorm = await GetByIdAsync(dto.Id);

            dorm.Name = dto.Name;
            dorm.Description = dto.Description;
            dorm.Address = dto.Address;
            dorm.Latitude = dto.Latitude;
            dorm.Longitude = dto.Longitude;

            await _context.SaveChangesAsync();
            return true;
        });
    }

    public async Task<bool> SoftDeleteAsync(int id)
    {
        return await _context.ExecuteWithValidationAsync(async () =>
        {
            var dorm = await _context.Dorms.FindAsync(id)
                       ?? throw AppException.NotFound("Dorm", id);

            dorm.IsDeleted = true;
            dorm.DeletedAt = DateTime.UtcNow;
            await _context.SaveChangesAsync();
            return true;
        });
    }

    public async Task<bool> HardDeleteAsync(int id)
    {
        var dorm = await _context.Dorms.FindAsync(id);
        if (dorm == null) return false;

        _context.Dorms.Remove(dorm);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> RestoreAsync(int id)
    {
        var dorm = await _context.Dorms.FindAsync(id);
        if (dorm == null || !dorm.IsDeleted) return false;

        dorm.IsDeleted = false;
        dorm.DeletedAt = null;
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<IEnumerable<DormDto>> SearchByLocationAsync(decimal latitude, decimal longitude,
        int radiusInKm)
    {
        var dorms = await _context.Dorms
            .Include(d => d.Images)
            .Include(d => d.DormTags).ThenInclude(dt => dt.Tag)
            .Include(d => d.DormAmenities).ThenInclude(da => da.Amenity)
            .Include(d => d.Category)
            .Where(d => !d.IsDeleted)
            .ToListAsync();

        var filteredDorms = dorms
            .Where(d => CalculateDistance(latitude, longitude, d.Latitude, d.Longitude) <= radiusInKm)
            .ToList();

        return filteredDorms.Select(MapToDormDto);
    }

    public async Task<bool> UpdateAmenityAsync(int dormId, List<int> amenityIds)
    {
        foreach (int amenityId in amenityIds)
        {
            var dormAmenity =
                await _context.DormAmenities.FirstOrDefaultAsync(da =>
                    da.DormId == dormId && da.AmenityId == amenityId);
            if (dormAmenity != null) continue;

            dormAmenity = new DormAmenity { DormId = dormId, AmenityId = amenityId };
            _context.DormAmenities.Add(dormAmenity);
        }

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> UpdateTagAsync(int dormId, List<int> tagIds)
    {
        foreach (int tagId in tagIds)
        {
            var dormTag =
                await _context.DormTags.FirstOrDefaultAsync(da => da.DormId == dormId && da.TagId == tagId);
            if (dormTag != null) continue;

            dormTag = new DormTag() { DormId = dormId, TagId = tagId };
            _context.DormTags.Add(dormTag);
        }

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> UpdateImagesAsync(int dormId, List<ImageRequest> images)
    {
        return await _context.ExecuteWithValidationAsync(async () =>
        {
            var dorm = await _context.Dorms
                           .Include(d => d.Images)
                           .FirstOrDefaultAsync(d => d.Id == dormId)
                       ?? throw AppException.NotFound("Dorm", dormId);

            foreach (var imageRequest in images)
            {
                // Check if image with same URL and order exists
                var existingImage = dorm.Images.FirstOrDefault(i =>
                    i.Url == imageRequest.Url && i.Order == imageRequest.Order);

                if (existingImage != null) continue;

                // Validate URL format
                if (!Uri.TryCreate(imageRequest.Url, UriKind.Absolute, out _))
                    throw AppException.ValidationError("Invalid image URL", "Url");

                // Validate order range
                if (imageRequest.Order < 0)
                    throw AppException.ValidationError("Image order cannot be negative", "Order");

                var newImage = new Image
                {
                    Url = imageRequest.Url,
                    Order = imageRequest.Order,
                    Caption = imageRequest.Caption,
                    IsPrimary = imageRequest.IsPrimary,
                    CreatedAt = DateTime.UtcNow
                };

                // If this image is primary, unset other primary images
                if (newImage.IsPrimary)
                {
                    foreach (var img in dorm.Images)
                    {
                        img.IsPrimary = false;
                    }
                }

                dorm.Images.Add(newImage);
            }

            await _context.SaveChangesAsync();
            return true;
        });
    }

    public async Task<bool> UpdateRoomsAsync(int dormId, List<RoomRequest> rooms)
    {
        return await _context.ExecuteWithValidationAsync(async () =>
        {
            var dorm = await _context.Dorms
                           .Include(d => d.Rooms)
                           .FirstOrDefaultAsync(d => d.Id == dormId)
                       ?? throw AppException.NotFound("Dorm", dormId);

            foreach (var roomRequest in rooms)
            {
                // Check if room with same number exists
                var existingRoom = dorm.Rooms.FirstOrDefault(r =>
                    r.RoomNumber == roomRequest.RoomNumber);

                if (existingRoom != null)
                {
                    // Update existing room
                    existingRoom.Description = roomRequest.Description;
                    existingRoom.PricePerMonth = roomRequest.PricePerMonth;
                    existingRoom.Capacity = roomRequest.Capacity;
                    existingRoom.IsAvailable = roomRequest.IsAvailable;
                    existingRoom.UpdatedAt = DateTime.UtcNow;
                    continue;
                }

                // Add new room
                var newRoom = new Room
                {
                    RoomNumber = roomRequest.RoomNumber,
                    Description = roomRequest.Description,
                    PricePerMonth = roomRequest.PricePerMonth,
                    Capacity = roomRequest.Capacity,
                    IsAvailable = roomRequest.IsAvailable,
                    CreatedAt = DateTime.UtcNow
                };

                dorm.Rooms.Add(newRoom);
            }

            await _context.SaveChangesAsync();
            return true;
        });
    }


   private IOrderedQueryable<Dorm> ApplySorting(IQueryable<Dorm> query, string sortBy, bool isDescending)
    {
        return sortBy.ToLower() switch
        {
            SortByAttr.Price => isDescending
                ? query.OrderByDescending(d => d.Rooms.Min(r => r.PricePerMonth))
                : query.OrderBy(d => d.Rooms.Min(r => r.PricePerMonth)),
            SortByAttr.Rating => isDescending
                ? query.OrderByDescending(d => d.Rating)
                : query.OrderBy(d => d.Rating),
            SortByAttr.Availability => isDescending
                ? query.OrderByDescending(d => d.IsAvailable)
                : query.OrderBy(d => d.IsAvailable),
            SortByAttr.CreatedAt => isDescending
                ? query.OrderByDescending(d => d.CreatedAt)
                : query.OrderBy(d => d.CreatedAt),
            SortByAttr.UpdatedAt => isDescending
                ? query.OrderByDescending(d => d.UpdatedAt)
                : query.OrderBy(d => d.UpdatedAt),
            SortByAttr.Verified => isDescending
                ? query.OrderByDescending(d => d.IsVerified)
                : query.OrderBy(d => d.IsVerified),
            _ => query.OrderBy(d => d.Name)
        };
    }

    private IQueryable<Dorm> ApplyFiltersToBaseQuery(IQueryable<Dorm> query, DormFilter filter)
    {
        // Apply filters
        if (filter.CategoryId.HasValue)
            query = query.Where(d => d.CategoryId == filter.CategoryId);

        if (filter.OwnerId != null)
            query = query.Where(d => d.OwnerId == filter.OwnerId);

        if (filter.Address != null)
            query = query.Where(d => d.Address.Contains(filter.Address));

        if (filter.MinPrice.HasValue)
            query = query.Where(d => d.Rooms.Any(r => r.PricePerMonth >= filter.MinPrice));

        if (filter.MaxPrice.HasValue)
            query = query.Where(d => d.Rooms.Any(r => r.PricePerMonth <= filter.MaxPrice));

        if (filter.IsVerified.HasValue)
            query = query.Where(d => d.IsVerified == filter.IsVerified);

        if (filter.IsAvailable.HasValue)
            query = query.Where(d => d.IsAvailable == filter.IsAvailable);

        if (!string.IsNullOrEmpty(filter.SearchTerm))
            query = query.Where(d => d.Name.Contains(filter.SearchTerm) ||
                                     d.Description.Contains(filter.SearchTerm));

        if (filter.AmenityIds?.Any() == true)
            query = query.Where(d => d.DormAmenities
                .Any(da => filter.AmenityIds.Contains(da.AmenityId)));

        if (filter.TagIds?.Any() == true)
            query = query.Where(d => d.DormTags
                .Any(dt => filter.TagIds.Contains(dt.TagId)));

        if (filter.CreatedAt != default)
            query = query.Where(d => d.CreatedAt >= filter.CreatedAt);

        if (filter.UpdatedAt != default)
            query = query.Where(d => d.UpdatedAt >= filter.UpdatedAt);

        return query;
    }

    private DormDto MapToDormDto(Dorm dorm)
    {
        return new DormDto
        {
            Id = dorm.Id,
            Name = dorm.Name,
            Description = dorm.Description,
            Address = dorm.Address,
            Latitude = dorm.Latitude,
            Longitude = dorm.Longitude,
            Owner = new OwnerDto
            {
                Id = dorm.Owner!.Id,
                Email = dorm.Owner?.Email,
                FirstName = dorm.Owner?.FirstName,
                LastName = dorm.Owner?.LastName,
                ContactInfo = dorm.Owner?.ContactInfo,
                BirthYear = dorm.Owner!.Dob.Year,
                IsVerified = dorm.Owner.IsVerified
            },
            Category = new CategoryDto
            {
                Name = dorm.Category!.Name,
                Description = dorm.Category.Description,
                ParentId = dorm.Category.ParentId
            },
            Images =
            [
                ..dorm.Images.Select(di => new ImageRequest
                {
                    Url = di.Url,
                    Order = di.Order,
                    Caption = di.Caption,
                    IsPrimary = di.IsPrimary
                })
            ],
            Rooms =
            [
                ..dorm.Rooms.Select(dr => new RoomDto
                {
                    Id = dr.Id,
                    RoomNumber = dr.RoomNumber,
                    Description = dr.Description,
                    PricePerMonth = dr.PricePerMonth,
                    Capacity = dr.Capacity,
                    IsAvailable = dr.IsAvailable
                })
            ],
            Amenities =
            [
                ..dorm.Amenities
                    .Where(da => da != null)
                    .Select(da => new AmenityDto
                    {
                        Name = da!.Name,
                        Description = da.Description,
                        Icon = da.Icon
                    })
            ],
            Tags =
            [
                ..dorm.DormTags
                    .Where(dt => dt.Tag != null)
                    .Select(dt => new TagDto
                    {
                        Name = dt.Tag!.Name,
                        Description = dt.Tag.Description,
                        Icon = dt.Tag.Icon
                    })
            ],
            IsAvailable = dorm.IsAvailable,
            MinPrice = dorm.Rooms?.Any() == true ? dorm.Rooms.Min(r => r.PricePerMonth) : 0,
        };
    }

    private DormListingDto MapToDormListingDto(Dorm dorm)
    {
        return new DormListingDto
        {
            Id = dorm.Id,
            Name = dorm.Name,
            Address = dorm.Address,
            OwnerId = dorm.OwnerId,
            IsAvailable = dorm.IsAvailable,
            IsVerified = dorm.IsVerified,
            MinPrice = dorm.Rooms?.Any() == true ? dorm.Rooms.Min(r => r.PricePerMonth) : 0,
            AvailableRooms = dorm.Rooms?.Count(r => r.IsAvailable) ?? 0,
            Rating = dorm.Rating,
            Images = dorm.Images.Select(i => new ImageRequest
            {
                Url = i.Url,
                Order = i.Order,
                Caption = i.Caption,
                IsPrimary = i.IsPrimary
            }).ToArray(),
            CategoryName = dorm.Category?.Name ?? "Uncategorized"
        };
    }

    private static double CalculateDistance(decimal lat1, decimal lon1, decimal lat2, decimal lon2)
    {
        var R = 6371; // Radius of the earth in km
        var dLat = (double)(lat2 - lat1) * Math.PI / 180.0;
        var dLon = (double)(lon2 - lon1) * Math.PI / 180.0;
        var a =
            Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
            Math.Cos((double)lat1 * Math.PI / 180.0) * Math.Cos((double)lat2 * Math.PI / 180.0) *
            Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
        var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        var d = R * c; // Distance in km
        return d;
    }

    private void ValidateDormRequest(DormRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Name))
            throw AppException.ValidationError("Name is required", "Name");

        if (string.IsNullOrWhiteSpace(request.Address))
            throw AppException.ValidationError("Address is required", "Address");

        if (request.Latitude < -90 || request.Latitude > 90)
            throw AppException.ValidationError("Invalid latitude value", "Latitude");

        if (request.Longitude < -180 || request.Longitude > 180)
            throw AppException.ValidationError("Invalid longitude value", "Longitude");
    }
}