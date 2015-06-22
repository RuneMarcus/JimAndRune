using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookingProgram
{
    public partial class lokaleRedigerForm : Form
    {
        SqlConnection con;
        SqlDataAdapter adap;
        DataSet ds;
        SqlCommandBuilder cmdbl;
        public lokaleRedigerForm()
        {
            InitializeComponent();
        }

        private void lokaleRedigerForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=np:\\.\pipe\LOCALDB#9A432131\tsql\query;Initial Catalog=Context.BookingContext;Integrated Security=True";
            con.Open();
            adap = new SqlDataAdapter("select lokaleID, addresse, postnummer, areal, pladsTil from Lokaler", con);
            ds = new System.Data.DataSet();
            adap.Fill(ds, "Lokale_Details");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmdbl = new SqlCommandBuilder(adap);
            adap.Update(ds, "Lokale_Details");
            MessageBox.Show("Lokale info has been updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
