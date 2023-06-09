using System.Net.Mail;
using System.Net;

namespace ElmaProjesi.WebUI.EmailServices
{
    public class EmailSender : IEmailSender
    {
        private string _host;
        private string _username;
        private string _password;
        private int _port;
        private bool _enableSSL;

        public EmailSender(string host, int port, bool enableSSL, string username, string password)
        {
            _host = host;
            _username = username;
            _password = password;
            _enableSSL = enableSSL;
            _port = port;

        }

        //email: kime gidecek TO
        // subject: konu
        // htmlMessage (body): mesaj içeriği
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient(_host, _port)
            {
                Credentials = new NetworkCredential(_username, _password),
                EnableSsl = _enableSSL
            };
            return client.SendMailAsync(
                new MailMessage(_username, email, subject, htmlMessage)
                {
                    IsBodyHtml = true
                });
        }
    }
}
