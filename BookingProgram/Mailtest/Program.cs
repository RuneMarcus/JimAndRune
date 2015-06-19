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
                        createBooking(createUser(mail.Sender.Address), createLokale(mail.Text) , mail.Text);
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

        public static Bruger createUser(string emailaddress)
        {
            Bruger bruger_obj = new Bruger();
            using (Context.BookingContext context = new BookingContext())
            {
                var user_query = from bruger in context.Brugere
                                 where bruger.email == emailaddress
                                 select bruger;

                foreach (var result in user_query)
                {
                    Bruger user = new Bruger()
                    {
                        fornavn = result.fornavn,
                        efternavn = result.efternavn,
                        addresse = result.addresse,
                        email = result.email,
                        telefon = result.telefon,
                        password = result.password,
                        administrator = result.administrator
                    };
                    bruger_obj = user;
                }
                return bruger_obj;
            }
        }

        public static Lokale createLokale(string mailtext)
        {
            Lokale Lokale_obj = new Lokale();
            int lokaleIdentifier = Convert.ToInt32(mailtext.Split(' ')[1]);
            using (Context.BookingContext context = new BookingContext())
            {
                var lokale_query = from lokale in context.Lokaler
                                   where lokale.lokaleID == lokaleIdentifier
                                   select lokale;

                foreach (var result in lokale_query)
                {
                    Lokale lokaleobject = new Lokale()
                    {
                        lokaleID = result.lokaleID,
                        addresse = result.addresse,
                        areal = result.areal,
                        pladsTil = result.areal,
                        postnummer = result.postnummer
                    };
                    Lokale_obj = lokaleobject;
                }
                return Lokale_obj;
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
