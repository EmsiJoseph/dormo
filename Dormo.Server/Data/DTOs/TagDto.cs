using Dormo.Server.Data.Models;

namespace Dormo.Server.Data.DTOs;

public class TagDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Icon { get; set; }
    public string Type { get; set; } = TagType.Tag;
}