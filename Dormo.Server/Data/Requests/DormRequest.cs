namespace Dormo.Server.Data.Requests;

public class DormRequest
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;


    public string OwnerId { get; set; } = null!; // Foreign key to User (DormOwner)

    public int CategoryId { get; set; } // Foreign key to Category

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public bool IsAvailable { get; set; } = true;

    public List<ImageRequest> Images { get; set; } = new List<ImageRequest>();
    public List<RoomRequest> Rooms { get; set; } = new List<RoomRequest>();

    public List<int> AmenityIds { get; set; } = new List<int>();

    public List<int> TagIds { get; set; } = new List<int>();
    public decimal MinPrice { get; set; }
}