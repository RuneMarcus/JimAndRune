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
    public partial class brugerOpretForm : Form
    {
        public brugerOpretForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                    administrator = checkBox1.Checked
                };

                ctx.Brugere.Add(user);
                ctx.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
