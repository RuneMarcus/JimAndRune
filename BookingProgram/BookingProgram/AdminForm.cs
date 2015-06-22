using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookingProgram;
using System.Xml;
using Context;

namespace BookingProgram
{
    public partial class AdminForm : Form
    {
        public AdminForm(int loginID)
        {
            InitializeComponent();
        }

        private void LogAfButton_Click(object sender, EventArgs e)
        {
            BookingGUI loginForm = new BookingGUI();

            loginForm.Show();
            this.Hide();
        }

        private void BrugerOpretButton_Click(object sender, EventArgs e)
        {
            brugerOpretForm brugerOpretForm = new brugerOpretForm();
            this.Hide();
            brugerOpretForm.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BrugerSletButton_Click(object sender, EventArgs e)
        {
            brugerSletForm brugerSletForm = new brugerSletForm();
            this.Hide();
            brugerSletForm.ShowDialog();
            this.Show();
        }

        private void LokaleOpretButton_Click(object sender, EventArgs e)
        {
            lokaleOpretForm lokaleOpretForm = new lokaleOpretForm();
            this.Hide();
            lokaleOpretForm.ShowDialog();
            this.Show();
        }

        private void LokaleSletButton_Click(object sender, EventArgs e)
        {
            lokaleSletForm lokaleSletForm = new lokaleSletForm();
            this.Hide();
            lokaleSletForm.ShowDialog();
            this.Show();
        }

        private void BrugerViewButton_Click(object sender, EventArgs e)
        {
            brugerViewForm brugerViewForm = new brugerViewForm();
            this.Hide();
            brugerViewForm.ShowDialog();
            this.Show();
        }

        private void LokaleViewButton_Click(object sender, EventArgs e)
        {
            lokaleViewForm lokaleViewForm = new lokaleViewForm();
            this.Hide();
            lokaleViewForm.ShowDialog();
            this.Show();
        }

        private void LokaleRedigerButton_Click(object sender, EventArgs e)
        {
            lokaleRedigerForm lokaleRedigerForm = new lokaleRedigerForm();
            this.Hide();
            lokaleRedigerForm.ShowDialog();
            this.Show();
        }

        private void BrugerRedigerButton_Click(object sender, EventArgs e)
        {
            brugerRedigerForm brugerRedigerForm = new brugerRedigerForm();
            this.Hide();
            brugerRedigerForm.ShowDialog();
            this.Show();
        }

        private void BrugerHistorikButton_Click(object sender, EventArgs e)
        {
            brugerHistorikForm brugerHistorikForm = new brugerHistorikForm();
            this.Hide();
            brugerHistorikForm.ShowDialog();
            this.Show();
        }

        private void LokaleHistorikButton_Click(object sender, EventArgs e)
        {
            lokaleHistorikForm lokaleHistorikForm = new lokaleHistorikForm();
            this.Hide();
            lokaleHistorikForm.ShowDialog();
            this.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void xml_Click(object sender, EventArgs e)
        {
            using (Context.BookingContext context = new Context.BookingContext())
            {

                var query = from booking in context.Bookings
                            select booking;


                String xmlFileName = ("output.xml");

                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.NewLineOnAttributes = false;

                //Et XML document skal have et og kun et root element. Her er det PCdatabase
                XmlWriter xml = XmlWriter.Create(xmlFileName, settings);
                xml.WriteStartElement("BookingDatabase");

                foreach (var resultat in query)
                {
                    //Tilføj PC No1
                    xml.WriteStartElement("Booking");
                    xml.WriteAttributeString("No", Convert.ToString(resultat.BookingID));
                    xml.WriteStartElement("UserID");
                    xml.WriteValue(Convert.ToString(resultat.Bruger.brugerID));
                    xml.WriteEndElement();
                    xml.WriteStartElement("Lokale");
                    xml.WriteValue(Convert.ToString(resultat.Lokale.lokaleID));
                    xml.WriteEndElement();
                    xml.WriteStartElement("BookingStart");
                    xml.WriteValue(Convert.ToString(resultat.startTidspunkt));
                    xml.WriteEndElement();
                    xml.WriteStartElement("BookingEnd");
                    xml.WriteValue(Convert.ToString(resultat.slutTidspunkt));
                    xml.WriteEndElement();
                    xml.WriteEndElement();
                }

                xml.WriteEndElement();
                xml.Close();
                MessageBox.Show("XML completed!");
            }

        }
    }
}
