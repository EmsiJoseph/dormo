using Dormo.Server.Controllers;
using Dormo.Server.Data.Models;
using Dormo.Tests.Fixtures;
using FakeItEasy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Xunit.Abstractions;
using System.Text.Json;
using Dormo.Tests.Helpers;
using System.ComponentModel.DataAnnotations;
using Dormo.Server.Data.Requests;
using Dormo.Server.Exceptions;

namespace Dormo.Tests;

public class AuthControllerTests : IClassFixture<DormoFixture>
{
    private readonly AuthController _controller;
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly ITestOutputHelper _output;

    public AuthControllerTests(DormoFixture fixture, ITestOutputHelper output)
    {
        _userManager = fixture.UserManager;
        _signInManager = fixture.SignInManager;
        _controller = new AuthController(_userManager, _signInManager);
        _output = output;
    }

    [Fact]
    public async Task Register_WithValidInputs_ReturnsSuccess()
    {
        // Arrange
        _output.WriteLine("Testing registration with valid inputs");
        var request = new UserRegisterRequest
        {
            Email = "test15@email.com",
            Password = "Password1*",
            ConfirmPassword = "Password1*",
            FirstName = "Juan",
            LastName = "Doe",
            ContactInfo = "test@email.com",
            Dob = DateOnly.FromDateTime(DateTime.Now.AddYears(-18))
        };

        // Configure UserManager to simulate no existing user
        A.CallTo(() => _userManager.FindByEmailAsync(request.Email))!
            .Returns(Task.FromResult<User>(null!));

        // Configure successful user creation
        A.CallTo(() => _userManager.CreateAsync(A<User>._, request.Password))
            .Returns(IdentityResult.Success);

        // Act
        var result = await _controller.Register(request);

        // Assert
        Assert.IsType<OkObjectResult>(result);
    }


    [Fact]
    public async Task Register_WithAgeUnder18_ReturnsBadRequest()
    {
        // Arrange
        _output.WriteLine("Testing registration with age under 18");
        var request = new UserRegisterRequest
        {
            Email = "test@email.com",
            Password = "Password1*",
            ConfirmPassword = "Password1*",
            FirstName = "Juan",
            LastName = "Doe",
            ContactInfo = "test@email.com",
            Dob = DateOnly.FromDateTime(DateTime.Now.AddYears(-17))
        };

        // Act
        var exception = await Assert.ThrowsAsync<AppException>(
            () => _controller.Register(request));

        // Assert
        var errorMessage = exception.Message;
        Assert.Equal("You must be 18 years or older to register", errorMessage);

        _output.WriteLine($"Registration failed with message: {errorMessage}");
    }

    [Fact]
    public async Task Register_WithMismatchedPasswords_ReturnsBadRequest()
    {
        // Arrange
        _output.WriteLine("Testing registration with mismatched passwords");
        var request = new UserRegisterRequest
        {
            Email = "test@email.com",
            Password = "Password1*",
            ConfirmPassword = "DifferentPassword1*",
            FirstName = "Juan",
            LastName = "Doe",
            ContactInfo = "test@email.com",
            Dob = DateOnly.FromDateTime(DateTime.Now.AddYears(-18))
        };

        // Act
        var exception = await Assert.ThrowsAsync<AppException>(
            () => _controller.Register(request));

        // Assert
        var errorMessage = exception.Message;
        Assert.Equal("Passwords do not match", errorMessage);
        _output.WriteLine($"Registration failed with message: {errorMessage}");
    }

    [Fact]
    public async Task Register_WithExistingEmail_ReturnsBadRequest()
    {
        // Arrange
        _output.WriteLine("Testing registration with existing email");
        var request = new UserRegisterRequest
        {
            Email = "existing@email.com",
            Password = "Password1*",
            ConfirmPassword = "Password1*",
            FirstName = "Juan",
            LastName = "Doe",
            ContactInfo = "test@email.com",
            Dob = DateOnly.FromDateTime(DateTime.Now.AddYears(-18))
        };

        A.CallTo(() => _userManager.FindByEmailAsync(request.Email))
            .Returns(new User { Email = request.Email, FirstName = request.FirstName, LastName = request.LastName });

        // Act
        var exception = await Assert.ThrowsAsync<AppException>(
            () => _controller.Register(request));

        // Assert
        var errorMessage = exception.Message;
        Assert.Equal("Email is already registered", errorMessage);
        _output.WriteLine($"Registration failed with message: {errorMessage}");
    }

