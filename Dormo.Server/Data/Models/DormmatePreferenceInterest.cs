using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Dormo.Server.Data.Models;

[Index(nameof(PreferenceId), nameof(InterestId), IsUnique = true)]
public class DormmatePreferenceInterest : BaseEntity<int>
{
    [Required(ErrorMessage = "Dormmate Preference Id is required.")]
    public int PreferenceId { get; set; }

    [ForeignKey(nameof(PreferenceId))]
    [JsonIgnore]
    public DormmatePreference? Preference { get; set; }

    [Required(ErrorMessage = "Interest ID is required.")]
    public int InterestId { get; set; }

    [ForeignKey(nameof(InterestId))]
    [JsonIgnore]
    public Interest? Interest { get; set; }

    public int Priority { get; set; } = 0;
}