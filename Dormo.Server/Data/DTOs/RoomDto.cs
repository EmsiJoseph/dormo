using Dormo.Server.Data.Models;
using Dormo.Server.Data.Requests;

namespace Dormo.Server.Data.DTOs;

public class RoomDto : RoomRequest
{
    public int Id { get; set; }
}