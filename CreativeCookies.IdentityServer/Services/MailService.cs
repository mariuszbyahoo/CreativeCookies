using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using MailKit.Net.Smtp;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using CreativeCookies.IdSrv.Services;

namespace CreativeCookies.IdSrv.Quickstart.Account
{
    public class MailService : IMailService
    {
        private IConfiguration _configuration;

        public MailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendConfirmationToken(string receiverAddress, string receiverLogin, string activationLink)
        {
            var msg = new MimeMessage();
            var bodyBuilder = new BodyBuilder();
            var pass = _configuration.GetSection("GmailAppPassword").Value;
            var username = _configuration.GetSection("GmailAddress").Value;

            var from = new MailboxAddress("AutoMail", "auto@creativecookies.io");
            var to = new MailboxAddress(receiverLogin, receiverAddress);

            msg.From.Add(from);
            msg.To.Add(to);

            msg.Subject = "Activate your email to start using Creative Cookies!";

            bodyBuilder.HtmlBody = $"<h1>Creative Cookies</h1><br /><a href={activationLink}>Confirm email address</a>";
            bodyBuilder.TextBody = $"Creative Cookies email confirmation link:\n{activationLink}";

            msg.Body = bodyBuilder.ToMessageBody();

            var smtpClient = new SmtpClient();
            await smtpClient.ConnectAsync("smtp.gmail.com", 587, false);
            await smtpClient.AuthenticateAsync(username, pass);
            await smtpClient.SendAsync(msg);
            smtpClient.Disconnect(true);
        }
    }
}
