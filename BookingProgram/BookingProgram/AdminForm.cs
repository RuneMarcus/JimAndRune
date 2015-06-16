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

        private void LogAfButton_Click(object sender, EventArgs e)
        {
            BookingGUI loginForm = new BookingGUI();

            loginForm.Show();
            this.Hide();
        }

        private void BrugerOpretButton_Click(object sender, EventArgs e)
        {
            brugerOpretForm brugerOpretForm = new brugerOpretForm();
            this.Hide();
            brugerOpretForm.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BrugerSletButton_Click(object sender, EventArgs e)
        {
            brugerSletForm brugerSletForm = new brugerSletForm();
            this.Hide();
            brugerSletForm.Show();
        }

        private void LokaleOpretButton_Click(object sender, EventArgs e)
        {
            lokaleOpretForm lokaleOpretForm = new lokaleOpretForm();

            this.Hide();
            lokaleOpretForm.ShowDialog();
            this.Show();
        }

        private void LokaleSletButton_Click(object sender, EventArgs e)
        {
            lokaleSletForm lokaleSletForm = new lokaleSletForm();

            this.Hide();
            lokaleSletForm.Show();
        }

        private void BrugerViewButton_Click(object sender, EventArgs e)
        {
            brugerViewForm brugerViewForm = new brugerViewForm();
            this.Hide();
            brugerViewForm.Show();
        }

        private void LokaleViewButton_Click(object sender, EventArgs e)
        {
            lokaleViewForm lokaleViewForm = new lokaleViewForm();
            this.Hide();
            lokaleViewForm.Show();
        }

        private void LokaleRedigerButton_Click(object sender, EventArgs e)
        {
            lokaleRedigerForm lokaleRedigerForm = new lokaleRedigerForm();
            this.Hide();
            lokaleRedigerForm.Show();
        }

        private void BrugerRedigerButton_Click(object sender, EventArgs e)
        {
            brugerRedigerForm brugerRedigerForm = new brugerRedigerForm();
            this.Hide();
            brugerRedigerForm.Show();
        }

        private void BrugerHistorikButton_Click(object sender, EventArgs e)
        {
            brugerHistorikForm brugerHistorikForm = new brugerHistorikForm();
            this.Hide();
            brugerHistorikForm.Show();
        }

        private void LokaleHistorikButton_Click(object sender, EventArgs e)
        {
            lokaleHistorikForm lokaleHistorikForm = new lokaleHistorikForm();
            this.Hide();
            lokaleHistorikForm.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
