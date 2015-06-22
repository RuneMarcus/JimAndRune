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
        static string failmail;

        static void Main(string[] args)
        {
            Console.WriteLine("Send Mail Program Started!");
            Thread th1 = new Thread(bookingservice);
            th1.Start();
            var p = new Program();
            while (true)
            {
                p.sendMail();
                Thread.Sleep(5000);
            }
            
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
                        failmail = mail.Sender.Address;
                        createBooking(findUser(mail.Sender.Address), findLokale(mail.Text) , mail.Text);
                    }
                    imap.Close();
                    Thread.Sleep(200);
                }
            }
        }

        public static void FailResponceMail(string mailaddress)
        {
            var fromAddress = new MailAddress("voresBookingService@gmail.com", "Darude Booking");
            var toAddress = new MailAddress(mailaddress, "sandstorm");
            const string fromPassword = "jimogrune";
            const string subject = "Your mail failed, here's an example";
            const string body = "Example: 'lokale 1 starttid 2015-02-02-12-00-00 sluttid 2015-02-02-14-00-00'";

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
            Lokale nothing = null;
            try 
            { 
            int lokaleIdentifier = Convert.ToInt32(mailtext.Split(' ')[1]);
            using (Context.BookingContext context = new BookingContext())
            {
                return context.Lokaler.Find(lokaleIdentifier);
            }
            }
            catch
            {
                Console.WriteLine("Wrong input");
                FailResponceMail(failmail);
                return nothing;
            }
        }

        public static void createBooking(Bruger user_obj, Lokale lokale_obj, string mailtext)
        {
            try
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
            catch
            {
                Console.WriteLine("Wrong input");
                FailResponceMail(user_obj.email);
            }
        }
        public void sendMail()
        {
            using (Context.BookingContext context = new Context.BookingContext())
            {

                var booking_query =
                        from booking in context.Bookings
                        where booking.godkendt == false
                        select booking;

                foreach (var result in booking_query)
                {
                    int brugerIDs = result.Bruger.brugerID;
                    int lokaleIDs = result.Lokale.lokaleID;
                    string fornavne = result.Bruger.fornavn;
                    string brugerEmail = result.Bruger.email;
                    DateTime StartTime = result.startTidspunkt;
                    DateTime EndTime = result.slutTidspunkt;


                    var fromAddress = new MailAddress("VoresBookingService@gmail.com", "From BookingServiceMail");
                    var toAddress = new MailAddress(brugerEmail, "To " + fornavne);
                    const string fromPassword = "jimogrune";
                    string subject = "Hej " + fornavne + "!";
                    string body = "Tak for din booking. \nBook start tid:" + StartTime + " Book slut tid:" + EndTime + "\nVi vil straks sørger for at dette lokale er klar når du skal bruge det. \nMed Venlig Hilsen BookingService.";

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

                    var bookingchange = new Booking() { BookingID = 1, godkendt = true };

                    Booking stud;
                    using (var ctx = new BookingContext())
                    {
                        stud = ctx.Bookings.Where(s => s.BookingID == result.BookingID).FirstOrDefault<Booking>();
                    }
                    stud.godkendt = true;

                    using (var ctx = new BookingContext())
                    {
                        ctx.Entry(stud).State = System.Data.Entity.EntityState.Modified;
                        ctx.SaveChanges();
                    }
                }

            }
        }
    }
}
