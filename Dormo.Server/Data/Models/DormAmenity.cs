using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Dormo.Server.Data.Models;


namespace Dormo.Server.Data.Models;

public class DormAmenity : BaseEntity<int>
{
    [Required] public int DormId { get; set; }

    [ForeignKey(nameof(DormId))]
    [JsonIgnore]
    public Dorm? Dorm { get; set; }

    [Required] public int AmenityId { get; set; }

    [ForeignKey(nameof(AmenityId))]
    [JsonIgnore]
    public Amenity? Amenity { get; set; }
}