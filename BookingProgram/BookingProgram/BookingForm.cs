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
    public partial class BookingForm : Form
    {
        int userId;
        public BookingForm(int brugerID)
        {
            InitializeComponent();
            userId = brugerID;
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
                    startTidspunkt = new DateTime(2015, 06, 04, 12, 30, 00),
                    slutTidspunkt = new DateTime(2015, 06, 04, 13, 30, 00),
                    godkendt = true
                };


                context.Bookings.Add(bookings);
                context.SaveChanges();
                
            }
        }

    }
}
