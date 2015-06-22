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
    public partial class nybrugerForm : Form
    {
        public nybrugerForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (passwordBox1.Text != passwordBox2.Text)
            {
                MessageBox.Show("De indtastede passwords stemmer ikke over ens");

            }
            else if (passwordBox1.Text == passwordBox2.Text)
            {
                using (var ctx = new BookingContext())
                {
                    Bruger user = new Bruger()
                    {
                        fornavn = fornavnBox.Text,
                        efternavn = efternavnBox.Text,
                        addresse = addresseBox.Text,
                        email = emailBox.Text,
                        telefon = telefonBox.Text,
                        password = passwordBox1.Text,
                        administrator = false
                    };

                    ctx.Brugere.Add(user);
                    ctx.SaveChanges();
                }
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookingGUI loginForm = new BookingGUI();

            loginForm.Show();
            this.Hide();
        }
    }
}
