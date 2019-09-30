using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSvar_Click(object sender, EventArgs e)
        {
            double varansPris = double.Parse(textBox2.Text);
            double minaPengar = double.Parse(textBox1.Text);
            bool JagHarRåd = varansPris <= minaPengar;
            lblSvar.Text = "Jag har råd: " + JagHarRåd.ToString();
        }
    }
}
