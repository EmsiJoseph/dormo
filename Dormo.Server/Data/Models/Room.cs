using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Dormo.Server.Data.Models;

public class Room : BaseEntity<int>
{
    [Required(ErrorMessage = "Room number/name is required.")]
    [StringLength(50)]
    public string RoomNumber { get; set; } = string.Empty;

    [Required(ErrorMessage = "Description is required.")]
    [StringLength(500)]
    public string Description { get; set; } = string.Empty;

    [Required] public int DormId { get; set; }

    [ForeignKey(nameof(DormId))]
    [JsonIgnore]
    public Dorm? Dorm { get; set; }

    [Required]
    [Range(1, 10, ErrorMessage = "Capacity must be between 1 and 10")]
    public int Capacity { get; set; }

    [Required]
    [Range(0.01, 100000.00)]
    [Column(TypeName = "decimal(18,2)")]
    public decimal PricePerMonth { get; set; }

    public bool IsAvailable { get; set; } = true;

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual ICollection<Visit> Visits { get; set; } = new List<Visit>();
}