using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Context;

namespace BookingProgram
{
    public partial class lokaleOpretForm : Form
    {
        public lokaleOpretForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int areals;
            areals = Convert.ToInt32(arealBox.Text);
            areals = int.Parse(arealBox.Text);

            int plads;
            plads = Convert.ToInt32(pladsBox.Text);
            plads = int.Parse(pladsBox.Text);

            using (var ctx = new BookingContext())
            {
                Lokale lokale = new Lokale()
                {
                    addresse = addresseBox.Text,
                    postnummer = postnummerBox.Text,
                    areal = areals,
                    pladsTil = plads,
                    
                };

                ctx.Lokaler.Add(lokale);
                ctx.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();

            adminForm.Show();
            this.Hide();
        }
    }
}
