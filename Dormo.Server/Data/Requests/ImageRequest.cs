namespace Dormo.Server.Data.Requests;

public class ImageRequest
{
    public required string Url { get; set; }
    public required int Order { get; set; }
    public string? Caption { get; set; }
    public bool IsPrimary { get; set; }
}
