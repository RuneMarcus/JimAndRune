using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Threading;


namespace Mailtest
{
    class Program
    {
        Thread th1;
        Thread th2;
        static void Main(string[] args)
        {
            // C# code:

            using (Imap imap = new Imap())
            {
                imap.ConnectSSL("imap.gmail.com");
                imap.UseBestLogin("pat@gmail.com", "password");

                imap.SelectInbox();

                List<long> uids = imap.Search(Flag.Unseen);
                foreach (long uid in uids)
                {
                    var eml = imap.GetMessageByUID(uid);
                    IMail mail = new MailBuilder().CreateFromEml(eml);

                    Console.WriteLine(mail.Subject);
                    Console.WriteLine(mail.Text);
                }
                imap.Close();
            }
        }

        public void FailResponceMail()
        {
            var fromAddress = new MailAddress("voresBookingService@gmail.com", "Darude Booking");
            var toAddress = new MailAddress("jimpoulsen9@gmail.com", "sandstorm");
            const string fromPassword = "jimogrune";
            const string subject = "Hello";
            const string body = "Learn 2 english, plz";

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
