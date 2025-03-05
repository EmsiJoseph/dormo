namespace Dormo.Server.Constants;

public class AppSecrets
{

    public SendGridSecrets? SendGridSecrets { get; set; }
    public Authentication? Authentication { get; set; }


}

public class Authentication
{
    public Google? Google { get; set; }

}

public class SendGridSecrets
{
    public string? ApiKey { get; set; }
}

public class Google
{
    public string? ClientId { get; set; }
    public string? ClientSecret { get; set; }
}