using Dormo.Server.Data;
using Dormo.Server.Data.Models;
using Dormo.Server.Services;
using Dormo.Server.Services.Interfaces;
using FakeItEasy;
using Microsoft.AspNetCore.Identity;

namespace Dormo.Tests.Fixtures;

public class DormoFixture : IDisposable
{
    public UserManager<User> UserManager { get; }
    public SignInManager<User> SignInManager { get; }
    public IDormService DormService { get; }
    public ApplicationDbContext DbContext { get; }

    // public IUserService UserService { get; }
    // public IBookingService BookingService { get; }
    // public IVisitService VisitService { get; }
    // public IDormmateService DormmateService { get; }
    // public IDormMatchService DormMatchService { get; }
    // public IVerificationService VerificationService { get; }
    // public ICommunityService CommunityService { get; }
    // public IReviewService ReviewService { get; }
    // public INotificationService NotificationService { get; }
    // public IPaymentService PaymentService { get; }
    // public IReportService ReportService { get; }
    // public ISearchService SearchService { get; }
    // public IMessageService MessageService { get; }

    public DormoFixture()
    {
        UserManager = A.Fake<UserManager<User>>();
        SignInManager = A.Fake<SignInManager<User>>();
        DormService = A.Fake<IDormService>();
        // UserService = A.Fake<IUserService>();
        // BookingService = A.Fake<IBookingService>();
        // VisitService = A.Fake<IVisitService>();
        // DormmateService = A.Fake<IDormmateService>();
        // DormMatchService = A.Fake<IDormMatchService>();
        // VerificationService = A.Fake<IVerificationService>();
        // CommunityService = A.Fake<ICommunityService>();
        // ReviewService = A.Fake<IReviewService>();
        // NotificationService = A.Fake<INotificationService>();
        // PaymentService = A.Fake<IPaymentService>();
        // ReportService = A.Fake<IReportService>();
        // SearchService = A.Fake<ISearchService>();
        // MessageService = A.Fake<IMessageService>();
    }

    public void Dispose()
    {
    }
}