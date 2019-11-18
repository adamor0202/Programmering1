using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 1;
        int b = 1;
        int c = 2;
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = a.ToString() + "   " + b.ToString();
            while(c<=100)
            {
                c = a + b;
                a = b;
                b = c;
                textBox1.Text += "   " + c;
            }
        }
    }
}
