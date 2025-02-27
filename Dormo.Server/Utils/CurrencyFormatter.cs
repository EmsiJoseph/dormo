using System.Globalization;

namespace Dormo.Server.Utils;

public static class CurrencyFormatter
{
    private static readonly CultureInfo PhilippineCulture = new("en-PH");

    public static string FormatPHP(decimal amount)
    {
        return string.Format(PhilippineCulture, "₱{0:N0}", amount);
    }

    public static decimal ParsePHP(string value)
    {
        var normalized = new string(value.Where(c => char.IsDigit(c) || c == '.').ToArray());
        return decimal.TryParse(normalized, out var result) ? result : 0;
    }
}
