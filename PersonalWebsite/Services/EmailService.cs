using MailKit.Net.Smtp;
using MimeKit;
using System.Threading.Tasks;

namespace PersonalWebsite.Services
{
    public class EmailService {
        private readonly static string _smtpServer = "smtp.gmail.com";
        private readonly static int _smtpPortNumber = 587;
        private readonly static string _fromAddressTitle = "Email Sent From Personal Website";
        private readonly static string _fromAddress = "jason.j.roodman@gmail.com";
        private readonly static string _fromAddressPassword = "Emailisgreat1!";

        public static async Task<bool> SendEmail(
            string toName,
            string toAddress, 
            string subject, 
            string htmlBody)
        {
            MimeMessage message = CreateMessage(toName, toAddress, subject, htmlBody);

            using (SmtpClient smtpClient = new SmtpClient())
            {
                smtpClient.Connect(_smtpServer, _smtpPortNumber, false);
                smtpClient.Authenticate(_fromAddress, _fromAddressPassword);
                await smtpClient.SendAsync(message);
                smtpClient.Disconnect(true);
            }

            return true;
        }

        private static MimeMessage CreateMessage(
            string toName,
            string toAddress, 
            string subject,
            string htmlBody)
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress(_fromAddressTitle, _fromAddress));
            message.To.Add(new MailboxAddress(toName, toAddress));
            message.Subject = subject;
            message.Body = new TextPart("html")
            {
                Text = htmlBody
            };

            return message;
        }
    }
}
