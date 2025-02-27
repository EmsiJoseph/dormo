using Dormo.Tests.Controllers.Base;
using Dormo.Server.Constants;
using Dormo.Server.Data.DTOs;
using Dormo.Server.Data.Requests;
using Dormo.Server.Exceptions;
using Dormo.Server.Services;
using Dormo.Tests.Fixtures;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using Xunit.Abstractions;

namespace Dormo.Tests.Controllers.DormController;

public class DormImageOperationsTests : DormControllerTestBase
{
    public DormImageOperationsTests(DormoFixture fixture, ITestOutputHelper output)
        : base(fixture, output)
    {
    }

    [Theory]
    [InlineData(3)] // Minimum required
    [InlineData(5)] // Middle range
    [InlineData(10)] // Maximum allowed
    public async Task UpdateImagesAsync_WithValidImages_ReturnsSuccess(int imageCount)
    {
        // Arrange
        var dormId = 1;
        var images = GenerateValidImageRequests(imageCount);

        A.CallTo(() => _dormService.UpdateImagesAsync(dormId, A<List<ImageRequest>>._))
            .Returns(true);

        // Act
        var result = await _controller.UpdateImagesAsync(dormId, images);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        Assert.Equal("Images updated successfully", okResult.Value);
        _output.WriteLine($"Successfully updated {imageCount} images");
    }

    [Theory]
    [InlineData(2)] // Below minimum
    [InlineData(11)] // Above maximum
    public async Task UpdateImagesAsync_WithInvalidCount_ThrowsException(int imageCount)
    {
        // Arrange
        var dormId = 1;
        var images = GenerateValidImageRequests(imageCount);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<AppException>(
            () => _controller.UpdateImagesAsync(dormId, images));

        Assert.Contains($"between {BusinessRulesConstants.Dorm.MinImages} and {BusinessRulesConstants.Dorm.MaxImages}",
            exception.Message);
        _output.WriteLine($"Correctly rejected {imageCount} images");
    }

    [Fact]
    public async Task UpdateImagesAsync_WithDuplicateOrders_ThrowsException()
    {
        // Arrange
        var dormId = 1;
        var images = new List<ImageRequest>
        {
            new() { Url = "https://example.com/1.jpg", Order = 1 },
            new() { Url = "https://example.com/2.jpg", Order = 1 }, // Duplicate order
            new() { Url = "https://example.com/3.jpg", Order = 2 }
        };

        // Act & Assert
        var exception = await Assert.ThrowsAsync<AppException>(
            () => _controller.UpdateImagesAsync(dormId, images));

        Assert.Contains("Duplicate image orders", exception.Message);
        _output.WriteLine("Correctly rejected duplicate orders");
    }

    [Fact]
    public async Task UpdateImagesAsync_WithInvalidFileType_ThrowsException()
    {
        // Arrange
        var dormId = 1;
        var images = new List<ImageRequest>
        {
            new() { Url = "https://example.com/image1.jpg", Order = 1, IsPrimary = true },
            new() { Url = "https://example.com/image2.pdf", Order = 2 }, // Invalid type
            new() { Url = "https://example.com/image3.jpg", Order = 3 }
        };

        // Act & Assert
        var exception = await Assert.ThrowsAsync<AppException>(
            () => _controller.UpdateImagesAsync(dormId, images));

        Assert.Contains("Invalid file type", exception.Message);
        _output.WriteLine("Correctly rejected invalid file type");
    }

    [Fact]
    public async Task UpdateImagesAsync_MultiplePrimaryImages_ThrowsException()
    {
        // Arrange
        var dormId = 1;
        var images = new List<ImageRequest>
        {
            new() { Url = "https://example.com/1.jpg", Order = 1, IsPrimary = true },
            new() { Url = "https://example.com/2.jpg", Order = 2, IsPrimary = true },
            new() { Url = "https://example.com/2.jpg", Order = 3, IsPrimary = true }
        };

        // Act & Assert
        var exception = await Assert.ThrowsAsync<AppException>(
            () => _controller.UpdateImagesAsync(dormId, images));
        Assert.Contains("Only one image can be primary", exception.Message);
        _output.WriteLine($"Image update blocked as expected: {exception.Message}");
    }

    [Fact]
    public async Task UpdateImagesAsync_WithoutPrimaryImage_ThrowsException()
    {
        // Arrange
        var dormId = 1;
        var images = new List<ImageRequest>
        {
            new() { Url = "https://example.com/1.jpg", Order = 1, IsPrimary = false },
            new() { Url = "https://example.com/2.jpg", Order = 2, IsPrimary = false },
            new() { Url = "https://example.com/2.jpg", Order = 3, IsPrimary = false }
        };

        // Act & Assert
        var exception = await Assert.ThrowsAsync<AppException>(
            () => _controller.UpdateImagesAsync(dormId, images));
        Assert.Contains("At least one image must be primary", exception.Message);
        _output.WriteLine("Images without primary image rejected as expected");
    }
}