namespace Dormo.Server.Constants;

public class AppSettings
{
    public string? AppName { get; set; }
    public string? AllowedOrigins { get; set; }
    public string? ApiServer { get; set; }
    public ConnectionStrings? ConnectionStrings { get; set; }
    public ApplicationApiVersion? ApplicationApiVersion { get; set; }


}

public class ConnectionStrings
{
    public string? LocalDefaultConnection { get; set; }
    public string? ProdDefaultConnection { get; set; }
}

public class ApplicationApiVersion
{
    public int MajorVersion { get; set; }
    public int MinorVersion { get; set; }
    public string? HeaderName { get; set; }
    public string? QueryStringParam { get; set; }
}