using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Dormo.Server.Data.Models;

public class Image : BaseEntity<int>
{
    [Required] public int DormId { get; set; }

    [ForeignKey(nameof(DormId))]
    [JsonIgnore]
    public Dorm? Dorm { get; set; }

    [Required] [MaxLength(500)] public string Url { get; set; } = string.Empty;

    [MaxLength(100)] public string? Caption { get; set; }

    public bool IsPrimary { get; set; } = false;

    public int Order { get; set; } = 0;
}