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

namespace BookingProgram
{
    public partial class BookingForm : Form
    {
        IQueryable<Context.Lokale> lokaleID;
        public BookingForm(IQueryable<Context.Lokale> lokaleNavn)
        {
            InitializeComponent();
            lokaleID = lokaleNavn;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //public void FillLokaler(IQueryable BookingFill)
        //{
        //    foreach (Lokale result in BookingFill)
        //    {
        //        comboBox1.Items.Add(result.);

        //    }
        //}

    }
}
