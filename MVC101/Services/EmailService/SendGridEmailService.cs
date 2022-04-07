
using MVC101.Models;
using MVC101.Services.EmailService;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace MVC101.Services.EmailService
{
    public class SendGridEmailService : SendGridEmailServiceBase, IEmailService
    {
        private readonly ISendGridClient _sendGridClient;

        public SendGridEmailService(ISendGridClient sendGridClient)
        {
            _sendGridClient = sendGridClient;
        }
    }
}