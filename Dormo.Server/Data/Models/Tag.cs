using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dormo.Server.Data.Models;

public class Tag : BaseEntity<int>
{
    [Required(ErrorMessage = "Name is required")]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Description is required")]
    [MaxLength(200)]
    public string Description { get; set; } = string.Empty;

    [Column(TypeName = "nvarchar(max)")]
    public string? Icon { get; set; } = string.Empty;

    // Direct navigation to join table
    public virtual ICollection<DormTag> DormTags { get; set; } = new List<DormTag>();
    
    // For convenience (not used in queries)
    [NotMapped]
    public virtual ICollection<Dorm> Dorms => DormTags.Select(dt => dt.Dorm!).ToList();
}