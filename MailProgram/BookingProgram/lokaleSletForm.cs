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


namespace BookingProgram
{
    public partial class lokaleSletForm : Form
    {
        public lokaleSletForm()
        {
            InitializeComponent();
        }

        private void lokaleSletForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Context_BookingContextDataSet2.Lokaler' table. You can move, or remove it, as needed.
            this.lokalerTableAdapter.Fill(this._Context_BookingContextDataSet2.Lokaler);

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

                    cmd.CommandText = "DELETE FROM " + lokalerBindingSource + " WHERE " + lokaleIDDataGridViewTextBoxColumn + " = '" + item.Index + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Close();
                }
                dataGridView1.Refresh();
            }
        }
    }
}
