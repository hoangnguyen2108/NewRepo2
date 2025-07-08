using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace LeaveManagementSystem.Services
{
    public class EmailSender(IConfiguration _configuration) : IEmailSender
    {
        
        public async Task SendEmailAsync(string fromAddressemail, string subject, string htmlMessage)
        {
            var fromAddress = _configuration["EmailSettings:DefaultEmailAddress"];
            var fromServer = _configuration["EmailSettings:Server"];
            var fromPort = Convert.ToInt32(_configuration["EmailSettings:Port"]);

            var message = new MailMessage
            {
                From = new MailAddress(fromAddress),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true

            };
            message.To.Add(new MailAddress(fromAddressemail));

            using var client = new SmtpClient(fromServer, fromPort);
            await client.SendMailAsync(message);
        }
    }
}
