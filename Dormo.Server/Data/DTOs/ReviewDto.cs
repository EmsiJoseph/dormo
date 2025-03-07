using System;

namespace Dormo.Server.Data.DTOs;

public class ReviewDto
{
    public int Id { get; set; }
    public UserDto Tenant { get; set; } = new UserDto();
    public decimal Rating { get; set; }
    public string ReviewText { get; set; } = string.Empty;
    public DateTime? CreatedAt { get; set; }
}
