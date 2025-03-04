using System.Text.Json;
using System.Threading.RateLimiting;
using Asp.Versioning;
using Dormo.Server.Constants;
using Dormo.Server.Controllers;
using Dormo.Server.Controllers.Interfaces;
using Dormo.Server.Data;
using Dormo.Server.Data.Models;
using Dormo.Server.Middleware;
using Dormo.Server.Services;
using Dormo.Server.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Core Services
builder.Services.AddOutputCache();
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        options.JsonSerializerOptions.WriteIndented = true;
    });

// Register services for dependency injection
// builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IDormService, DormService>();
// builder.Services.AddScoped<IBookingService, BookingService>();
// builder.Services.AddScoped<IVisitService, VisitService>();
// builder.Services.AddScoped<IDormmateService, DormmateService>();
// builder.Services.AddScoped<IDormMatchService, DormMatchService>();
// builder.Services.AddScoped<IVerificationService, VerificationService>();
// builder.Services.AddScoped<ICommunityService, CommunityService>();
// builder.Services.AddScoped<IReviewService, ReviewService>();
// builder.Services.AddScoped<INotificationService, NotificationService>();
// builder.Services.AddScoped<IPaymentService, PaymentService>();
// builder.Services.AddScoped<IReportService, ReportService>();
// builder.Services.AddScoped<ISearchService, SearchService>();
// builder.Services.AddScoped<IMessageService, MessageService>();

// Register controllers
builder.Services.AddScoped<IDormController, DormController>();
// builder.Services.AddScoped<IUserController, UserController>();

// Add service in ConfigureServices
builder.Services.AddGlobalExceptionHandler();

// Rate Limiting
builder.Services.AddRateLimiter(options =>
{
    options.AddSlidingWindowLimiter("PerUserPolicy", opt =>
    {
        opt.Window = TimeSpan.FromMinutes(1);
        opt.PermitLimit = 100;
        opt.QueueLimit = 10;
        opt.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
    });
});


// Database
string? connection = builder.Environment.IsDevelopment()
    ? builder.Configuration.GetConnectionString("LocalDefaultConnection")
    : builder.Configuration.GetConnectionString("ProdDefaultConnection");
if (string.IsNullOrEmpty(connection))
    throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));

// Add Identity
builder.Services.AddIdentity<User, IdentityRole>(options =>
    {
        options.Password.RequireDigit = true;
        options.Password.RequiredLength = 8;
        options.Password.RequireLowercase = true;
        options.Password.RequireUppercase = true;
        options.Password.RequireNonAlphanumeric = true;
    })
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// Configure cookie authentication
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/api/login";
    options.LogoutPath = "/api/logout";
    options.Cookie.HttpOnly = true;
    options.Cookie.SameSite = SameSiteMode.Strict;
    options.ExpireTimeSpan = TimeSpan.FromHours(1);
});

builder.Services.AddAuthorization();

// API Versioning
builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(ApiVersionConstants.MajorVersion, ApiVersionConstants.MinorVersion);
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true;
    options.ApiVersionReader = ApiVersionReader.Combine(
        new UrlSegmentApiVersionReader(),
        new HeaderApiVersionReader(ApiVersionConstants.HeaderName),
        new QueryStringApiVersionReader(ApiVersionConstants.QueryStringParam));
});


// OpenAPI
builder.Services.AddOpenApi();

var app = builder.Build();

app.UseDefaultFiles();
app.MapStaticAssets();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference();
    app.MapOpenApi();
    app.UseExceptionHandler("/Error");
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

if (!string.Equals(Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER"), "true", StringComparison.OrdinalIgnoreCase))
{
    app.UseHttpsRedirection();
}

app.UseAuthentication();
app.UseAuthorization();

app.UseOutputCache();
app.UseRateLimiter();
app.UseGlobalExceptionHandler();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();