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

        private void siebenButton_Click(object sender, EventArgs e)
        {
            teilEingabeTextbox.Text += "7";
        }

        private void achtButton_Click(object sender, EventArgs e)
        {
            teilEingabeTextbox.Text += "8";
        }

        private void neunButton_Click(object sender, EventArgs e)
        {
            teilEingabeTextbox.Text += "9";
        }

        private void negativButton_Click(object sender, EventArgs e)
        {
            teilEingabeTextbox.Text += "-";
        }
    }
}
