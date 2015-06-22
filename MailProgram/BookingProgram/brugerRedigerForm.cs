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
    public partial class brugerRedigerForm : Form
    {
        public brugerRedigerForm()
        {
            InitializeComponent();
        }

        private void brugerRedigerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Context_BookingContextDataSet1.Brugere' table. You can move, or remove it, as needed.
            this.brugereTableAdapter.Fill(this._Context_BookingContextDataSet1.Brugere);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
