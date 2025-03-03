using System.Security.Claims;
using Dormo.Server.Constants;
using Dormo.Server.Controllers.Interfaces;
using Dormo.Server.Data.DTOs;
using Dormo.Server.Data.Models;
using Dormo.Server.Data.Requests;
using Dormo.Server.Exceptions;
using Dormo.Server.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Dormo.Server.Utils;

namespace Dormo.Server.Controllers;

[ApiController]
[Authorize]
[Route("api/v1.0/[controller]")]
public class DormController : ControllerBase, IDormController
{
    private readonly IDormService _dormService;

    private readonly UserManager<User> _userManager;
    // private readonly IDormMatchService _dormMatchService;

    public DormController(IDormService dormService, UserManager<User> userManager)
    {
        _dormService = dormService;
        _userManager = userManager;
        // _dormMatchService = dormMatchService;
    }

    [OutputCache(Duration = 60, VaryByQueryKeys = ["page", "pageSize", "searchTerm", "categoryId", "ownerId", "minPrice", "maxPrice", "isAvailable", "isVerified", "sortBy", "isDescending"])]
    [HttpGet("")]
    [AllowAnonymous]
    public async Task<ActionResult<PaginatedDto<DormListingDto>>> GetAllAsync([FromQuery] DormFilter filter)
    {
        var dorms = await _dormService.GetAllAsync(filter);
        return Ok(dorms);
    }

