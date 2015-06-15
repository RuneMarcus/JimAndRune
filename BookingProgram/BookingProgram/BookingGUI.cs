﻿using System;
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
            using (Context.BookingContext context = new Context.BookingContext())
            {
            if (textBox1.Text == "")
            {
                MessageBox.Show("This is not a valid email.");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("This password is incorrect!");
            }
            string email1, password1;

            email1 = textBox1.Text;
            password1 = textBox2.Text;


            var query = from bruger in context.Brugere
                        where bruger.email == email1
                        select bruger;

            BrugerForm brugerForm = new BrugerForm(int loginID);
            AdminForm adminForm = new AdminForm(int loginID);

            this.Hide();



            foreach (var result in query)
            {
                if (result.password == textBox2.Text)
                {
                    int LoginID = result.brugerID;
                    if(result.administrator == true)
                    {
                        MessageBox.Show("Welcome, (Admin) " + result.fornavn + " " + result.efternavn);
                        adminForm.Show(result.brugerID);
                    }
                    else if (result.administrator == false)
                    {
                        MessageBox.Show("Welcome, (User) " + result.fornavn + " " + result.efternavn);
                        brugerForm.Show(result.brugerID);
                    }
                    break;
                }
                else
                {
                    MessageBox.Show("Unsuccesful login \\n The password is incorrect!");
                    break;
                }
            }
            
            
            


            }
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
