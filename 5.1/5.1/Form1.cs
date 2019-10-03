using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonKor_Click(object sender, EventArgs e)
        {
            int tal = int.Parse(textBox1.Text);
            int Svar = ((tal + 1) * 2 - 6) / 2 + 3 - tal;
            LabelSvar.Text = Svar.ToString();
        } 
    }
}
