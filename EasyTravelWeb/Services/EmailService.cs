using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace EasyTravelWeb.Services
{
    public class EmailService : IIdentityMessageService
    {
        public async Task SendAsync(IdentityMessage message)
        {
            // Plug in your email service here to send an email.

            Debug.Print(message.Destination);
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("easytravelsystem284@gmail.com", ".netlv-284"),
                EnableSsl = true,
            };

            var mail = new MailMessage("easytravelsystem284@gmail.com", to: message.Destination)
            {
                Body = message.Body,
                IsBodyHtml = true,
                Subject = message.Subject,
                SubjectEncoding = System.Text.Encoding.UTF8
            };

            await client.SendMailAsync(mail);
        }
    }
}