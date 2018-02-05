using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace EasyTravelWeb.Services
{
    /// <summary>
    ///    Service for sending email
    /// </summary>

    public class EmailService : IIdentityMessageService
    {
        /// <summary>
        ///    Sends email to user
        /// </summary>
        public async Task SendAsync(IdentityMessage message)
        {
            var client = new SmtpClient(
	            Constants.Constants.EmailServiceConstants.SmtpClientHost, 
	            Constants.Constants.EmailServiceConstants.SmtpClientPort)
            {
                Credentials = new NetworkCredential(
	                Constants.Constants.EmailServiceConstants.Credentials.Email,
	                Constants.Constants.EmailServiceConstants.Credentials.Password),
                EnableSsl = true,
            };

            var mail = new MailMessage(
	            Constants.Constants.EmailServiceConstants.Credentials.Email, 
	            message.Destination)
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