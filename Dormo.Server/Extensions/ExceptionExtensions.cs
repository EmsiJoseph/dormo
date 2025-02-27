using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using Dormo.Server.Exceptions;

namespace Dormo.Server.Extensions;

public static class ExceptionExtensions
{
    public static AppException ToAppException(this DbUpdateException ex)
    {
        if (ex.InnerException is SqlException sqlEx)
        {
            // Handle NULL constraint violation
            if (sqlEx.Number == 515)
            {
                var columnName = ParseColumnName(sqlEx.Message);
                return AppException.ValidationError(
                    $"The field '{FormatColumnName(columnName)}' is required.",
                    columnName);
            }

            // Handle unique constraint violation
            if (sqlEx.Number == 2601 || sqlEx.Number == 2627)
            {
                var columnName = ParseColumnName(sqlEx.Message);
                return AppException.ValidationError(
                    $"A record with this {FormatColumnName(columnName)} already exists.",
                    columnName);
            }
        }

        return AppException.DatabaseError("An error occurred while saving changes.");
    }

    private static string ParseColumnName(string errorMessage)
    {
        var match = Regex.Match(errorMessage, @"column '([^']*)'");
        return match.Success ? match.Groups[1].Value : "Unknown";
    }

    private static string FormatColumnName(string columnName)
    {
        return Regex.Replace(columnName, "([a-z])([A-Z])", "$1 $2");
    }
}
