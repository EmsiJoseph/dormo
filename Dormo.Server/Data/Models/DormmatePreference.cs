using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Dormo.Server.Data.Models;

public class DormmatePreference : BaseEntity<int>
{
    [Required(ErrorMessage = "User ID is required.")]
    public string UserId { get; set; } = string.Empty; // Foreign key to User

    [ForeignKey(nameof(UserId))]
    [JsonIgnore]
    public User? User { get; set; }

    public virtual ICollection<Interest> Interests { get; set; } =
        new List<Interest>();

    public virtual ICollection<Habit> Habits { get; set; } =
        new List<Habit>();

    public bool PrefersSameGender { get; set; } = false;

    public bool PrefersQuietEnvironment { get; set; } = false;

    [Range(0, 24, ErrorMessage = "Preferred sleep time must be between 0 and 24 hours.")]
    public int? PreferredSleepTime { get; set; } // Hour in 24-hour format

    [StringLength(500, ErrorMessage = "Bio cannot exceed 500 characters.")]
    public string? Bio { get; set; }
}