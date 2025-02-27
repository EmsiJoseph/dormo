public abstract class BaseFilter
{
    public int? Page { get; set; } = 1;
    public int? PageSize { get; set; } = 20;
    public string? SortBy { get; set; }
    public bool IsDescending { get; set; } = false;

    public bool IncludeDeleted { get; set; } = false;
}