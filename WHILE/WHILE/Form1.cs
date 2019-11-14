using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WHILE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Start = int.Parse(tbxStart.Text);
            int Slut = int.Parse(tbxSlut.Text);
            int Steg = int.Parse(tbxSteg.Text);

            tbxUt.Text = " ";
           
            while (Start <= Slut && Steg > 0)
            {
                tbxUt.Text += Start + " ";
                Start = Start + Steg;
            }
        }
    }
}