    [Fact]
    public async Task Register_WithWeakPassword_ReturnsBadRequest()
    {
        // Arrange
        _output.WriteLine("Testing registration with weak password");
        var request = new UserRegisterRequest
        {
            Email = "test@email.com",
            Password = "weak",
            ConfirmPassword = "weak",
            FirstName = "Juan",
            LastName = "Doe",
            ContactInfo = "test@email.com",
            Dob = DateOnly.FromDateTime(DateTime.Now.AddYears(-18))
        };

        // Configure UserManager to simulate no existing user
        A.CallTo(() => _userManager.FindByEmailAsync(request.Email))
            .Returns(Task.FromResult<User>(null));

        // Configure password validation failure
        A.CallTo(() => _userManager.CreateAsync(A<User>._, request.Password))
            .Returns(IdentityResult.Failed(new IdentityError { Description = "Password too weak" }));

        // Act
        var result = await _controller.Register(request);

        // Assert
        var badRequest = Assert.IsType<BadRequestObjectResult>(result);
        var errors = Assert.IsAssignableFrom<IEnumerable<IdentityError>>(badRequest.Value);
        var error = Assert.Single(errors);
        Assert.Equal("Password too weak", error.Description);
        _output.WriteLine($"Registration failed with error: {error.Description}");
    }

    [Fact]
    public async Task Register_WithInvalidModelData_ReturnsBadRequest()
    {
        // Arrange
        _output.WriteLine("Testing registration with invalid model data");
        var request = new UserRegisterRequest
        {
            Email = "test@email.com",
            Password = "Password1*",
            ConfirmPassword = "Password1*",
            FirstName = new string('X', 100), // Exceeds MaxLength of 50
            LastName = "Doe",
            ContactInfo = "test@email.com",
            Dob = DateOnly.FromDateTime(DateTime.Now.AddYears(-18))
        };

        // Configure validation to fail
        A.CallTo(() => _userManager.CreateAsync(A<User>._, request.Password))
            .Throws(new ValidationException("First name cannot exceed 50 characters"));

        // Act
        var result = await _controller.Register(request);

        // Assert
        var badRequest = Assert.IsType<BadRequestObjectResult>(result);
        var response = JsonSerializer.Deserialize<ErrorResponse>(
            JsonSerializer.Serialize(badRequest.Value));
        Assert.Contains("FirstName", response.Message);
        _output.WriteLine($"Registration failed with validation error: {response.Message}");
    }


    [Fact]
    public async Task Register_WithNullFields_ReturnsBadRequest()
    {
        // Arrange
        _output.WriteLine("Testing registration with null fields");
        var request = new UserRegisterRequest
        {
            Email = null,
            Password = "Password1*",
            ConfirmPassword = "Password1*",
            FirstName = "Juan",
            LastName = "Doe",
            Dob = DateOnly.FromDateTime(DateTime.Now.AddYears(-18))
        };

        // Act
        // Act
        var exception = await Assert.ThrowsAsync<AppException>(
            () => _controller.Register(request));

        // Assert
        var errorMessage = exception.Message;
        Assert.Contains("Email", errorMessage);
        _output.WriteLine($"Registration failed with error: {errorMessage}");
    }

    [Fact]
    public async Task IsRegistered_WithExistingEmail_ReturnsTrue()
    {
        // Arrange
        _output.WriteLine("Testing IsRegistered with existing email");
        var request = new AuthController.IsRegisteredRequest
        {
            Email = "existing@email.com"
        };

        A.CallTo(() => _userManager.FindByEmailAsync(request.Email))
            .Returns(new User { Email = request.Email, FirstName = "Juan", LastName = "Doe" });

        // Act
        var result = await _controller.IsRegistered(request);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var response = Assert.IsType<AuthController.IsRegisteredResponse>(okResult.Value);
        Assert.True(response.IsRegistered);
        Assert.Equal(request.Email, response.Email);
        _output.WriteLine($"IsRegistered check succeeded: Email {request.Email} is registered");
    }

    [Fact]
    public async Task IsRegistered_WithNewEmail_ReturnsFalse()
    {
        // Arrange
        _output.WriteLine("Testing IsRegistered with new email");
        var request = new AuthController.IsRegisteredRequest
        {
            Email = "new@email.com"
        };

        A.CallTo(() => _userManager.FindByEmailAsync(request.Email))!
            .Returns(Task.FromResult<User>(null!));

        // Act
        var result = await _controller.IsRegistered(request);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var response = Assert.IsType<AuthController.IsRegisteredResponse>(okResult.Value);
        Assert.False(response.IsRegistered);
        Assert.Equal(request.Email, response.Email);
        _output.WriteLine($"IsRegistered check succeeded: Email {request.Email} is not registered");
    }

