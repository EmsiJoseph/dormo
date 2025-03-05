using Dormo.Server.Constants;
using SendGrid;
using SendGrid.Helpers.Mail;
using Dormo.Server.Data.Requests;
using Dormo.Server.Services.Interfaces;

namespace Dormo.Server.Services;

public class EmailService : IEmailService
{
    private readonly ILogger<EmailService> _logger;
    private readonly IConfiguration _configuration;

    public EmailService(ILogger<EmailService> logger,
        IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public async Task<bool> SendEmailAsync(EmailRequest email)
    {
        var appSecrets = _configuration.GetSection(nameof(AppSecrets)).Get<AppSecrets>();

        var sendGridApiKey = appSecrets?.SendGridSecrets?.ApiKey ??
                             throw new ArgumentNullException("SendGrid API Key is missing");

        var client = new SendGridClient(sendGridApiKey);

        var msg = MailHelper.CreateSingleEmailToMultipleRecipients(
            new EmailAddress(email.From.Item1, email.From.Item2),
            email.To.Select(x => new EmailAddress(x.Key, x.Value)).ToList(),
            email.Subject,
            email.PlainMessage,
            email.HtmlMessage);

        var response = await client.SendEmailAsync(msg);

        _logger.LogInformation($"Received {response.StatusCode} when sending an email to " +
                               $"{string.Join(", ", email.To.Select(x => x.Key).ToList())} " +
                               $"from {email.From.Item1} " +
                               $"with message :{email.PlainMessage}  " +
                               $"and subject: {email.Subject}");

        return response.StatusCode == System.Net.HttpStatusCode.OK ||
               response.StatusCode == System.Net.HttpStatusCode.Accepted;
    }
}