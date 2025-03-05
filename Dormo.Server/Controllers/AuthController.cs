using Dormo.Server.Data.DTOs;
using Dormo.Server.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Dormo.Server.Constants;
using Dormo.Server.Data.Requests;
using Dormo.Server.Exceptions;
using Dormo.Server.Utils;

namespace Dormo.Server.Controllers;

[ApiController]
[Route("api/v1.0/[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AuthController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public class IsRegisteredRequest
    {
        public string? Email { get; set; }
    }

    public class IsRegisteredResponse
    {
        public bool IsRegistered { get; set; }
        public required string Email { get; set; }
    }

    public class GoogleRegisterDto
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PreferredFirstName { get; set; }
        public string Dob { get; set; }
        public string? ContactInfo { get; set; }
        public bool EmailSubscription { get; set; }
        public ExternalLoginDto ExternalLogin { get; set; }
    }

    public class ExternalLoginDto
    {
        public string Provider { get; set; }
        public string Email { get; set; }
    }

    [HttpPost("")]
    public async Task<IActionResult> IsRegistered(IsRegisteredRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Email))
            throw AppException.ValidationError("Email is required", "Email");

        var user = await _userManager.FindByEmailAsync(request.Email);
        return Ok(new IsRegisteredResponse
        {
            IsRegistered = user != null,
            Email = request.Email
        });
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(UserRegisterRequest request)
    {
        // Validate required fields
        if (string.IsNullOrWhiteSpace(request.Email))
            throw AppException.ValidationError("Email is required", "Email");
        if (string.IsNullOrWhiteSpace(request.Password))
            throw AppException.ValidationError("Password is required", "Password");
        if (string.IsNullOrWhiteSpace(request.FirstName))
            throw AppException.ValidationError("First name is required", "FirstName");
        if (string.IsNullOrWhiteSpace(request.LastName))
            throw AppException.ValidationError("Last name is required", "LastName");
        if (request.Dob == default)
            throw AppException.ValidationError("Date of birth is required", "Dob");

        // Check password match
        if (request.Password != request.ConfirmPassword)
            throw AppException.ValidationError("Passwords do not match", "ConfirmPassword");

        // Check age
        if (request.Dob?.AddYears(18) > DateOnly.FromDateTime(DateTime.Now))
            throw AppException.ValidationError("You must be 18 years or older to register", "Dob");

        // Check existing email
        var existingUser = await _userManager.FindByEmailAsync(request.Email);
        if (existingUser != null)
            throw AppException.ValidationError("Email is already registered", "Email");

        var newUser = new ApplicationUser
        {
            UserName = request.Email,
            PreferredFirstName = request.PreferredFirstName ?? "",
            Email = request.Email,
            Dob = request.Dob ?? default,
            FirstName = request.FirstName,
            LastName = request.LastName,
            ContactInfo = request.ContactInfo,
            Latitude = request.Latitude ?? 0,
            Longitude = request.Longitude ?? 0,
            EmailSubscription = request.EmailSubscription
        };

        // Trigger model validations
        var validUser = ValidationHelper.TryValidate(newUser, out var validationResults);
        if (!validUser)
        {
            return BadRequest(new { Message = validationResults.First().ErrorMessage });
        }

        var result = await _userManager.CreateAsync(newUser, request.Password);
        if (result.Succeeded)
        {
            await _signInManager.SignInAsync(newUser, isPersistent: false);

            // Assign role
            var roleResult = await _userManager.AddToRoleAsync(newUser, RolesConstants.Tenant);
            if (!roleResult.Succeeded)
            {
                return BadRequest(roleResult.Errors);
            }

            return Ok(new { Message = "Registration successful" });
        }

        return BadRequest(result.Errors);
    }

    [HttpPost("register-google")]
    public async Task<IActionResult> RegisterWithGoogle(GoogleRegisterDto model)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        
        // Check if user already exists
        var existingUser = await _userManager.FindByEmailAsync(model.Email);
        if (existingUser != null)
            return BadRequest(new { message = "User with this email already exists" });
        
        // Parse date of birth
        if (!DateOnly.TryParse(model.Dob, out var dob))
            return BadRequest(new { message = "Invalid date of birth format" });

        // Create user without password since it's Google auth
        var user = new ApplicationUser
        {
            UserName = model.Email,
            Email = model.Email,
            FirstName = model.FirstName,
            LastName = model.LastName,
            PreferredFirstName = model.PreferredFirstName,
            Dob = dob,
            ContactInfo = model.ContactInfo,
            EmailSubscription = model.EmailSubscription,
            CreatedAt = DateTime.UtcNow
        };
        
        var result = await _userManager.CreateAsync(user);
        if (!result.Succeeded)
            return BadRequest(result.Errors);
        
        // Create external login info
        var info = new UserLoginInfo(model.ExternalLogin.Provider, user.Id, model.Email);
        var addLoginResult = await _userManager.AddLoginAsync(user, info);
        if (!addLoginResult.Succeeded)
            return BadRequest(addLoginResult.Errors);
        
        // Sign in the user
        await _signInManager.SignInAsync(user, isPersistent: false);
        
        return Ok(new { message = "Registration successful" });
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Email))
            throw AppException.ValidationError("Email is required", "Email");
        if (string.IsNullOrWhiteSpace(request.Password))
            throw AppException.ValidationError("Password is required", "Password");

        // Check if password is correct
        var user = await _userManager.FindByEmailAsync(request.Email);
        if (user == null || !await _userManager.CheckPasswordAsync(user, request.Password))
            throw AppException.Unauthorized("Invalid login attempt");

        // Check if user is already logged in
        if (User.Identity?.IsAuthenticated ?? false)
        {
            return Ok(new { Message = "Already logged in" });
        }

        var result = await _signInManager.PasswordSignInAsync(
            request.Email, request.Password, isPersistent: false, lockoutOnFailure: false);

        if (result.Succeeded)
            return Ok(new { Message = "Login successful" });

        throw AppException.Unauthorized("Invalid login attempt");
    }

    [HttpPost("logout")]
    [AllowAnonymous]
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return Ok(new { Message = "Logout successful" });
    }

    [Authorize]
    [HttpGet("status")]
    public IActionResult GetAuthStatus()
    {
        return User.Identity is { IsAuthenticated: true }
            ? Ok(new { IsAuthenticated = true, UserName = User.Identity.Name })
            : Ok(new { IsAuthenticated = false });
    }

    [Authorize]
    [HttpGet("user")]
    public async Task<IActionResult> GetCurrentUser()
    {
        if (!User.Identity?.IsAuthenticated ?? true)
        {
            return Unauthorized();
        }

        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return NotFound();
        }

        var role = await _userManager.GetRolesAsync(user);


        return Ok(new UserDto
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            PreferredFirstName = user.PreferredFirstName,
            Email = user.Email,
            BirthYear = user.Dob.Year,
            ContactInfo = user.ContactInfo,
            Role = role.FirstOrDefault()!,
            ProfileImageUrl = user.ProfileImageUrl
        });
    }
}