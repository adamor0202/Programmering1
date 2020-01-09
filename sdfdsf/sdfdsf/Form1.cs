using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sdfdsf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            
            
            int k = int.Parse(textBox2.Text);
           
            for (int i = 1; i <= k; i++)
            {
                
                for (int n = 1; n <= i; n++)
                {
                    textBox1.Text += " O ";
                }
                
                textBox1.Text += "\r\n";
            }
            
            
        }
    }
}
