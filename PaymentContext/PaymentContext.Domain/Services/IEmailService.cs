namespace PaymentContext.Domain.Services;

public interface IEmailService
{
    Task SendEmailAsync(string to, string subject, string body, bool isHTML = true);
}

