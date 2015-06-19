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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;



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
                    string mailinput;
                    Console.WriteLine("Booking Service - Started...");
                    Console.WriteLine("Listening for mails...");
                    while(true)
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
                                mailinput = mail.Text;
                                
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

                public void createUser(string emailaddress)
                {
                    using (Context.Bruger user = new Bruger())
                    {

                    }

                }
    }
}
