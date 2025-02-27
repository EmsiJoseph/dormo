using Dormo.Server.Data.Models;
using Dormo.Server.Data.Requests;

namespace Dormo.Server.Data.DTOs;

public class DormDto : DormRequest
{
    public int Id { get; set; }

    public decimal Rating { get; set; }
    public bool IsVerified { get; set; }
    public OwnerDto Owner { get; set; } = null!; // Foreign key to User (DormOwner)

    public CategoryDto Category { get; set; } = null!;// Foreign key to Category
    
    public new List<RoomDto> Rooms { get; set; } = new List<RoomDto>();
    public List<AmenityDto> Amenities { get; set; } = new();
    public List<TagDto> Tags { get; set; } = new();
}