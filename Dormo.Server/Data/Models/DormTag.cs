using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Dormo.Server.Data.Models;

public class DormTag : BaseEntity<int>
{
    [Required] public int DormId { get; set; }

    [ForeignKey(nameof(DormId))]
    [JsonIgnore]
    public Dorm? Dorm { get; set; }

    [Required] public int TagId { get; set; }

    [ForeignKey(nameof(TagId))]
    [JsonIgnore]
    public Tag? Tag { get; set; }
}