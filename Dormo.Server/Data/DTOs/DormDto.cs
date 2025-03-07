using Dormo.Server.Data.Models;
using Dormo.Server.Data.Requests;

namespace Dormo.Server.Data.DTOs;

public class DormDto : DormRequest
{
    public int Id { get; set; }

    public string CategoryName { get; set; } = null!;
    public ReviewDto[] InitialReviews { get; set; } = null!;
    public int ReviewCount { get; set; }
    public int SafetyScore { get; set; }
    public decimal Rating { get; set; }

    public OwnerDto Owner { get; set; } = null!; // Foreign key to User (DormOwner)

    public List<DormListingDto> SimilarDorms { get; set; } = new();
    public new List<RoomDto> Rooms { get; set; } = new();
    public List<TagDto> Amenities { get; set; } = new();
    public List<TagDto> Tags { get; set; } = new();
}