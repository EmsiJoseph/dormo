using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Dormo.Server.Constants;

namespace Dormo.Server.Data.Models;

public class Dorm : BaseEntity<int>
{
    [Required(ErrorMessage = "Dorm name is required.")]
    [StringLength(BusinessRulesConstants.Dorm.NameMaxLength, 
        MinimumLength = BusinessRulesConstants.Dorm.NameMinLength, 
        ErrorMessage = "Name must be between {2} and {1} characters.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Description is required.")]
    [StringLength(BusinessRulesConstants.Dorm.DescriptionMaxLength, 
        MinimumLength = BusinessRulesConstants.Dorm.DescriptionMinLength,
        ErrorMessage = "Description must be between {2} and {1} characters.")]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "Address is required.")]
    [StringLength(BusinessRulesConstants.Dorm.AddressMaxLength, 
        ErrorMessage = "Address cannot exceed {1} characters.")]
    public string Address { get; set; } = string.Empty;

    [Range(BusinessRulesConstants.Dorm.MinRating, BusinessRulesConstants.Dorm.MaxRating, 
        ErrorMessage = "Rating must be between {1} and {2}.")]
    [Column(TypeName = "decimal(2,1)")]
    public decimal Rating { get; set; }

    public bool IsVerified { get; set; }

    [Required(ErrorMessage = "Owner ID is required.")]
    public string OwnerId { get; set; } = string.Empty; // Foreign key to User (DormOwner)

    [ForeignKey(nameof(OwnerId))]
    [JsonIgnore]
    public ApplicationUser? Owner { get; set; }

    [Required(ErrorMessage = "Category ID is required.")]
    public int CategoryId { get; set; } // Foreign key to Category

    [ForeignKey(nameof(CategoryId))]
    [JsonIgnore]
    public Category? Category { get; set; }

    [Required(ErrorMessage = "Latitude is required for mapping.")]
    [Range(BusinessRulesConstants.Coordinates.MinLatitude, BusinessRulesConstants.Coordinates.MaxLatitude, 
        ErrorMessage = "Latitude must be between {1} and {2}.")]
    [Column(TypeName = "decimal(9,6)")]
    public decimal Latitude { get; set; }

    [Required(ErrorMessage = "Longitude is required for mapping.")]
    [Range(BusinessRulesConstants.Coordinates.MinLongitude, BusinessRulesConstants.Coordinates.MaxLongitude, 
        ErrorMessage = "Longitude must be between {1} and {2}.")]
    [Column(TypeName = "decimal(9,6)")]
    public decimal Longitude { get; set; }

    public bool IsAvailable { get; set; } = true;

    // Relationships

    // One-to-Many relationship
    public virtual ICollection<Image> Images { get; set; } = new List<Image>();

    // Many-to-Many relationships - Simplified approach
    public virtual ICollection<DormTag> DormTags { get; set; } = new List<DormTag>();
    public virtual ICollection<DormAmenity> DormAmenities { get; set; } = new List<DormAmenity>();

    // Direct navigation collections for better querying
    [NotMapped]
    public virtual ICollection<Tag> Tags => DormTags.Select(dt => dt.Tag!).ToList();

    [NotMapped]
    public virtual ICollection<Amenity> Amenities => DormAmenities.Select(da => da.Amenity!).ToList();

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();

    [NotMapped] public decimal MinPrice => Rooms?.Any() == true ? Rooms.Min(r => r.PricePerMonth) : 0;

    [NotMapped] public decimal MaxPrice => Rooms?.Any() == true ? Rooms.Max(r => r.PricePerMonth) : 0;
}