    [OutputCache(Duration = 60, VaryByQueryKeys = ["DormsCache"])]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        var dorm = await _dormService.GetByIdAsync(id);
        return Ok(dorm);
    }

    [HttpPost("")]
    public async Task<IActionResult> CreateAsync([FromBody] DormRequest request)
    {
        // Get the user id from the claims
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var user = await _userManager.FindByIdAsync(userId!);
        request.OwnerId = user?.Id;

        // Business rules
        // Listing creation must not exceed 5 attempts per hour per owner.
        var dorms = await _dormService.GetAllAsync(new DormFilter
        {
            OwnerId = request.OwnerId,
            CreatedAt = DateTime.UtcNow.AddHours(-1),
            UpdatedAt = DateTime.UtcNow.AddHours(-1)
        });

        var dormsByOwner = dorms.Items.Where(d => d.OwnerId == request.OwnerId);

        if (dormsByOwner?.Count() >= BusinessRulesConstants.Dorm.MaxListingsPerHour)
        {
            throw new AppException("You have exceeded the maximum number of listings created per hour.");
        }

        // Input fields (Name, Description, Address) must be sanitized for malicious content.


        // Address must not already exist for the same Owner ID in active listings.
        var existingDormPaginated = await _dormService.GetAllAsync(new DormFilter
        {
            Address = request.Address
        });
        var existingDorm = existingDormPaginated.Items.Where(d => d.OwnerId == request.OwnerId);

        if (existingDorm.Any()) throw new AppException("Address already exists for the same owner in active listings.");

        // Add dorm
        var dorm = await _dormService.CreateAsync(request);

        // Add room/s
        await UpdateRoomsAsync(dorm!.Id, request.Rooms);

        // Add images
        await UpdateImagesAsync(dorm!.Id, request.Images);

        // Add amenities
        await UpdateMetaDataAsync(dorm!.Id, DormMetadataAttr.Amenity, request.AmenityIds);

        // Add tags
        await UpdateMetaDataAsync(dorm!.Id, DormMetadataAttr.Tag, request.TagIds);

        return Ok(dorm);
    }

    [HttpPut("")]
    public async Task<IActionResult> UpdateAsync([FromBody] DormDto dto)
    {
        var dorm = await _dormService.UpdateAsync(dto);
        return Ok(dorm);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id, [FromQuery] bool hard = false)
    {
        if (!hard)
        {
            await _dormService.SoftDeleteAsync(id);
        }
        else
        {
            await _dormService.HardDeleteAsync(id);
        }

        return Ok("Deleted sucessfully");
    }

    [HttpPut("{dormId}/{metaDataType}")]
    public async Task<IActionResult> UpdateMetaDataAsync(int dormId, string metaDataType,
        [FromBody] List<int> metaDataIds)
    {
        switch (metaDataType.ToLowerInvariant())
        {
            case DormMetadataAttr.Amenity:
                await _dormService.UpdateAmenityAsync(dormId, metaDataIds);
                break;
            case DormMetadataAttr.Tag:
                await _dormService.UpdateTagAsync(dormId, metaDataIds);
                break;
            default:
                return BadRequest("Invalid meta data type");
        }

        return Ok("Updated meta data successfully");
    }

    [HttpPut("{dormId}/images")]
    public async Task<IActionResult> UpdateImagesAsync(int dormId, [FromBody] List<ImageRequest> images)
    {
        if (images.Count is < BusinessRulesConstants.Dorm.MinImages or > BusinessRulesConstants.Dorm.MaxImages)
            throw AppException.ValidationError(
                $"Number of images must be between {BusinessRulesConstants.Dorm.MinImages} and {BusinessRulesConstants.Dorm.MaxImages}");

        // Business rules
        // Only allow a maximum of 10 and minimum of 3 images per dorm
        if (images.Count is < BusinessRulesConstants.Dorm.MinImages or > BusinessRulesConstants.Dorm.MaxImages)
            throw AppException.ValidationError(
                $"Number of images must be between {BusinessRulesConstants.Dorm.MinImages} and {BusinessRulesConstants.Dorm.MaxImages}");

        // Check for duplicate orders
        var orders = images.Select(i => i.Order).ToList();
        if (orders.Distinct().Count() != orders.Count)
            throw AppException.ValidationError("Duplicate image orders are not allowed");

        // Check if there's no primary image
        if (images.All(i => !i.IsPrimary))
            throw AppException.ValidationError("At least one image must be primary");

        // Check if there's more than one primary image
        if (images.Count(i => i.IsPrimary) > 1)
            throw AppException.ValidationError("Only one image can be primary");

        // Check file types (assuming URLs end with file extensions)
        var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
        foreach (var image in images)
        {
            var extension = Path.GetExtension(new Uri(image.Url).LocalPath).ToLower();
            if (!allowedExtensions.Contains(extension))
                throw AppException.ValidationError($"Invalid file type: {extension}", "Url");
        }

        await _dormService.UpdateImagesAsync(dormId, images);
        return Ok("Images updated successfully");
    }

    [HttpPut("{dormId}/rooms")]
    public async Task<IActionResult> UpdateRoomsAsync(int dormId, [FromBody] List<RoomRequest> rooms)
    {
        // Business rules
        if (rooms.Count is < BusinessRulesConstants.Dorm.MinRooms or > BusinessRulesConstants.Dorm.MaxRooms)
            throw AppException.ValidationError(
                $"Number of rooms must be between {BusinessRulesConstants.Dorm.MinRooms} and {BusinessRulesConstants.Dorm.MaxRooms}");

        // Validate each room
        foreach (var room in rooms)
        {
            // Price validation
            if (room.PricePerMonth < BusinessRulesConstants.Room.MinPrice ||
                room.PricePerMonth > BusinessRulesConstants.Room.MaxPrice)
                throw AppException.ValidationError(
                    $"Room price must be between {CurrencyFormatter.FormatPHP(BusinessRulesConstants.Room.MinPrice)} and {CurrencyFormatter.FormatPHP(BusinessRulesConstants.Room.MaxPrice)}",
                    "PricePerMonth");

            // Capacity validation
            if (room.Capacity < BusinessRulesConstants.Room.MinCapacity ||
                room.Capacity > BusinessRulesConstants.Room.MaxCapacity)
                throw AppException.ValidationError(
                    $"Room capacity must be between {BusinessRulesConstants.Room.MinCapacity} and {BusinessRulesConstants.Room.MaxCapacity} persons",
                    "Capacity");

            // Room number format validation (if provided)
            if (!string.IsNullOrEmpty(room.RoomNumber) &&
                room.RoomNumber.Length > BusinessRulesConstants.Room.NumberMaxLength)
                throw AppException.ValidationError(
                    $"Room number must not exceed {BusinessRulesConstants.Room.NumberMaxLength} characters",
                    "RoomNumber");

            // Room number format validation (if provided)
            var isRoomNumberValid = !string.IsNullOrEmpty(room.RoomNumber)
                                    && room.RoomNumber.Length <= 10
                                    && room.RoomNumber.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c));

            if (!string.IsNullOrEmpty(room.RoomNumber) && !isRoomNumberValid)
                throw AppException.ValidationError(
                    "Room number must be alphanumeric and maximum of 10 characters",
                    "RoomNumber");
        }

        // Check for duplicate room numbers
        var roomNumbers = rooms.Where(r => !string.IsNullOrEmpty(r.RoomNumber))
            .Select(r => r.RoomNumber);
        var enumerable = roomNumbers as string[] ?? roomNumbers.ToArray();
        if (enumerable.Distinct().Count() != enumerable.Count())
            throw AppException.ValidationError("Duplicate room numbers are not allowed");

        await _dormService.UpdateRoomsAsync(dormId, rooms);
        return Ok("Rooms updated successfully");
    }
}