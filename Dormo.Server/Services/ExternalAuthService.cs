using Dormo.Server.Data;
using Dormo.Server.Data.DTOs;
using Dormo.Server.Data.Models;
using Dormo.Server.Exceptions;
using Dormo.Server.Services.Interfaces;
using Google.Apis.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Dormo.Server.Services;

public class ExternalAuthService : IExternalAuthService
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly ApplicationDbContext _context;
    private readonly IConfiguration _configuration;

    public ExternalAuthService(
        UserManager<User> userManager,
        SignInManager<User> signInManager,
        ApplicationDbContext context,
        IConfiguration configuration)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _context = context;
        _configuration = configuration;
    }

    public async Task<(bool isExistingUser, UserDto userInfo)> HandleGoogleLoginAsync(string credential)
    {
        var settings = new GoogleJsonWebSignature.ValidationSettings
        {
            Audience = new[] { _configuration["Authentication:Google:ClientId"] }
        };

        GoogleJsonWebSignature.Payload payload;
        
        try
        {
            payload = await GoogleJsonWebSignature.ValidateAsync(credential, settings);
        }
        catch (Exception ex)
        {
            throw AppException.Unauthorized($"Invalid Google credentials: {ex.Message}");
        }

        // Check if user exists
        var user = await _userManager.FindByEmailAsync(payload.Email);
        var isExistingUser = user != null;

        if (isExistingUser)
        {
            // Sign in the existing user
            await _signInManager.SignInAsync(user, isPersistent: true);
        }
     

        // Return user info regardless of whether they exist or not
        var userDto = new UserDto
        {
            Email = payload.Email,
            FirstName = payload.GivenName,
            LastName = payload.FamilyName,
            ProfileImageUrl = payload.Picture
        };

        return (isExistingUser, userDto);
    }
}
