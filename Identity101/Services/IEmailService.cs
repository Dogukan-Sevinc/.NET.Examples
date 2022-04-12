using Identity101.Models;

namespace Identity101.Services.EmailService;

public interface IEmailService
{
    Task SendMailAsync(MailModel model);

}
