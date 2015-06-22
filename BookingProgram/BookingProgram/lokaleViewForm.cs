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
            populateListview();
        }

        public void populateListview()
        {

            using (Context.BookingContext context = new Context.BookingContext())
            {
                var query = from lokale in context.Lokaler
                            select lokale;


                foreach (var result in query)
                {
                    ListViewItem item = new ListViewItem(result.addresse);
                    item.SubItems.Add(result.postnummer);
                    item.SubItems.Add(result.areal.ToString());
                    item.SubItems.Add(result.pladsTil.ToString());
                    item.SubItems.Add(result.lokaleID.ToString());
                    listView1.Items.Add(item);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
