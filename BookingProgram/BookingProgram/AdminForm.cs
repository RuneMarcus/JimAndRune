using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookingProgram;

namespace BookingProgram
{
    public partial class AdminForm : Form
    {
        public AdminForm(int loginID)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookingGUI loginForm = new BookingGUI();

            loginForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            brugerSletForm brugerSletForm = new brugerSletForm();

            this.Hide();
            brugerSletForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lokaleOpretForm lokaleOpretForm = new lokaleOpretForm();

            this.Hide();
            lokaleOpretForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lokaleSletForm lokaleSletForm = new lokaleSletForm();

            this.Hide();
            lokaleSletForm.Show();
        }
    }
}
