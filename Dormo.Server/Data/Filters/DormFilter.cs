public class DormFilter : BaseFilter
{
    public int? CategoryId { get; set; }
    public string? OwnerId { get; set; }
    public string? Address { get; set; }
    public decimal? MinPrice { get; set; }
    public decimal? MaxPrice { get; set; }
    public bool? IsVerified { get; set; }
    public bool? IsAvailable { get; set; }
    public string? SearchTerm { get; set; }
    public List<int>? AmenityIds { get; set; }
    public List<int>? TagIds { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}