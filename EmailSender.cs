using Microsoft.AspNetCore.Identity.UI.Services;

namespace MfaDiogenes;

public class EmailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string message)
    {
        return Task.CompletedTask;
    }
}
