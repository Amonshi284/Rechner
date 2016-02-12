using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void einsButtonClick(object sender, EventArgs e)
        {
            if (teilEingabeTextbox.Text == "0")
            {
                teilEingabeTextbox.Text = "";
            }
            teilEingabeTextbox.Text += "1";
        }

        private void zweiButtonClick(object sender, EventArgs e)
        {
            if (teilEingabeTextbox.Text == "0")
            {
                teilEingabeTextbox.Text = "";
            }
            teilEingabeTextbox.Text += "2";
        }

        private void dreiButtonClick(object sender, EventArgs e)
        {
            if (teilEingabeTextbox.Text == "0")
            {
                teilEingabeTextbox.Text = "";
            }
            teilEingabeTextbox.Text += "3";
        }

        private void vierButtonClick(object sender, EventArgs e)
        {
            if (teilEingabeTextbox.Text == "0")
            {
                teilEingabeTextbox.Text = "";
            }
            teilEingabeTextbox.Text += "4";
        }

        private void fuenfButtonClick(object sender, EventArgs e)
        {
            if (teilEingabeTextbox.Text == "0")
            {
                teilEingabeTextbox.Text = "";
            }
            teilEingabeTextbox.Text += "5";
        }

        private void sechsButtonClick(object sender, EventArgs e)
        {
            if (teilEingabeTextbox.Text == "0")
            {
                teilEingabeTextbox.Text = "";
            }
            teilEingabeTextbox.Text += "6";
        }
    }
}
