namespace Dormo.Server.Data.Requests;

public class EmailRequest
{
    /// <summary>
    /// Tuple (Email, Name)
    /// </summary>
    public Tuple<string, string> From { get; set; }

    /// <summary>
    /// Dictionary (Email, Name)
    /// </summary>
    public Dictionary<string, string> To { get; set; }

    public string Subject { get; set; }
    public string PlainMessage { get; set; }
    public string HtmlMessage { get; set; }
}