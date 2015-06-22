using System;
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

namespace BookingProgram
{
    public partial class deletebookingform : Form
    {
        int userID;

        public deletebookingform(int userNumber)
        {
            InitializeComponent();
            userID = userNumber;

            using (Context.BookingContext context = new Context.BookingContext())
            {
                Bruger user = new Bruger();
                user = context.Brugere.Find(userID);
                
                IQueryable<Context.Booking> booking_query =
                            from booking in context.Bookings
                            where booking.Bruger.brugerID == user.brugerID
                            select booking;

                

                foreach (Context.Booking result in booking_query)
                {
                    comboBox1.Items.Add(result.BookingID);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Booking bookingObject = new Booking();
            int bookingPick;
            bookingPick = Convert.ToInt32(comboBox1.Text);

            using (Context.BookingContext context = new Context.BookingContext())
            {
                bookingObject = context.Bookings.Find(bookingPick);
                context.Bookings.Remove(bookingObject);
                context.SaveChanges();
            }
        }
    }
}
