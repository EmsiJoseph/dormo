using Dormo.Server.Data.Models;

namespace Dormo.Server.Data.DTOs;

public class CategoryDto
{
    public string Name { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public int? ParentId { get; set; }
}