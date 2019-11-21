using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBeräkna_Click(object sender, EventArgs e)
        {
            double Radie = double.Parse(tbxRadie.Text);
            double Area = Omvandling(Radie);
            lblArea.Text = Area.ToString();
        }
        double Omvandling(double Radie)
        {
            double Area = Radie * Radie * Math.PI;
            return Area;
        }
    }
}
