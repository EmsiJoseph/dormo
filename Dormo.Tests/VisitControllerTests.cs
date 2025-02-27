// namespace Dormo.Tests;
//
// public class VisitControllerTests : IClassFixture<DormoFixture>
// {
//     private readonly VisitController _controller;
//
//     public VisitControllerTests(DormoFixture fixture)
//     {
//         _controller = new VisitController(fixture.VisitService);
//     }
//
//     public static IEnumerable<object[]> VisitTestData =>
//         new List<object[]>
//         {
//             new object[] { new ScheduleVisitRequest {
//                 DormId = Guid.NewGuid(),
//                 VisitDate = DateTime.Now.AddDays(1),
//                 VisitorCount = 1,
//                 IsGroupVisit = false
//             }, true },
//             new object[] { new ScheduleVisitRequest {
//                 DormId = Guid.NewGuid(),
//                 VisitDate = DateTime.Now.AddDays(-1),
//                 VisitorCount = 1
//             }, false }
//         };
//
//     [Theory]
//     [MemberData(nameof(VisitTestData))]
//     public async Task ScheduleVisit_VariousCases_ReturnsExpectedResult(ScheduleVisitRequest request, bool shouldSucceed)
//     {
//         // Test implementation
//     }
//
//     // Cancel a visit
//     
//     // View visits by [query]/[filter]/all
//     
//     // View a visit
//     
//     // Visit as a group
// }