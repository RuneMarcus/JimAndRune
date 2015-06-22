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
            populateListview();
        }

        private void brugerViewForm_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        public void populateListview()
        {

            using (Context.BookingContext context = new Context.BookingContext())
            {
                var query = from bruger in context.Brugere
                            select bruger;


                foreach (var result in query)
                {
                    ListViewItem item = new ListViewItem(result.fornavn);
                    item.SubItems.Add(result.efternavn);
                    item.SubItems.Add(result.email);
                    item.SubItems.Add(result.addresse);
                    item.SubItems.Add(result.brugerID.ToString());
                    item.SubItems.Add(result.telefon);
                    item.SubItems.Add(result.administrator.ToString());
                    listView1.Items.Add(item);
                }
            }
        
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        
        

    }
}
