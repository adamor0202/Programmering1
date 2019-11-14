using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._7
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
            int Nivå = int.Parse(tbxNivå.Text);
            tbxTabell.Text = " ";

            for (int i=1 ; i<=Nivå ; i++)
            {
                for (int j=1 ; j<=10 ; j++)
                {
                    tabell += (i*j) + "\t";
                    tbxTabell.Text = tabell;
                }
                tabell += "\r\n";
            }
                
        }
    }
}
