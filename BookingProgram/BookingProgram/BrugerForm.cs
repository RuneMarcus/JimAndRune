﻿using System;
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
    
    public partial class BrugerForm : Form
    {
        int bruger;
        string emails;
        string fornavne;
        public BrugerForm(int loginID, string email, string fornavn)
        {
            InitializeComponent();

            bruger = loginID;
            emails = email;
            fornavne = fornavn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete your user?",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                System.Data.SqlClient.SqlConnection sqlConnection1 =
                new System.Data.SqlClient.SqlConnection(@"Data Source=np:\\.\pipe\LOCALDB#F9A40D61\tsql\query;Initial Catalog=Context.BookingContext;Integrated Security=True");

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE Brugere WHERE BrugerID = " + bruger;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();

                BookingGUI bookingGUI = new BookingGUI();
                this.Hide();
                bookingGUI.Show();

            }
        }

        private void Booking_Click(object sender, EventArgs e)
        {
            BookingForm userBooking = new BookingForm(bruger, emails, fornavne);

            this.Hide();
            userBooking.ShowDialog();
            this.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            deletebookingform delbookform = new deletebookingform(bruger);

            this.Hide();
            delbookform.ShowDialog();
            this.Show();
        }

        

        

        
    }
}
