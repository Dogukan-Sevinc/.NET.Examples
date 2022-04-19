using AdminTemplate.Models.Email;

namespace AdminTemplate.Services.EmailService
{
    public interface IEmailService
    {
        Task SendMailAsync(MailModel model);

    }
}


