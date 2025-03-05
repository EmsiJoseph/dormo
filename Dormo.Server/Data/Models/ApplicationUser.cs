using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Dormo.Server.Data.Models;

public class ApplicationUser : IdentityUser
{
    [MaxLength(50)] public string? FirstName { get; set; }
    [MaxLength(50)] public string? LastName { get; set; }
    [MaxLength(50)] public string? PreferredFirstName { get; set; }

    [EmailAddress(ErrorMessage = "Invalid email format.")]
    [MaxLength(50)]
    public string? ContactInfo { get; set; }

    [Required(ErrorMessage = "Date of birth is required")]
    public DateOnly Dob { get; set; }

    [Column(TypeName = "decimal(10,7)")] public decimal? Latitude { get; set; }

    [Column(TypeName = "decimal(10,7)")] public decimal? Longitude { get; set; }

    public bool IsActive { get; set; } = true;

    public bool IsVerified { get; set; } = false;

    public bool IsDeleted { get; set; } = false;

    public bool EmailSubscription { get; set; } = false;

    [MaxLength(500)] public string? ProfileImageUrl { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}