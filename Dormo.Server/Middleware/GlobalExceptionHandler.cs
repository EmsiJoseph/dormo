using System.Net;
using Dormo.Server.Exceptions;

namespace Dormo.Server.Middleware;

public class GlobalExceptionHandler : IMiddleware
{
    private readonly ILogger<GlobalExceptionHandler> _logger;

    public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger)
    {
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, "An error occurred: {Message}", exception.Message);
            await HandleExceptionAsync(context, exception);
        }
    }

    private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";

        var response = exception switch
        {
            AppException ex => new
            {
                StatusCode = ex.StatusCode,
                Message = ex.Message,
                Property = ex.PropertyName
            },
            UnauthorizedAccessException _ => new
            {
                StatusCode = (int)HttpStatusCode.Unauthorized,
                Message = "Unauthorized access",
                Property = (string?)null
            },
            _ => new
            {
                StatusCode = (int)HttpStatusCode.InternalServerError,
                Message = "An internal server error occurred",
                Property = (string?)null
            }
        };

        context.Response.StatusCode = response.StatusCode;
        await context.Response.WriteAsJsonAsync(response);
    }
}

// Extension method for registering the middleware
public static class GlobalExceptionHandlerExtensions
{
    public static IServiceCollection AddGlobalExceptionHandler(this IServiceCollection services)
    {
        return services.AddTransient<GlobalExceptionHandler>();
    }

    public static IApplicationBuilder UseGlobalExceptionHandler(this IApplicationBuilder app)
    {
        return app.UseMiddleware<GlobalExceptionHandler>();
    }
}