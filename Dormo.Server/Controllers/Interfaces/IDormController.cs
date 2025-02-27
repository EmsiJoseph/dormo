using Dormo.Server.Data.DTOs;
using Dormo.Server.Data.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Dormo.Server.Controllers.Interfaces;

public interface IDormController : ICrudController<DormRequest, int, DormFilter, DormDto>
{
    Task<IActionResult> UpdateMetaDataAsync(int dormId, string metaDataType, List<int> metaDataIds);
    Task<IActionResult> UpdateImagesAsync(int dormId, List<ImageRequest> images);
    Task<IActionResult> UpdateRoomsAsync(int dormId, List<RoomRequest> rooms);
}