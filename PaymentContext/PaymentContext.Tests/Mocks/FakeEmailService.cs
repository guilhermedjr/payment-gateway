using PaymentContext.Domain.Services;
using System.Threading.Tasks;
namespace PaymentContext.Tests.Mocks;

public class FakeEmailService : IEmailService
{
    public Task SendEmailAsync(string to, string subject, string body, bool isHTML = true)
    {
        return Task.CompletedTask;
    }
}

