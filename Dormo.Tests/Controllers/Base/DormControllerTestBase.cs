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

        SetupTestUser();
    }

    private void SetupTestUser()
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

    // Common helper methods
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

    protected static List<RoomDto> GenerateValidRoomDtos(int count = 2)
    {
        return Enumerable.Range(1, count)
            .Select(i => new RoomDto
            {
                Id = i,
                RoomNumber = $"{i}01",
                Description = $"Room {i}",
                PricePerMonth = 5000 * i,
                Capacity = Math.Min(i, BusinessRulesConstants.Room.MaxCapacity),
                IsAvailable = true
            })
            .ToList();
    }
    protected static List<RoomRequest> GenerateValidRoomRequests(int count = 2)
    {
        return Enumerable.Range(1, count)
            .Select(i => new RoomRequest
            {
                RoomNumber = $"{i}01",
                Description = $"Room {i}",
                PricePerMonth = 5000 * i,
                Capacity = Math.Min(i, BusinessRulesConstants.Room.MaxCapacity),
                IsAvailable = true
            })
            .ToList();
    }

    protected static DormRequest CreateValidDormRequest()
    {
        return new DormRequest
        {
            Name = "Test Dorm",
            Description = "Test Description",
            Address = "123 Test St.",
            Latitude = 14.5m,
            Longitude = 121.0m,
            CategoryId = 1,
            AmenityIds = new List<int> { 1, 2 },
            TagIds = new List<int> { 1, 2 },
            Images = GenerateValidImageRequests(),
            Rooms = GenerateValidRoomRequests(),
            
        };
    }

    protected static DormDto CreateValidDormDto(int id = 0, bool isDeleted = false)
    {
      
        return new DormDto
        {
            Id = id,
            Name = "Test Dorm",
            Description = "Test Description",
            Address = "123 Test St.",
            Latitude = 14.5m,
            Longitude = 121.0m,
            Category = new CategoryDto
            {
                Name = "Test Category"
            },
            AmenityIds = new List<int> { 1, 2 },
            TagIds = new List<int> { 1, 2 },
            Images = GenerateValidImageRequests(),
            Rooms = GenerateValidRoomDtos(),
        };
    }

    protected void SetupSuccessfulUserLookup()
    {
        A.CallTo(() => _userManager.FindByIdAsync(TestUserId))
            .Returns(new ApplicationUser { Id = TestUserId, FirstName = TestUserFirstName, LastName = TestUserLastName });
    }

    protected void SetupEmptyDormsList()
    {
        A.CallTo(() => _dormService.GetAllAsync(A<DormFilter>._))
            .Returns(new PaginatedDto<DormDto> { Items = new List<DormDto>() });
    }
}