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
    public partial class lokaleViewForm : Form
    {
        public lokaleViewForm()
        {
            InitializeComponent();
        }

        private void lokaleViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Context_BookingContextDataSet4.Lokaler' table. You can move, or remove it, as needed.
            this.lokalerTableAdapter.Fill(this._Context_BookingContextDataSet4.Lokaler);

        }
    }
}
