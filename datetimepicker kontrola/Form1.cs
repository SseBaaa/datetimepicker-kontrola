using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datetimepicker_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textispis_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonrezervacija_Click(object sender, EventArgs e)
        {
            textispis.Clear();
            DateTime datum = dateTimePickerdatum.Value;
            DateTime vrijeme = dateTimePickervrijeme.Value;

            StringBuilder ispis = new StringBuilder();
            ispis.Append("Vaš datum leta je:");
            ispis.Append(datum.ToShortDateString()+ Environment.NewLine);
            ispis.Append("Vaše vrijeme leta je:");
            ispis.Append(vrijeme.ToShortTimeString() + Environment.NewLine);

           
           string ispis2 = "Vaš datum leta je: " + datum.ToShortDateString() + Environment.NewLine + "Vaše vrijeme leta je: " + vrijeme.ToShortTimeString() + Environment.NewLine;
            textispis.Text = ispis.ToString();
            textispis.AppendText(ispis2);
        }
    }
}
