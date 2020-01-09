using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gggggg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            double ris = 1;
            double ruta = 1;
            tbxRutor.Text += "Ruta: " + ruta.ToString() + " = " + ris.ToString() + "\r\n";

            while (ruta < 64)
            {
                ruta++;
                ris = ris * 2;
                tbxRutor.Text += "Ruta: " + ruta.ToString() + " = " + ris.ToString() + "\r\n";
            }
        }

        private void btnVisa2_Click(object sender, EventArgs e)
        {
            int tal = 0;
            int summa = 0;
            
            int antal = int.Parse(textBox1.Text);
            while (tal < antal)
                
            {
                tbxSumma.Text += " " + tal.ToString();
                tal++;
                summa += tal;
                
            }
            tbxSumma.Text += " = " + summa.ToString();


        }
    }
}
