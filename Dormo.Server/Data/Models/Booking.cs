using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Dormo.Server.Data.Models;

public class Booking : BaseEntity<int>
{
    [Required(ErrorMessage = "Student ID is required.")]
    public string TenantId { get; set; } = string.Empty; // Foreign key to User (Tenant)

    [ForeignKey(nameof(TenantId))]
    [JsonIgnore]
    public ApplicationUser? Tenant { get; set; }

    [Required(ErrorMessage = "Room ID is required.")]
    public int RoomId { get; set; }

    [ForeignKey(nameof(RoomId))]
    [JsonIgnore]
    public Room? Room { get; set; }

    [Required(ErrorMessage = "Move-in date is required.")]
    public DateOnly MoveInDate { get; set; }

    [Required(ErrorMessage = "Move-out date is required.")]
    public DateOnly MoveOutDate { get; set; }

    [Range(0.01, 100000.00, ErrorMessage = "Total price must be between 0.01 and 100,000.")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalPrice { get; set; }

    public BookingStatus Status { get; set; } = BookingStatus.Pending;

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime BookedAt { get; set; } = DateTime.UtcNow;

    [StringLength(500, ErrorMessage = "Notes cannot exceed 500 characters.")]
    public string? Notes { get; set; }
}

public enum BookingStatus
{
    Pending,
    Confirmed,
    Cancelled,
    Completed
}