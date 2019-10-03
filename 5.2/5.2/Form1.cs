using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonKör_Click(object sender, EventArgs e)
        {
            int tal = int.Parse(textBox1.Text);
            int rest = tal % 1000;
            int tal2 = tal / 1000;
            int tal3 = tal2 * 1000;
            
                LabelSvar.Text = tal3.ToString();
        }
    }
}
