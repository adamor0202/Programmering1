using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kapitel_8
{
    public partial class Form1 : Form
    {
        int datornsTal;
        int antalGissningar;

        public Form1()
        {
            InitializeComponent();
            lbxStörstaTalet.Items.Add(10);
            lbxStörstaTalet.Items.Add(20);
            lbxStörstaTalet.SelectedItem = lbxStörstaTalet.Items[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblDator_Click(object sender, EventArgs e)
        {

        }

        private void btnStartaSpelet_Click(object sender, EventArgs e)
        {
            string störstaTal = lbxStörstaTalet.SelectedItem.ToString();
            int störst = int.Parse(störstaTal);
            Random slump = new Random();
            datornsTal = slump.Next(1, störst + 1);


            btnStartaSpelet.Enabled = false;
            gbxSpelData.Enabled = false;
            gbxSpelet.Enabled = true;

            lblDatornsTal.Text = "??";
            antalGissningar = 0;
        }

        private void lblStörstaTalet_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGissa_Click(object sender, EventArgs e)
        {
            antalGissningar++;
            string gissa = tbxGissa.Text;
            int gissatTal = int.Parse(gissa);
            
            if (gissatTal == datornsTal)
            {
                lblResultat.Text = "Korrekt efter " + antalGissningar + " försök. ";
                gbxSpelet.Enabled = false;
                btnSpelaIgen.Enabled = true;

                lblDatornsTal.Text = datornsTal.ToString();
                tbxMinaResultat.AppendText(antalGissningar + " försök\n ");
            }
            else if (gissatTal < datornsTal)
            {
                lblResultat.Text = "För lågt. Försök igen";
            }
            else
            {
                lblResultat.Text = "För högt. Försök igen";
            }
        }

        private void btnSpelaIgen_Click(object sender, EventArgs e)
        {
            string störstaTal = lbxStörstaTalet.SelectedItem.ToString();
            int störst = int.Parse(störstaTal);
            Random slump = new Random();
            datornsTal = slump.Next(1, störst + 1);

            gbxSpelet.Enabled = true;
            btnSpelaIgen.Enabled = true;
            int antalGissningar = 0;
            tbxGissa.Text = "";
            lblResultat.Text = "";
            lblDatornsTal.Text = "";
        }
    }
}
