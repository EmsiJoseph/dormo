using System.Security.Claims;
using Dormo.Server.Data.Models;
using Dormo.Server.Exceptions;
using Google.Apis.Auth.OAuth2;
using Google.Apis.PeopleService.v1;
using Google.Apis.PeopleService.v1.Data;
using Google.Apis.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Dormo.Server.Controllers;

[ApiController]
[Route("api/v1.0/[controller]")]
public class ExternalLoginController : ControllerBase
{
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly UserManager<ApplicationUser> _userManager;
    private const string GoogleUserDataKey = "GoogleUserData";

    public ExternalLoginController(UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [HttpGet("Login")]
    public IActionResult Login(string provider, string? returnUrl = null)
    {
        var redirectUrl = Url.Action("LoginCallback", "ExternalLogin", new { returnUrl });
        var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
        return Challenge(properties, provider);
    }

    [HttpGet("LoginCallback")]
    public async Task<IActionResult> LoginCallback(string? returnUrl = null)
    {
        var externalLoginInfo = await _signInManager.GetExternalLoginInfoAsync();
        if (externalLoginInfo == null) 
            return RedirectToAction("Error", "Home", new { message = "Error loading external login information." });

        var email = externalLoginInfo.Principal.FindFirstValue(ClaimTypes.Email);
        var firstName = externalLoginInfo.Principal.FindFirstValue(ClaimTypes.GivenName);
        var lastName = externalLoginInfo.Principal.FindFirstValue(ClaimTypes.Surname);

        if (string.IsNullOrEmpty(email))
            return RedirectToAction("Error", "Home", new { message = "Email not provided by external provider." });

        // Get Google profile details
        var accessToken = externalLoginInfo.AuthenticationTokens?
            .FirstOrDefault(t => t.Name == "access_token")?.Value;
        var (gender, dob) = await GetGoogleUserDetails(accessToken);

        var existingUser = await _userManager.FindByEmailAsync(email);
        
        if (existingUser == null)
        {
            // User doesn't exist - store info in session and redirect to frontend
            var userData = new
            {
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                Dob = dob?.ToString("yyyy-MM-dd"),
                IsNewUser = true
            };
            
            // Store in session with camelCase serialization
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            HttpContext.Session.SetString(GoogleUserDataKey, JsonSerializer.Serialize(userData, options));
            
            // Create a clean return URL
            var baseReturnUrl = returnUrl?.Split('?')[0] ?? "/";
            var delimiter = baseReturnUrl.Contains('?') ? '&' : '?';
            var redirectUrl = $"{baseReturnUrl}{delimiter}checkGoogleAuth=true";
            
            return Redirect(redirectUrl);
        }

        // User exists - sign them in
        var result = await _signInManager.ExternalLoginSignInAsync(
            externalLoginInfo.LoginProvider,
            externalLoginInfo.ProviderKey,
            isPersistent: false,
            bypassTwoFactor: true
        );

        if (!result.Succeeded) 
        {
            // Try to link the external login with the existing account
            var addLoginResult = await _userManager.AddLoginAsync(existingUser, externalLoginInfo);
            if (!addLoginResult.Succeeded)
            {
                return RedirectToAction("Error", "Home", new { message = "Error signing in with external provider" });
            }
            
            // Now try to sign in again
            result = await _signInManager.ExternalLoginSignInAsync(
                externalLoginInfo.LoginProvider,
                externalLoginInfo.ProviderKey,
                isPersistent: false,
                bypassTwoFactor: true
            );
            
            if (!result.Succeeded)
                return RedirectToAction("Error", "Home", new { message = "Error signing in with external provider" });
        }

        return Redirect(returnUrl ?? "/");
    }

    [HttpGet("GetUserData")]
    public IActionResult GetUserData()
    {
        if (!HttpContext.Session.TryGetValue(GoogleUserDataKey, out var userData) || userData == null)
        {
            return NotFound();
        }
        
        // Get the data as string
        var userDataString = HttpContext.Session.GetString(GoogleUserDataKey);
        
        // Clear the session data after retrieving it
        HttpContext.Session.Remove(GoogleUserDataKey);
        
        return Content(userDataString, "application/json");
    }

    private async Task<(string gender, DateOnly? dob)> GetGoogleUserDetails(string accessToken)
    {
        try
        {
            if (string.IsNullOrEmpty(accessToken))
                return (null, null);

            var peopleService = new PeopleServiceService(new BaseClientService.Initializer
            {
                HttpClientInitializer = GoogleCredential.FromAccessToken(accessToken),
                ApplicationName = "Dormo"
            });

            var request = peopleService.People.Get("people/me");
            request.PersonFields = "genders,birthdays";
            Person profile = await request.ExecuteAsync();

            // Convert the string to title case (first letter capitalized)
            var gender = profile.Genders?.FirstOrDefault()?.Value?.First().ToString().ToUpper() +
                         profile.Genders?.FirstOrDefault()?.Value?.Substring(1);

            var birthday = profile.Birthdays?.FirstOrDefault()?.Date;
            DateOnly? dob = null;

            if (birthday?.Year != null && birthday?.Month != null && birthday?.Day != null)
            {
                dob = new DateOnly(birthday.Year.Value, birthday.Month.Value, birthday.Day.Value);
            }

            return (gender, dob);
        }
        catch (Exception ex)
        {
            return (null, null);
        }
    }
}