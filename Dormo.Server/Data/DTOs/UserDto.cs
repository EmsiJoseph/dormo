using Dormo.Server.Constants;
using Dormo.Server.Data.Models;

namespace Dormo.Server.Data.DTOs;

public class UserDto : OwnerDto
{
    public string Role { get; set; } = RolesConstants.Tenant;

    public bool EmailSubscription { get; set; }
}