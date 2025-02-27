using Dormo.Server.Constants;

namespace Dormo.Server.Data.DTOs;

public class OwnerDto
{
    public string Id { get; set; } = null!;
    public string? Email { get; set; }

    public string? PreferredFirstName { get; set; }
    public string? FirstName { get; set; }

    public string? LastName { get; set; }
    
    public int BirthYear { get; set; }

    public string? ContactInfo { get; set; }

    public bool IsVerified { get; set; }

    public string? ProfileImageUrl { get; set; }
}