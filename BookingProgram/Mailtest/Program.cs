using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Mailtest
{
    class Program
    {
        static void Main(string[] args)
        {

            var fromAddress = new MailAddress("from@gmail.com", "From Name");
            var toAddress = new MailAddress("to@hotmail.com", "To Name");
            const string fromPassword = "password";
            const string subject = "Hello";
            const string body = "Huehuehue";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }

        }
    }
}
