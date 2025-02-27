using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Dormo.Server.Data.Models;

public class Visit : BaseEntity<int>
{
    [Required(ErrorMessage = "Student ID is required.")]
    public string VisitorId { get; set; } = string.Empty; // Foreign key to User (Tenant)

    [ForeignKey(nameof(VisitorId))]
    [JsonIgnore]
    public User? Visitor { get; set; }

    [Required(ErrorMessage = "Room ID is required.")]
    public int RoomId { get; set; }

    [ForeignKey(nameof(RoomId))]
    [JsonIgnore]
    public Room? Room { get; set; }

    [Required(ErrorMessage = "Schedule date is required.")]
    public DateTime Schedule { get; set; }

    public VisitStatus Status { get; set; } = VisitStatus.Pending;

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime ScheduledAt { get; set; } = DateTime.UtcNow;

    [StringLength(500, ErrorMessage = "Notes cannot exceed 500 characters.")]
    public string? Notes { get; set; }
}

public enum VisitStatus
{
    Pending,
    Confirmed,
    Cancelled,
    Completed
}