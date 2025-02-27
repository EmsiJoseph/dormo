using Dormo.Server.Constants;
using Dormo.Tests.Controllers.Base;
using Dormo.Server.Data.DTOs;
using Dormo.Server.Data.Models;
using Dormo.Server.Data.Requests;
using Dormo.Server.Exceptions;
using Dormo.Tests.Fixtures;
using FakeItEasy;
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
            .Returns(new User { Id = TestUserId, FirstName = TestUserFirstName, LastName = TestUserLastName });

        // Update this to return a PaginatedDto instead of a List
        A.CallTo(() => _dormService.GetAllAsync(A<DormFilter>._))
            .Returns(new PaginatedDto<DormDto> { Items = new List<DormDto>() });

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
        var dto = new DormDto { Name = "Test Dorm" };
        var existingDorms = Enumerable.Range(1, BusinessRulesConstants.Dorm.MaxListingsPerHour)
            .Select(i => new DormDto { Id = i }).ToList();

        A.CallTo(() => _userManager.FindByIdAsync(TestUserId))
            .Returns(new User { Id = TestUserId, FirstName = TestUserFirstName, LastName = TestUserLastName });

        // Update this to return a PaginatedDto
        A.CallTo(() => _dormService.GetAllAsync(A<DormFilter>._))
            .Returns(new PaginatedDto<DormDto> { Items = existingDorms });

        // Act & Assert
        var exception = await Assert.ThrowsAsync<AppException>(() => _controller.CreateAsync(dto));
        Assert.Contains("exceeded the maximum number", exception.Message);
        _output.WriteLine($"Creation blocked as expected: {exception.Message}");
    }

    [Fact]
    public async Task CreateAsync_DuplicateAddress_ThrowsException()
    {
        // Arrange
        var dto = new DormDto { Address = "Existing Address" };
        var existingDorms = new List<DormDto> { new() { Address = "Existing Address" } };

        A.CallTo(() => _userManager.FindByIdAsync(TestUserId))
            .Returns(new User { Id = TestUserId, FirstName = TestUserFirstName, LastName = TestUserLastName });

        // Update this to return a PaginatedDto
        A.CallTo(() => _dormService.GetAllAsync(A<DormFilter>._))
            .Returns(new PaginatedDto<DormDto> { Items = existingDorms });

        // Act & Assert
        var exception = await Assert.ThrowsAsync<AppException>(() => _controller.CreateAsync(dto));
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
            .Select(i => new DormDto { Id = i })
            .ToList();

        // Update this to return a PaginatedDto
        A.CallTo(() => _dormService.GetAllAsync(filter))
            .Returns(new PaginatedDto<DormDto> { Items = dorms, TotalItems = dorms.Count });

        // Act
        var result = await _controller.GetAllAsync(filter);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        
        // Update this to check the Items property of PaginatedDto
        var returnValue = Assert.IsType<PaginatedDto<DormDto>>(okResult.Value);
        Assert.Equal(dorms.Count, returnValue.Items.Count());
        _output.WriteLine($"Retrieved {returnValue.Items.Count()} dorms");
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
        var ownerDorms = new List<DormDto>
        {
            new() { Id = 1, Owner = owner },
            new() { Id = 2, Owner = owner }
        };

        // Update this to return a PaginatedDto
        A.CallTo(() => _dormService.GetAllAsync(filter))
            .Returns(new PaginatedDto<DormDto> { Items = ownerDorms });

        // Act
        var result = await _controller.GetAllAsync(filter);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        
        // Update this to check the Items property of PaginatedDto
        var paginated = Assert.IsType<PaginatedDto<DormDto>>(okResult.Value);
        var dorms = paginated.Items.ToList();
        Assert.All(dorms, dorm => Assert.Equal(owner.Id, dorm.Owner.Id));
        _output.WriteLine($"Retrieved {dorms.Count} dorms for owner {owner.Id}");
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

        var dorms = new List<DormDto>
        {
            CreateValidDormDto(1),
            CreateValidDormDto(2)
        };
        
        // Update this to return a PaginatedDto
        A.CallTo(() => _dormService.GetAllAsync(filter))
            .Returns(new PaginatedDto<DormDto> { Items = dorms });

        // Act
        var result = await _controller.GetAllAsync(filter);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        
        // Update this to check the Items property of PaginatedDto
        var paginated = Assert.IsType<PaginatedDto<DormDto>>(okResult.Value);
        var returnedDorms = paginated.Items.ToList();
        Assert.All(returnedDorms, dorm =>
            Assert.True(dorm.Rooms.All(r =>
                r.PricePerMonth >= filter.MinPrice && r.PricePerMonth <= filter.MaxPrice)));
        _output.WriteLine($"Retrieved {returnedDorms.Count} dorms within price range");
    }
}