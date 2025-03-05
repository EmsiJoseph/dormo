using Dormo.Server.Data.Requests;

namespace Dormo.Server.Services.Interfaces;

public interface IEmailService
{
    Task<bool> SendEmailAsync(EmailRequest email);
}