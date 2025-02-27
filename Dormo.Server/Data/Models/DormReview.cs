using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Dormo.Server.Data.Models;

public class DormReview : BaseEntity<int>
{
    [Required(ErrorMessage = "Dorm ID is required.")]
    public int DormId { get; set; }

    [ForeignKey(nameof(DormId))]
    [JsonIgnore]
    public Dorm? Dorm { get; set; }

    [Required(ErrorMessage = "Student ID is required.")]
    public string TenantId { get; set; } = string.Empty; // Foreign key to User

    [ForeignKey(nameof(TenantId))]
    [JsonIgnore]
    public User? Tenant { get; set; }

    [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5.")]
    [Column(TypeName = "decimal(2,1)")]
    public decimal Rating { get; set; }

    [Required(ErrorMessage = "Review text is required.")]
    [StringLength(500, MinimumLength = 10, ErrorMessage = "Review must be between 10 and 500 characters.")]
    public string ReviewText { get; set; } = string.Empty;
}