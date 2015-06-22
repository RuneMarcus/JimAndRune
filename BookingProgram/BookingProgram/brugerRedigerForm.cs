using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BookingProgram
{
    public partial class brugerRedigerForm : Form
    {
        SqlConnection con;
        SqlDataAdapter adap;
        DataSet ds;
        SqlCommandBuilder cmdbl;
        public brugerRedigerForm()
        {
            InitializeComponent();
        }

        private void brugerRedigerForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=np:\\.\pipe\LOCALDB#F9A40D61\tsql\query;Initial Catalog=Context.BookingContext;Integrated Security=True";
            con.Open();
            adap = new SqlDataAdapter("select brugerID, fornavn, efternavn, telefon, email, addresse, administrator from Brugere", con);
            ds = new System.Data.DataSet();
            adap.Fill(ds, "Person_Details");
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmdbl = new SqlCommandBuilder(adap);
            adap.Update(ds, "Person_Details");
            MessageBox.Show("User info has been updated");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
