using Dormo.Server.Data.DTOs;
using Dormo.Server.Data.Models;
using Dormo.Server.Data.Requests;

namespace Dormo.Server.Services.Interfaces;

public interface IDormService : ICrudService<DormRequest, int, DormFilter, DormDto, PaginatedDto<DormDto>>
{
    /// <summary>
    /// Search for dorms by location
    /// </summary>
    /// <param name="latitude"></param>
    /// <param name="longitude"></param>
    /// <param name="radiusInKm"></param>
    /// <returns>
    /// A list of dorms within the specified radius
    /// </returns>
    Task<IEnumerable<DormDto>> SearchByLocationAsync(decimal latitude, decimal longitude, int radiusInKm);
    /// <summary>
    /// Update the amenities of a dorm
    /// </summary>
    /// <param name="dormId"></param>
    /// <param name="amenityIds"></param>
    /// <returns>
    /// True if updated successfully, otherwise false
    /// </returns>
    Task<bool> UpdateAmenityAsync(int dormId, List<int> amenityIds);
    /// <summary>
    /// Update the tags of a dorm
    /// </summary>
    /// <param name="dormId"></param>
    /// <param name="amenityIds"></param>
    /// <returns>
    /// True if updated successfully, otherwise false
    /// </returns>
    Task<bool> UpdateTagAsync(int dormId, List<int> tagIds);
    Task<bool> UpdateImagesAsync(int dormId, List<ImageRequest> images);
    Task<bool> UpdateRoomsAsync(int dormId, List<RoomRequest> rooms);
}