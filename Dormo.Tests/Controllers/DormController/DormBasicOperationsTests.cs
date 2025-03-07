using Dormo.Server.Constants;
using Dormo.Tests.Controllers.Base;
using Dormo.Server.Data.DTOs;
using Dormo.Server.Data.Models;
using Dormo.Server.Data.Requests;
using Dormo.Server.Exceptions;
using Dormo.Tests.Fixtures;
using FakeItEasy;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Xunit.Abstractions;

namespace Dormo.Tests.Controllers.DormController;

public class DormBasicOperationsTests : DormControllerTestBase
{
    public DormBasicOperationsTests(DormoFixture fixture, ITestOutputHelper output)
        : base(fixture, output)
    {
    }

    [Fact]
    public async Task CreateAsync_ValidDorm_ReturnsOkResult()
    {
        // Arrange
        var request = CreateValidDormRequest();
        var dto = CreateValidDormDto();

        A.CallTo(() => _userManager.FindByIdAsync(TestUserId))
            .Returns(new ApplicationUser
                { Id = TestUserId, FirstName = TestUserFirstName, LastName = TestUserLastName });

        // Update this to return a PaginatedDto instead of a List
        A.CallTo(() => _dormService.GetAllAsync(A<DormFilter>._))
            .Returns(new PaginatedDto<DormListingDto> { Items = new List<DormListingDto>() });

        A.CallTo(() => _dormService.CreateAsync(A<DormRequest>._))
            .Returns(dto);

        // Act
        var result = await _controller.CreateAsync(request);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var returnValue = Assert.IsType<DormDto>(okResult.Value);
        Assert.Equal(request.Name, returnValue.Name);
        _output.WriteLine($"Dorm created successfully: {returnValue.Name}");
    }


    [Fact]
    public async Task CreateAsync_ExceedsHourlyLimit_ThrowsException()
    {
        // Arrange
        var request = CreateValidDormRequest();

        // Create existing dorms with the same owner ID
        var existingDorms = Enumerable.Range(1, BusinessRulesConstants.Dorm.MaxListingsPerHour)
            .Select(i => new DormListingDto
            {
                Id = i,
                OwnerId = TestUserId
            })
            .ToList();

        A.CallTo(() => _userManager.FindByIdAsync(TestUserId))
            .Returns(new ApplicationUser
                { Id = TestUserId, FirstName = TestUserFirstName, LastName = TestUserLastName });

        // The important part is to make sure we're matching the exact filter pattern used in the controller
        A.CallTo(() => _dormService.GetAllAsync(A<DormFilter>.That.Matches(f =>
                f.OwnerId == TestUserId && f.CreatedAt != default)))
            .Returns(new PaginatedDto<DormListingDto> { Items = existingDorms });

        // Act & Assert
        var exception = await Assert.ThrowsAsync<AppException>(() => _controller.CreateAsync(request));
        Assert.Contains("exceeded the maximum number", exception.Message);
        _output.WriteLine($"Creation blocked as expected: {exception.Message}");
    }

    [Fact]
    public async Task CreateAsync_DuplicateAddress_ThrowsException()
    {
        // Arrange
        var request = CreateValidDormRequest(); // Use a fully valid request with rooms, images, etc.
        request.Address = "Existing Address";

        var existingDorms = new List<DormListingDto>
        {
            new() { Address = "Existing Address", OwnerId = TestUserId }
        };

        A.CallTo(() => _userManager.FindByIdAsync(TestUserId))
            .Returns(new ApplicationUser
                { Id = TestUserId, FirstName = TestUserFirstName, LastName = TestUserLastName });

        A.CallTo(() => _dormService.GetAllAsync(A<DormFilter>._))
            .Returns(new PaginatedDto<DormListingDto> { Items = existingDorms });

        // Act & Assert
        var exception = await Assert.ThrowsAsync<AppException>(() => _controller.CreateAsync(request));
        Assert.Contains("Address already exists", exception.Message);
        _output.WriteLine($"Creation blocked as expected: {exception.Message}");
    }

    [Fact]
    public async Task UpdateAsync_ValidDorm_ReturnsOkResult()
    {
        // Arrange
        var dto = new DormDto
        {
            Id = 1,
            Name = "Updated Dorm",
            Description = "Updated Description"
        };

        A.CallTo(() => _dormService.UpdateAsync(dto))
            .Returns(true);

        // Act
        var result = await _controller.UpdateAsync(dto);

        // Assert
        Assert.IsType<OkObjectResult>(result);
        _output.WriteLine("Dorm updated successfully");
    }


    [Fact]
    public async Task DeleteAsync_ExistingDorm_ReturnsOkResult()
    {
        // Arrange
        var dormId = 1;
        A.CallTo(() => _dormService.SoftDeleteAsync(dormId))
            .Returns(true);

        // Act
        var result = await _controller.DeleteAsync(dormId);

        // Assert
        Assert.IsType<OkObjectResult>(result);
        _output.WriteLine($"Dorm {dormId} deleted successfully");
    }

    [Theory]
    [InlineData(1, 5000)]
    [InlineData(50, 1)]
    public async Task GetAllAsync_WithFilters_ReturnsFilteredResults(int page, int pageSize) // Added missing parameters
    {
        // Arrange
        var filter = new DormFilter
        {
            Page = page,
            PageSize = pageSize,
            MinPrice = 1000,
            MaxPrice = 5000
        };

        var dorms = Enumerable.Range(1, 5)
            .Select(i => new DormListingDto { Id = i })
            .ToList();

        // Update this to return a PaginatedDto
        A.CallTo(() => _dormService.GetAllAsync(filter))
            .Returns(new PaginatedDto<DormListingDto> { Items = dorms, TotalItems = dorms.Count });

        // Act
        var result = await _controller.GetAllAsync(filter);

        // Assert
        Assert.IsType<ActionResult<PaginatedDto<DormListingDto>>>(result);
    }

    [Fact]
    public async Task GetAllAsync_WithOwnerFilter_ReturnsOwnerDorms()
    {
        // Arrange
        var owner = new UserDto
        {
            Id = "test-user-id",
            FirstName = "Test",
            LastName = "User"
        };
        var filter = new DormFilter { OwnerId = owner.Id };
        var ownerDorms = new List<DormListingDto>
        {
            new() { Id = 1, OwnerId = owner.Id },
            new() { Id = 2, OwnerId = owner.Id }
        };

        // Update this to return a PaginatedDto
        A.CallTo(() => _dormService.GetAllAsync(filter))
            .Returns(new PaginatedDto<DormListingDto> { Items = ownerDorms });

        // Act
        var result = await _controller.GetAllAsync(filter);

        // Assert
        Assert.IsType<ActionResult<PaginatedDto<DormListingDto>>>(result);
    }

    [Fact]
    public async Task GetAllAsync_WithPriceRange_ReturnsFilteredDorms()
    {
        // Arrange
        var filter = new DormFilter
        {
            MinPrice = 5000,
            MaxPrice = 10000
        };

        var dorms = new List<DormListingDto>
        {
            CreateValidDormListingDto(1),
            CreateValidDormListingDto(2)
        };

        // Update this to return a PaginatedDto
        A.CallTo(() => _dormService.GetAllAsync(filter))
            .Returns(new PaginatedDto<DormListingDto> { Items = dorms });

        // Act
        var result = await _controller.GetAllAsync(filter);

        // Assert
        Assert.IsType<ActionResult<PaginatedDto<DormListingDto>>>(result);
    }
}