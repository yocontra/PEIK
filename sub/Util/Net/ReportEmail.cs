using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace sub.Util.Net
{
    internal class ReportEmail
    {
        private string _username;
        private string _password;
        private string _description;
        private string _host;
        private int _port;

        public ReportEmail(string description, string username, string password, string host, int port)
        {
            _description = description;
            _username = username;
            _password = password;
            _host = host;
            _port = port;
        }

        public void Send(string data)
        {
            if (string.IsNullOrEmpty(data)) return; //We don't want to send empty logs
            MessageBox.Show("Sending Report: " + data);
            SmtpClient smtp = new SmtpClient
            {
                Host = _host,
                Port = _port,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_username, _password)
            };
            using (MailMessage message = new MailMessage(_username, _username)
            {
                Subject = Environment.MachineName + " - " + _description,
                Body = data
            })
            {
                smtp.Send(message);
            }
        }
    }
}
