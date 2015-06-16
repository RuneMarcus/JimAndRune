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
    
    public partial class BrugerForm : Form
    {
        int bruger;
        public BrugerForm(int loginID)
        {
            InitializeComponent();

            bruger = loginID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection sqlConnection1 =
                new System.Data.SqlClient.SqlConnection(@"Data Source=np:\\.\pipe\LOCALDB#DF7C19C3\tsql\query;Initial Catalog=Context.BookingContext;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "DELETE Brugere WHERE BrugerID = " + bruger;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        private void Booking_Click(object sender, EventArgs e)
        {
            BookingForm userBooking = new BookingForm(bruger);

            this.Hide();
            userBooking.ShowDialog();
            this.Show();


        }

        

        

        
    }
}
