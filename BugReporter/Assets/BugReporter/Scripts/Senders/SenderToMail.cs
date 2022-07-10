using System;
using System.Net;
using System.Net.Mail;
using UnityEngine;
using Utilities.BugReporter;

namespace Example
{
    public class SenderToMail : IBugSender
    {
        private string _senderMail;
        private string _senderPassword;
        private string _recipientMail;

        public SenderToMail(string mail, string mailPassword, string recipientMail)
        {
            _senderMail = mail;
            _senderPassword = mailPassword;
            _recipientMail = recipientMail;
        }

        public void SendData(IBugModel bugReport)
        {
            MailAddress from = new MailAddress(_senderMail, "Bug-Report " + DateTime.Now.ToString("dd/MM/yyyy"));
            MailAddress to = new MailAddress(_recipientMail);
            MailMessage m = new MailMessage(from, to);

            m.Subject = "Bug Report from: " + DateTime.Now;
            m.Body = bugReport.GetBugReport();
            m.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.bk.ru", 25);
            smtp.Credentials = new NetworkCredential(_senderMail, _senderPassword);
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(m);
                Debug.Log("Complete!");
            }
            catch (SmtpException e)
            {
                Debug.LogError(e);
            }

        }
    }
}