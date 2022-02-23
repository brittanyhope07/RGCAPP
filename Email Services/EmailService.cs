using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace RGCAPP.Email_Services
{
    public interface EmailService
    {
        System.Threading.Tasks.Task SendEmailAsync(string toEmail, string subject, string content);
    }

    public class SendGridMailService : EmailService
    {
        private IConfiguration _configuration;

        public SendGridMailService(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string toEmail, string subject, string content)
        {
            var apiKey = _configuration["SendGridAPIKey"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("brittanyhope07@gmail.com", "Brittany");
            var to = new EmailAddress("toEmail");
            var msg = MailHelper.CreateSingleEmail(from, to, subject, content, content);
            var response = await client.SendEmailAsync(msg);
        }
    }

}
