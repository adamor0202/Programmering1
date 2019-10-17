using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oof
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Buttonsvar_Click(object sender, EventArgs e)
        {
            double tal1 = double.Parse(textBox1.Text);
            double tal2 = double.Parse(textBox2.Text);

            if (tal1 < tal2)
            {
                labeltal.Text = tal1.ToString();
            }


            else if (tal2 < tal1)
            {
                labeltal.Text = tal2.ToString();
            }

            else if (tal2 == tal1)
            {
                labeltal.Text = "ingen, de är lika stora";
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
