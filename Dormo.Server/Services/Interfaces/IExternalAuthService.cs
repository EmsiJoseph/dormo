using Dormo.Server.Data.DTOs;

namespace Dormo.Server.Services.Interfaces;

public interface IExternalAuthService
{
    Task<(bool isExistingUser, UserDto userInfo)> HandleGoogleLoginAsync(string credential);
}
