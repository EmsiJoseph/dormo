using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Dormo.Server.Data.Models;

[Index(nameof(Id), IsUnique = true)]
[Index(nameof(ParentId))]
public class Category : BaseEntity<int>
{
    [Required(ErrorMessage = "Name is required")]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Description is required")]
    [MaxLength(100)]
    public string Description { get; set; } = string.Empty;
    
    [Column(TypeName = "nvarchar(max)")]
    public string? Icon { get; set; } = string.Empty;

    public int? ParentId { get; set; }

    [ForeignKey(nameof(ParentId))]
    [JsonIgnore]
    public Category? ParentCategory { get; set; }

    public virtual ICollection<Category> ChildCategories { get; set; } = new List<Category>();
    public virtual ICollection<Dorm> Dorms { get; set; } = new List<Dorm>();
}