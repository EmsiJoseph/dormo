namespace Dormo.Server.Data.DTOs;

public class PaginatedDto<TDto>
    where TDto : class
{
    public IEnumerable<TDto> Items { get; set; } = null!;
    public int TotalItems { get; set; }
    public int? Page { get; set; }
    public int? PageSize { get; set; }
    public bool HasNext { get; set; }
}