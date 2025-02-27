using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Dormo.Server.Data.Models;

public class Interest : BaseEntity<int>
{
    [Required(ErrorMessage = "Name is required")]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Description is required")]
    [MaxLength(200)]
    public string Description { get; set; } = string.Empty;

    [MaxLength(500)] public string? IconUrl { get; set; }

    public virtual ICollection<DormmatePreference> DormmatePreferences { get; set; } =
        new List<DormmatePreference>();
}