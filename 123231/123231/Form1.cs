using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _123231
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxTid_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            int total = int.Parse(textboxTid.Text);
            int timmar = total / 3600;
            int minuter = (total - timmar * 3600) / 60;
            int sekunder = (total - timmar  * 3600 - minuter * 60);

            lblTid.Text = timmar.ToString() + " timmar " + minuter.ToString() + " minuter " + sekunder.ToString() + " sekunder";
        }
    }
}
