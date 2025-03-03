using Dormo.Server.Data.Requests;

namespace Dormo.Server.Data.DTOs;

public class DormListingDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string OwnerId { get; set; } = string.Empty;
    public bool IsAvailable { get; set; }
    public bool IsVerified { get; set; }
    public decimal MinPrice { get; set; }
    public int AvailableRooms { get; set; }
    public decimal Rating { get; set; }

    public ImageRequest[]? Images { get; set; }

    public string CategoryName { get; set; } = string.Empty;
}