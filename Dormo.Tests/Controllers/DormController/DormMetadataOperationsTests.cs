using Dormo.Tests.Controllers.Base;
using Dormo.Tests.Fixtures;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using Xunit.Abstractions;

namespace Dormo.Tests.Controllers.DormController;

public class DormMetadataOperationsTests : DormControllerTestBase
{
    public DormMetadataOperationsTests(DormoFixture fixture, ITestOutputHelper output)
        : base(fixture, output)
    {
    }

    [Theory]
    [InlineData("amenity")]
    [InlineData("tag")]
    public async Task UpdateMetaDataAsync_ValidType_ReturnsOkResult(string metaDataType)
    {
        // Arrange
        var dormId = 1;
        var metaDataIds = new List<int> { 1, 2, 3 };

        A.CallTo(() => _dormService.UpdateAmenityAsync(dormId, metaDataIds))
            .Returns(true);
        A.CallTo(() => _dormService.UpdateTagAsync(dormId, metaDataIds))
            .Returns(true);

        // Act
        var result = await _controller.UpdateMetaDataAsync(dormId, metaDataType, metaDataIds);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        Assert.Equal("Updated meta data successfully", okResult.Value);
        _output.WriteLine($"{metaDataType} metadata updated successfully");
    }

    [Fact]
    public async Task UpdateMetaDataAsync_InvalidType_ReturnsBadRequest()
    {
        // Arrange
        var dormId = 1;
        var metaDataIds = new List<int> { 1, 2, 3 };

        // Act
        var result = await _controller.UpdateMetaDataAsync(dormId, "invalid", metaDataIds);

        // Assert
        var badRequest = Assert.IsType<BadRequestObjectResult>(result);
        Assert.Equal("Invalid meta data type", badRequest.Value);
        _output.WriteLine("Invalid metadata type rejected as expected");
    }
}