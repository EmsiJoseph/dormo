namespace Dormo.Server.Utils;

public static class DateTimeUtils
{
    /// <summary>
    /// Returns a human-friendly string representing time elapsed since the specified date
    /// </summary>
    /// <param name="dateTime">The reference date to compare against current time</param>
    /// <returns>Formatted elapsed time (e.g., "2y", "3mo", "5d", "2h", "30m", "15s")</returns>
    public static string GetTimeAgo(DateTime dateTime)
    {
        var timeSpan = DateTime.UtcNow - dateTime;
        
        return timeSpan.TotalDays switch
        {
            > 365 => $"{timeSpan.TotalDays / 365:F0}y",    // Years
            > 30 => $"{timeSpan.TotalDays / 30:F0}mo",     // Months
            > 1 => $"{timeSpan.TotalDays:F0}d",            // Days
            _ => timeSpan.TotalHours switch
            {
                > 1 => $"{timeSpan.TotalHours:F0}h",       // Hours
                _ => timeSpan.TotalMinutes switch 
                {
                    > 1 => $"{timeSpan.TotalMinutes:F0}m", // Minutes
                    _ => $"{timeSpan.TotalSeconds:F0}s"    // Seconds
                }
            }
        };
    }
}
