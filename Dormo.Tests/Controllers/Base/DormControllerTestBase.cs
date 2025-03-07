using Dormo.Server.Data.Models;
using Dormo.Tests.Fixtures;
using FakeItEasy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Dormo.Server.Constants;
using Dormo.Server.Data.DTOs;
using Dormo.Server.Data.Requests;
using Dormo.Server.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Xunit.Abstractions;

namespace Dormo.Tests.Controllers.Base;

public abstract class DormControllerTestBase : IClassFixture<DormoFixture>
{
    protected readonly Server.Controllers.DormController _controller;
    protected readonly IDormService _dormService;
    protected readonly UserManager<ApplicationUser> _userManager;
    protected readonly ITestOutputHelper _output;
    protected const string TestUserId = "test-user-id";
    protected const string TestUserFirstName = "Test";
    protected const string TestUserLastName = "User";

    protected DormControllerTestBase(DormoFixture fixture, ITestOutputHelper output)
    {
        _dormService = fixture.DormService;
        _userManager = fixture.UserManager;
        _controller = new Server.Controllers.DormController(_dormService, _userManager);
        _output = output;

        // Set up authentication and user
        SetupControllerWithIdentity();
        SetupDefaultMocks();
    }

    // Setup methods for common test configurations
    
    protected void SetupControllerWithIdentity()
    {
        var user = new ClaimsPrincipal(new ClaimsIdentity(new[]
        {
            new Claim(ClaimTypes.NameIdentifier, TestUserId),
            new Claim(ClaimTypes.Name, "test@example.com")
        }, "mock"));

        _controller.ControllerContext = new ControllerContext
        {
            HttpContext = new DefaultHttpContext { User = user }
        };
    }
    
    protected void SetupDefaultMocks()
    {
        // Set up the user manager to return a test user
        var testUser = new ApplicationUser 
        { 
            Id = TestUserId, 
            FirstName = TestUserFirstName, 
            LastName = TestUserLastName 
        };
        
        A.CallTo(() => _userManager.FindByIdAsync(TestUserId))
            .Returns(testUser);
            
        // Set up dormService to return empty results by default
        A.CallTo(() => _dormService.GetAllAsync(A<DormFilter>._))
            .Returns(new PaginatedDto<DormListingDto> { Items = new List<DormListingDto>() });
    }
    
    // Setup methods for specific scenarios
    
    protected void SetupDormServiceToReturnDorms(IEnumerable<DormListingDto> dorms)
    {
        A.CallTo(() => _dormService.GetAllAsync(A<DormFilter>._))
            .Returns(new PaginatedDto<DormListingDto> { Items = dorms.ToList() });
    }
    
    protected void SetupDormCreation(DormDto resultDorm)
    {
        A.CallTo(() => _dormService.CreateAsync(A<DormRequest>._))
            .Returns(resultDorm);
    }

    // Helper methods for creating test data
    
    protected static List<ImageRequest> GenerateValidImageRequests(int count = 3)
    {
        return Enumerable.Range(1, count)
            .Select(i => new ImageRequest
            {
                Url = $"https://example.com/image{i}.jpg",
                Order = i,
                IsPrimary = i == 1,
                Caption = $"Image {i}"
            })
            .ToList();
    }

    protected static List<RoomRequest> GenerateValidRoomRequests(int count = 2, decimal basePrice = 5000)
    {
        return Enumerable.Range(1, count)
            .Select(i => new RoomRequest
            {
                RoomNumber = $"{i}01",
                Description = $"Room {i}",
                PricePerMonth = basePrice * i,
                Capacity = Math.Min(i, BusinessRulesConstants.Room.MaxCapacity),
                IsAvailable = true
            })
            .ToList();
    }

    protected static DormRequest CreateValidDormRequest(string name = "Test Dorm", string address = "123 Test St.")
    {
        return new DormRequest
        {
            Name = name,
            Description = "Test Description",
            Address = address,
            Latitude = 14.5m,
            Longitude = 121.0m,
            CategoryId = 1,
            AmenityIds = new List<int> { 1, 2 },
            TagIds = new List<int> { 1, 2 },
            Images = GenerateValidImageRequests(),
            Rooms = GenerateValidRoomRequests(),
        };
    }

    protected static DormDto CreateValidDormDto(int id = 0)
    {
        return new DormDto
        {
            Id = id,
            Name = "Test Dorm",
            Description = "Test Description",
            Rooms = GenerateValidRoomRequests().Select(r => new RoomDto
            {
                RoomNumber = r.RoomNumber,
                Description = r.Description,
                PricePerMonth = r.PricePerMonth,
                Capacity = r.Capacity,
                IsAvailable = r.IsAvailable,
            }).ToList(),
            Address = "123 Test St.",
            Latitude = 14.5m,
            Longitude = 121.0m,
            CategoryId = 1,
            CategoryName = "Test Category",
            Owner = new OwnerDto { Id = TestUserId, FirstName = TestUserFirstName, LastName = TestUserLastName },
            AmenityIds = new List<int> { 1, 2 },
            TagIds = new List<int> { 1, 2 },
        };
    }

    protected static DormListingDto CreateValidDormListingDto(int id = 0, string ownerId = TestUserId)
    {
        return new DormListingDto
        {
            Id = id,
            Name = "Test Dorm",
            Address = "123 Test St.",
            CategoryName = "Test Category",
            OwnerId = ownerId,
            Images = GenerateValidImageRequests(),
        };
    }
}