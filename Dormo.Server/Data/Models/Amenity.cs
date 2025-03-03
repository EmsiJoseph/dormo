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

    [Column(TypeName = "nvarchar(max)")]
    public string? Icon { get; set; } = string.Empty;

    // Direct navigation to join table
    public virtual ICollection<DormAmenity> DormAmenities { get; set; } = new List<DormAmenity>();
    
    // For convenience (not used in queries)
    [NotMapped]
    public virtual ICollection<Dorm> Dorms => DormAmenities.Select(da => da.Dorm!).ToList();
}