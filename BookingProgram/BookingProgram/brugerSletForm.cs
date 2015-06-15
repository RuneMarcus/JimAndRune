using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Context;

namespace BookingProgram
{
    public partial class brugerSletForm : Form
    {
        public brugerSletForm()
        {
            InitializeComponent();
        }

        private void brugerSletForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Context_BookingContextDataSet.Brugere' table. You can move, or remove it, as needed.
            this.brugereTableAdapter.Fill(this._Context_BookingContextDataSet.Brugere);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        
        
        private void button1_Click(object sender, EventArgs e)
        {

            brugereBindingSource.Filter = "brugerID = '" + textBox1.Text + "'";
            brugereBindingSource.Filter = "email = '" + textBox2.Text + "'";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
                using (SqlConnection con = new SqlConnection(@"Data Source=np:\\.\pipe\LOCALDB#9EDD0E93\tsql\query;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    
                    cmd.CommandText = "DELETE FROM " + brugereBindingSource + " WHERE " + brugerIDDataGridViewTextBoxColumn + " = '" + item.Index + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Close();
                }
                dataGridView1.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
