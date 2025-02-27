using Dormo.Tests.Controllers.Base;
using Dormo.Server.Constants;
using Dormo.Server.Controllers.Interfaces;
using Dormo.Server.Data.DTOs;
using Dormo.Server.Data.Requests;
using Dormo.Server.Exceptions;
using Dormo.Server.Services.Interfaces;
using Dormo.Tests.Fixtures;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using Xunit.Abstractions;

namespace Dormo.Tests.Controllers.DormController;

public class DormRoomOperationsTests : DormControllerTestBase
{
    public DormRoomOperationsTests(DormoFixture fixture, ITestOutputHelper output
    )
        : base(fixture, output)
    {
    }

    [Fact]
    public async Task UpdateRoomsAsync_ValidRooms_ReturnsOkResult()
    {
        // Arrange
        var dormId = 1;
        var rooms = GenerateValidRoomRequests();

        A.CallTo(() => _dormService.UpdateRoomsAsync(dormId, rooms))
            .Returns(true);

        // Act
        var result = await _controller.UpdateRoomsAsync(dormId, rooms);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        Assert.Equal("Rooms updated successfully", okResult.Value);
        _output.WriteLine("Rooms updated successfully");
    }

    [Fact]
    public async Task UpdateRoomsAsync_InvalidPriceRange_ThrowsException()
    {
        // Arrange
        var dormId = 1;
        var rooms = new List<RoomRequest>
        {
            new()
            {
                RoomNumber = "101",
                Description = "Test Room",
                PricePerMonth = BusinessRulesConstants.Room.MinPrice - 1, // Invalid price
                Capacity = 1
            }
        };

        // Act & Assert
        var exception = await Assert.ThrowsAsync<AppException>(
            () => _controller.UpdateRoomsAsync(dormId, rooms));
        Assert.Contains("Room price must be between", exception.Message);
        _output.WriteLine($"Room update blocked as expected: {exception.Message}");
    }


    [Fact]
    public async Task UpdateRoomsAsync_InvalidCapacity_ThrowsException()
    {
        // Arrange
        var dormId = 1;
        var rooms = new List<RoomRequest>
        {
            new()
            {
                RoomNumber = "101",
                Description = "Test Room",
                PricePerMonth = 5000,
                Capacity = BusinessRulesConstants.Room.MaxCapacity + 1 // Invalid capacity
            }
        };

        // Act & Assert
        var exception = await Assert.ThrowsAsync<AppException>(
            () => _controller.UpdateRoomsAsync(dormId, rooms));
        Assert.Contains("Room capacity must be between", exception.Message);
        _output.WriteLine($"Room update blocked as expected: {exception.Message}");
    }

    [Fact]
    public async Task UpdateRoomsAsync_DuplicateRoomNumbers_ThrowsException()
    {
        // Arrange
        var dormId = 1;
        var rooms = new List<RoomRequest>
        {
            new() { RoomNumber = "101", Description = "Room 1", PricePerMonth = 5000, Capacity = 1 },
            new() { RoomNumber = "101", Description = "Room 2", PricePerMonth = 6000, Capacity = 2 }
        };

        // Act & Assert
        var exception = await Assert.ThrowsAsync<AppException>(
            () => _controller.UpdateRoomsAsync(dormId, rooms));
        Assert.Contains("Duplicate room numbers", exception.Message);
        _output.WriteLine($"Room update blocked as expected: {exception.Message}");
    }

    [Theory]
    [InlineData("Room 123!")]
    [InlineData("12345678901")]
    public async Task UpdateRoomsAsync_InvalidRoomNumber_ThrowsException(string roomNumber)
    {
        // Arrange
        var dormId = 1;
        var rooms = new List<RoomRequest>
        {
            new()
            {
                RoomNumber = roomNumber,
                Description = "Test Room",
                PricePerMonth = 5000,
                Capacity = 1
            }
        };

        // Act & Assert
        var exception = await Assert.ThrowsAsync<AppException>(
            () => _controller.UpdateRoomsAsync(dormId, rooms));
        if (roomNumber.Length > BusinessRulesConstants.Room.NumberMaxLength)
        {
            Assert.Contains(
                $"Room number must not exceed {BusinessRulesConstants.Room.NumberMaxLength} characters",
                exception.Message);
        }
        else
        {
            Assert.Contains(
                "Room number must be alphanumeric and maximum of 10 characters",
                exception.Message);
        }

        _output.WriteLine($"Room update blocked as expected: {exception.Message}");
    }

    [Fact]
    public async Task UpdateRoomsAsync_WithEmptyList_ThrowsException()
    {
        // Arrange
        var dormId = 1;
        var rooms = new List<RoomRequest>();

        // Act & Assert
        var exception = await Assert.ThrowsAsync<AppException>(
            () => _controller.UpdateRoomsAsync(dormId, rooms));
        Assert.Contains($"Number of rooms must be between {BusinessRulesConstants.Dorm.MinRooms}", exception.Message);
        _output.WriteLine("Empty room list rejected as expected");
    }
}