﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Context;
using System.Net.Mail;
using System.Net;

namespace BookingProgram
{
    public partial class BookingForm : Form
    {
        int userId;
        string emails;
        string fornavne;
        public BookingForm(int brugerID, string email, string fornavn)
        {
            InitializeComponent();
            userId = brugerID;
            emails = email;
            fornavne = fornavn;
            FillLokaler();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //fills out the LokaleIDs
        public void FillLokaler()
        {
            using (Context.BookingContext context = new Context.BookingContext())
            {
                IQueryable<Context.Lokale> lokale_query =
                            from lokale in context.Lokaler
                            select lokale;

                foreach (Context.Lokale result in lokale_query)
                {
                    comboBox1.Items.Add(result.lokaleID);
                }
            }
            
        }

        private void Booking_Click(object sender, EventArgs e)
        {
            int lokalePick;
            lokalePick = Convert.ToInt32(comboBox1.Text);

            using (Context.BookingContext context = new Context.BookingContext())
            {
                var lokale =
                            context.Lokaler.Find(lokalePick);

                var user =
                            context.Brugere.Find(userId);



                Context.Booking bookings = new Context.Booking()
                {
                    Bruger = user,
                    Lokale = lokale,
                    startTidspunkt = new DateTime(
                        Convert.ToInt32(YearDrop.Text),
                        Convert.ToInt32(MonthDrop.Text), 
                        Convert.ToInt32(DayDrop.Text),
                        Convert.ToInt32(FromDrop.Text), 00, 00),
                    slutTidspunkt = new DateTime(
                        Convert.ToInt32(YearDrop.Text),
                        Convert.ToInt32(MonthDrop.Text), 
                        Convert.ToInt32(DayDrop.Text),
                        Convert.ToInt32(ToDrop.Text), 00, 00),
                    godkendt = true
                };

                context.Bookings.Add(bookings);
                context.SaveChanges();

                var fromAddress = new MailAddress("VoresBookingService@gmail.com", "From BookingServiceMail");
                var toAddress = new MailAddress(emails, "To " + fornavne);
                const string fromPassword = "jimogrune";
                string subject = "Hej " + fornavne + "!";
                string body = "Tak for din booking. \\nBook start tid:" + bookings.startTidspunkt + " Book slut tid:" + bookings.slutTidspunkt + "\\nVi vil straks sørger for at dette lokale er klar når du skal bruge det. \\nMed Venlig Hilsen BookingService.";

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

        private void DayDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FromDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ToDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}
