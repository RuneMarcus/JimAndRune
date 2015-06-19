using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Threading;
using Limilabs.Client.IMAP;
using Limilabs.Mail;
using Context;



namespace Mailtest
{
    class Program
    {


        static void Main(string[] args)
        {
            Thread th1 = new Thread(bookingservice);
            th1.Start();

            //Thread th2;
        }

        public static void bookingservice()
        {
            Console.WriteLine("Booking Service - Started...");
            Console.WriteLine("Listening for mails...");
            while (true)
            {
                using (Imap imap = new Imap())
                {
                    imap.ConnectSSL("imap.gmail.com");
                    imap.UseBestLogin("voresbookingservice@gmail.com", "jimogrune");

                    imap.SelectInbox();

                    List<long> uids = imap.Search(Flag.Unseen);
                    foreach (long uid in uids)
                    {
                        var eml = imap.GetMessageByUID(uid);
                        IMail mail = new MailBuilder().CreateFromEml(eml);

                        Console.WriteLine(mail.Subject);
                        Console.WriteLine(mail.Text);
                        createBooking(findUser(mail.Sender.Address), findLokale(mail.Text) , mail.Text);
                    }
                    imap.Close();
                    Thread.Sleep(200);
                }
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

        public static Bruger findUser(string emailaddress)
        {
            using (Context.BookingContext context = new BookingContext())
            {
                var user_query = from bruger in context.Brugere
                                 where bruger.email == emailaddress
                                 select bruger;

                return user_query.First<Bruger>();
            }
        }

        public static Lokale findLokale(string mailtext)
        {

            int lokaleIdentifier = Convert.ToInt32(mailtext.Split(' ')[1]);
            using (Context.BookingContext context = new BookingContext())
            {
                return context.Lokaler.Find(lokaleIdentifier);
            }
        }

        public static void createBooking(Bruger user_obj, Lokale lokale_obj, string mailtext)
        {
            string time = mailtext.Split(' ')[3];
            string time2 = mailtext.Split(' ')[5];
            time2 = time2.Replace("\r\n", "");
            DateTime starttid = DateTime.ParseExact(time, "yyyy-MM-dd-HH-mm-ss", null);
            DateTime sluttid = DateTime.ParseExact(time2, "yyyy-MM-dd-HH-mm-ss", null);
            using (Context.BookingContext context = new BookingContext())
            {
                Booking booking = new Booking()
                {
                    Bruger = user_obj,
                    Lokale = lokale_obj,
                    startTidspunkt = starttid,
                    slutTidspunkt = sluttid,
                    godkendt = false
                };
                context.Bookings.Add(booking);
                context.SaveChanges();
            }
            
        }
    }
}
