using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._4upp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int Totalsekunder = int.Parse(textBox1.Text);
            int Timmar = Totalsekunder / 3600;
            int RestTimmar = Totalsekunder % 3600;
            int minuter = RestTimmar / 60;
            int RestMinuter = RestTimmar % 60;
            int sekunder = RestMinuter;
            labelTimmar.Text = Timmar.ToString() + " timmar";
            labelMinuter.Text = minuter.ToString() + " minuter";
            labelSekunder.Text = sekunder.ToString() + " sekunder";
        }
    }
}
