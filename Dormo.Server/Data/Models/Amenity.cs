using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dormo.Server.Data.Models;

public class Amenity : BaseEntity<int>
{
    [Required(ErrorMessage = "Name is required")]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Description is required")]
    [MaxLength(100)]
    public string Description { get; set; } = string.Empty;

    public virtual ICollection<Dorm> Dorms { get; set; } = new List<Dorm>();

    [Column(TypeName = "nvarchar(max)")] public string? Icon { get; set; } = string.Empty;
}