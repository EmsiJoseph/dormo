using Microsoft.AspNetCore.Authentication.Cookies;
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

// Setup Configuration
var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", false)
    .AddJsonFile($"appsettings.{environmentName}.json", true)
    .AddUserSecrets<Program>() // Add this line to load user secrets
    .AddEnvironmentVariables()
    .Build();

var appSettingsSection = configuration.GetSection("AppSettings");

builder.Services.Configure<AppSettings>(appSettingsSection);

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
// builder.Services.AddScoped<IEmailService, EmailService>();

// Register controllers
builder.Services.AddScoped<IDormController, DormController>();
// builder.Services.AddScoped<IUserController, UserController>();

// Add service in ConfigureServices
builder.Services.AddGlobalExceptionHandler();

// Add session services
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
    options.Cookie.SameSite = SameSiteMode.Lax;
});

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
var appSettings = configuration.GetSection(nameof(AppSettings)).Get<AppSettings>();
string? connection = builder.Environment.IsDevelopment()
    ? appSettings?.ConnectionStrings?.LocalDefaultConnection
    : appSettings?.ConnectionStrings?.ProdDefaultConnection;

if (string.IsNullOrEmpty(connection))
    throw new InvalidOperationException("Connection string not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));

// Add Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
    {
        options.Password.RequireDigit = true;
        options.Password.RequiredLength = 8;
        options.Password.RequireLowercase = true;
        options.Password.RequireUppercase = true;
        options.Password.RequireNonAlphanumeric = true;
    })
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// Add Authentication
builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    })
    .AddCookie(options =>
    {
        // TODO: Configure login/logout path
    })
    .AddGoogle(options =>
    {
        var appSecrets = configuration.GetSection(nameof(AppSecrets)).Get<AppSecrets>();
        options.ClientId = appSecrets?.Authentication?.Google?.ClientId ??
                       throw new InvalidOperationException("Google Client Id not found.");
        options.ClientSecret = appSecrets?.Authentication?.Google?.ClientSecret ??
                           throw new InvalidOperationException("Google Client Secret not found.");
        options.SaveTokens = true;
        options.Scope.Add("openid");
        options.Scope.Add("profile");
        options.Scope.Add("email");
        options.Scope.Add("https://www.googleapis.com/auth/userinfo.profile");
        options.Scope.Add("https://www.googleapis.com/auth/user.birthday.read");
    });

builder.Services.AddAuthorization();

var apiVersion = appSettings?.ApplicationApiVersion ??
                 throw new InvalidOperationException("ApiVersion not found.");
// API Versioning
builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(apiVersion.MajorVersion, apiVersion.MinorVersion);
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true;
    options.ApiVersionReader = ApiVersionReader.Combine(
        new UrlSegmentApiVersionReader(),
        new HeaderApiVersionReader(apiVersion.HeaderName ?? "X-Api-Version"),
        new QueryStringApiVersionReader(apiVersion.QueryStringParam ?? "api-version"));
});


// OpenAPI
builder.Services.AddOpenApi();

var app = builder.Build();

app.UseDefaultFiles();
app.MapStaticAssets(); // Uncomment this line

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

if (!string.Equals(Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER"), "true",
        StringComparison.OrdinalIgnoreCase))
{
    app.UseHttpsRedirection();
}

app.Use((context, next) =>
{
    context.Request.Host = new HostString(configuration.GetSection(nameof(AppSettings)).Get<AppSettings>()?.ApiServer);
    context.Request.Scheme = "https";
    return next();
});

app.UseSession();
app.UseAuthentication();
app.UseAuthorization();

app.UseOutputCache();
app.UseRateLimiter();
app.UseGlobalExceptionHandler();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();