    [Fact]
    public async Task IsRegistered_WithNullEmail_ThrowsAppException()
    {
        // Arrange
        _output.WriteLine("Testing IsRegistered with null email");
        var request = new AuthController.IsRegisteredRequest
        {
            Email = null
        };

        // Act & Assert
        var exception = await Assert.ThrowsAsync<AppException>(
            () => _controller.IsRegistered(request));

        Assert.Equal("Email is required", exception.Message);
        Assert.Equal("Email", exception.PropertyName);
        _output.WriteLine($"IsRegistered check threw expected exception: {exception.Message}");
    }

    [Fact]
    public async Task Login_WithValidCredentials_ReturnsSuccess()
    {
        // Arrange
        _output.WriteLine("Testing login with valid credentials");
        var request = new LoginRequest
        {
            Email = "test@email.com",
            Password = "Password1*"
        };

        var user = new User 
        { 
            Email = request.Email,
            UserName = request.Email, // Important: UserName must be set
            EmailConfirmed = true
        };

        A.CallTo(() => _userManager.FindByEmailAsync(request.Email))
            .Returns(Task.FromResult(user));

        A.CallTo(() => _userManager.CheckPasswordAsync(user, request.Password))
            .Returns(Task.FromResult(true));

        A.CallTo(() => _signInManager.PasswordSignInAsync(
                user, request.Password, false, false))
            .Returns(Task.FromResult(Microsoft.AspNetCore.Identity.SignInResult.Success));

        // Act
        var result = await _controller.Login(request);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var response = JsonSerializer.Deserialize<ErrorResponse>(
            JsonSerializer.Serialize(okResult.Value));
        Assert.Equal("Login successful", response.Message);
        _output.WriteLine("Login succeeded");
    }

    [Fact]
    public async Task Login_WithInvalidCredentials_ReturnsInvalidCredentials()
    {
        // Arrange
        _output.WriteLine("Testing login with invalid credentials");
        var request = new LoginRequest
        {
            Email = "test@email.com",
            Password = "wrongpassword"
        };

        A.CallTo(() => _signInManager.PasswordSignInAsync(
                request.Email, request.Password, false, false))
            .Returns(Microsoft.AspNetCore.Identity.SignInResult.Failed);

        // Act
        var exception = await Assert.ThrowsAsync<AppException>(
            () => _controller.Login(request));

        // Assert
        Assert.Equal("Invalid login attempt", exception.Message);
        _output.WriteLine("Login failed as expected");
    }

    [Fact]
    public async Task Logout_ReturnsSuccess()
    {
        // Arrange
        _output.WriteLine("Testing logout");
        A.CallTo(() => _signInManager.SignOutAsync())
            .Returns(Task.CompletedTask);

        // Act
        var result = await _controller.Logout();

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var response = JsonSerializer.Deserialize<ErrorResponse>(
            JsonSerializer.Serialize(okResult.Value));
        Assert.Equal("Logout successful", response.Message);
        _output.WriteLine("Logout succeeded");
    }

    [Fact]
    public void GetAuthStatus_WhenAuthenticated_ReturnsTrue()
    {
        // Arrange
        _output.WriteLine("Testing auth status for authenticated user");
        var controller = ControllerTestHelpers.CreateControllerWithIdentity(
            _controller, "testuser@email.com", true);

        // Act
        var result = controller.GetAuthStatus();

        // Assert
        var response = GetSuccessMessage(result);
        Assert.True((bool)response.IsAuthenticated);
        Assert.Equal("testuser@email.com", (string)response.UserName);
    }

    // Helper class for typed responses
    private class ErrorResponse
    {
        public string Message { get; set; }
    }

    private class SuccessResponse
    {
        public bool IsAuthenticated { get; set; }
        public string UserName { get; set; }
    }

    private SuccessResponse GetSuccessMessage(IActionResult result)
    {
        var okRequest = Assert.IsType<OkObjectResult>(result);
        var response = JsonSerializer.Deserialize<SuccessResponse>(
            JsonSerializer.Serialize(okRequest.Value));
        return response!;
    }
}