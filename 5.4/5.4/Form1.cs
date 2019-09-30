using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBoxA.Text);
            int b = int.Parse(textBoxB.Text);
            int c = int.Parse(textBoxC.Text);
            bool Ordning = a < b && b < c;
            labelSvar.Text = Ordning.ToString();
        }
    }
}
