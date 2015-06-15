using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingProgram
{
    public partial class BookingGUI : Form
    {
        public BookingGUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Indtast en Email!");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Indtast et Password!");
            }
            string email1, password1;

            email1 = textBox1.Text;
            password1 = textBox2.Text;

            BrugerForm brugerForm = new BrugerForm();
            AdminForm adminForm = new AdminForm();

            this.Hide();
            adminForm.Show();
            brugerForm.Show();
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nybrugerForm nybrugerForm = new nybrugerForm();

            this.Hide();
            nybrugerForm.Show();
        }
    }
}
