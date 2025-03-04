using System.ComponentModel.DataAnnotations;
using Dormo.Server.Data.DTOs;
using Dormo.Server.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Dormo.Server.Controllers;

[ApiController]
[Route("api/v1.0/[controller]")]
public class ExternalAuthController : ControllerBase
{
    private readonly IExternalAuthService _externalAuthService;

    public ExternalAuthController(IExternalAuthService externalAuthService)
    {
        _externalAuthService = externalAuthService;
    }

    [HttpPost("google-login")]
    public async Task<IActionResult> GoogleLogin([FromBody] GoogleAuthRequest request)
    {
        if (string.IsNullOrEmpty(request.Credential))
        {
            return BadRequest("Credential is required");
        }
        
        var (isExistingUser, userInfo) = await _externalAuthService.HandleGoogleLoginAsync(request.Credential);
        
        return Ok(new GoogleAuthResponse
        {
            IsExistingUser = isExistingUser,
            UserInfo = userInfo
        });
    }
}

public class GoogleAuthRequest
{
    [Required]
    public string Credential { get; set; } = string.Empty;
}

public class GoogleAuthResponse
{
    public bool IsExistingUser { get; set; }
    public UserDto UserInfo { get; set; } = new();
}