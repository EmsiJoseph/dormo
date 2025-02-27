// namespace Dormo.Tests;
//
// public class BookingControllerTests : IClassFixture<DormoFixture>
// {
//     private readonly BookingController _controller;
//
//     public BookingControllerTests(DormoFixture fixture)
//     {
//         _controller = new BookingController(fixture.BookingService);
//     }
//
//     public static IEnumerable<object[]> BookingTestData =>
//         new List<object[]>
//         {
//             new object[] { new CreateBookingRequest {
//                 DormId = Guid.NewGuid(),
//                 CheckIn = DateTime.Now.AddDays(1),
//                 CheckOut = DateTime.Now.AddDays(30),
//                 GuestCount = 1,
//                 IsGroupBooking = false
//             }, true },
//             new object[] { new CreateBookingRequest {
//                 DormId = Guid.NewGuid(),
//                 CheckIn = DateTime.Now.AddDays(-1), // Past date
//                 CheckOut = DateTime.Now.AddDays(30),
//                 GuestCount = 1
//             }, false }
//         };
//
//     [Theory]
//     [MemberData(nameof(BookingTestData))]
//     public async Task CreateBooking_VariousCases_ReturnsExpectedResult(CreateBookingRequest request, bool shouldSucceed)
//     {
//         // Test implementation
//     }
//
//     [Fact]
//     public async Task CreateGroupBooking_ValidRequest_ReturnsSuccess()
//     {
//         // Test implementation
//     }
// }