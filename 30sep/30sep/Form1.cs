using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30sep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Knapp_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = a--;
            int c = ++b + a;

            label2.Text = c.ToString();
        }
    }
}
