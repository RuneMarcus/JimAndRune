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
        
        public BookingForm()
        {
            FillLokaler();
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void FillLokaler()
        {
            using (Context.BookingContext context = new Context.BookingContext())
            {

                IQueryable<Context.Lokale> lokale_query =
                            from lokale in context.Lokaler
                            select lokale;


                foreach (Context.Lokale result in lokale_query)
                {
                    //comboBox1.Items.Add(result.lokaleID);
                    Console.WriteLine(result.lokaleID);
                }
            }
        }

    }
}
