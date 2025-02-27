namespace Dormo.Server.Exceptions;

public class AppException : Exception
{
    public string? PropertyName { get; }
    public int StatusCode { get; }

    public AppException(string message, string? propertyName = null, int statusCode = 400) 
        : base(message)
    {
        PropertyName = propertyName;
        StatusCode = statusCode;
    }

    public static AppException NotFound(string entityName, object id)
        => new($"{entityName} with ID {id} was not found.", statusCode: 404);

    public static AppException ValidationError(string message, string? propertyName = null)
        => new(message, propertyName, 400);

    public static AppException DatabaseError(string message, string? propertyName = null)
        => new($"Database error: {message}", propertyName, 400);

    public static AppException Unauthorized(string message = "Unauthorized access")
        => new(message, statusCode: 401);

    public static AppException Forbidden(string message = "Access forbidden")
        => new(message, statusCode: 403);
}
