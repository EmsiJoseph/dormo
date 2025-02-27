namespace Dormo.Server.Data.Requests;

public class RoomRequest
{
    public required string RoomNumber { get; set; }
    public required string Description { get; set; }
    public required decimal PricePerMonth { get; set; }
    public int Capacity { get; set; }
    public bool IsAvailable { get; set; } = true;
}