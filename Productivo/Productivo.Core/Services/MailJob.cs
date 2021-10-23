using System;
using System.Net.Mail;
using Productivo.Core.Entities;



namespace Productivo.Core.Services
{
    public class MailJob
    {
        private SmtpClient smtpClient { get; set; }
        private EmailJobConfigEntity config { get; set; }
        private string decodePassword { get; set; }

        public MailJob(EmailJobConfigEntity config, string _decodePassword)
        {
            this.config = config;
            this.decodePassword = _decodePassword;
            smtpClientInit();
       }

        private void smtpClientInit()
        {
            this.smtpClient = new SmtpClient();
            this.smtpClient.Host = config.SmtpHost;
            this.smtpClient.Port = config.SmtpPort;
            this.smtpClient.EnableSsl = config.EnableSSL;
            this.smtpClient.UseDefaultCredentials = true;
            this.smtpClient.Credentials = new System.Net.NetworkCredential(config.Email, decodePassword);
        }

        public MailMessage GetMail (string to, string subject, string content, bool IshtmlContent)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(config.Email);
            mail.To.Add(to);
            mail.Subject = subject;
            mail.Body = content;
            mail.IsBodyHtml = IshtmlContent;
            mail.Priority = MailPriority.Normal;
            return mail;
        }

        public bool sendMail(MailMessage mail)
        {
            try
            {
                this.smtpClient.Send(mail);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
