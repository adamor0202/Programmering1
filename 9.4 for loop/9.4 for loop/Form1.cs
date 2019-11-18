using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._4_for_loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tabell = "";
            for(int n=0; n<=100; n=n+5)

            {
                tabell = tabell + " " + n.ToString();
            }
            textBox1.Text = tabell;
        }
    }
}
