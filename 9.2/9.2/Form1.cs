using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ett = textBox1.Text;
            string två = textBox2.Text;
            string tre = textBox3.Text;

            textBox1.Text = tre;
            textBox2.Text = ett;
            textBox3.Text = två;
        }
    }
}
