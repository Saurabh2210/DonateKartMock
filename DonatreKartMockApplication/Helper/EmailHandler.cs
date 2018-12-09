using System.Net.Mail;
using System.Configuration;


namespace DonatreKartMockApplication.Helper
{
    public class EmailHandler
    {

        public EmailHandler(string toEmail, string subject, string body)
        {
            _toEmail = toEmail;
            _fromEmail = ConfigurationManager.AppSettings["FromEmail"]; ;
            _subject = subject;
            _body = body;
        }

        private readonly string _toEmail;
        private readonly string _fromEmail;
        private readonly string _subject;
        private readonly string _body;

        public void SendEmail()
        {
            var mail = new MailMessage(_toEmail, _fromEmail);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.gmail.com"
            };
            mail.Subject = _subject;
            mail.Body = _body;
            client.Send(mail);
        }
    }
}
