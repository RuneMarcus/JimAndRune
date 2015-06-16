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
    public partial class brugerViewForm : Form
    {
        public brugerViewForm()
        {
            InitializeComponent();
        }

        private void brugerViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Context_BookingContextDataSet3.Brugere' table. You can move, or remove it, as needed.
            this.brugereTableAdapter.Fill(this._Context_BookingContextDataSet3.Brugere);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
