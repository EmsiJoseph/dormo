using Dormo.Server.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Dormo.Server.Extensions;

public static class DbContextExtensions
{
    public static async Task SaveChangesWithValidationAsync(this DbContext context)
    {
        try
        {
            await context.SaveChangesAsync();
        }
        catch (DbUpdateException ex)
        {
            throw ex.ToAppException();
        }
        catch (Exception ex)
        {
            throw AppException.DatabaseError(ex.Message);
        }
    }

    public static async Task<T> ExecuteWithValidationAsync<T>(this DbContext context, Func<Task<T>> action)
    {
        try
        {
            return await action();
        }
        catch (DbUpdateException ex)
        {
            throw ex.ToAppException();
        }
        catch (Exception ex)
        {
            throw AppException.DatabaseError(ex.Message);
        }
    }

    public static async Task ExecuteWithValidationAsync(this DbContext context, Func<Task> action)
    {
        try
        {
            await action();
        }
        catch (DbUpdateException ex)
        {
            throw ex.ToAppException();
        }
        catch (Exception ex)
        {
            throw AppException.DatabaseError(ex.Message);
        }
    }
}
