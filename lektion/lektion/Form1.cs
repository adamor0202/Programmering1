using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lektion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSvar_Click(object sender, EventArgs e)
        {
            int tal1 = int.Parse(boxTal1.Text);
            int tal2 = int.Parse(boxTal2.Text);
            int Svaret = 0;

            char raknesatt = char.Parse(BoxRaknesatt.Text);

           
            if (raknesatt == '*')
            {
                Svaret = tal1 * tal2;
            }

            else if (raknesatt == '/')
            {
                Svaret = tal1 / tal2;
            }

            else if (raknesatt == '+')
            {
                Svaret= tal1 + tal2;
            }

            else if (raknesatt == '-')
            {
                Svaret = tal1 - tal2;
            }

            lblSvar.Text = Svaret.ToString();






        }
    }
}
