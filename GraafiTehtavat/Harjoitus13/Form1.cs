using System.IO;

namespace Harjoitus13
{
    public partial class SuosittuNimi : Form
    {
        public SuosittuNimi()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            string[] boys = File.ReadAllLines("C:/Users/Viktoriia/repos/Ohjelmistokehittaja/GraafiTehtavat/Harjoitus13/assets/pojat.txt");
            string[] girls = File.ReadAllLines("C:/Users/Viktoriia/repos/Ohjelmistokehittaja/GraafiTehtavat/Harjoitus13/assets/tytot.txt");
            string name = NimiTB.Text;
            int laskurip = 1;
            int laskurit = 1;
            foreach (string s in boys)
            {
                if (name == s)
                {
                    VastausLB.Text = "Nimesi on " + laskurip + ". suosituin poikien nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach (string g in girls)
            {
                if (name == g)
                {
                    VastausLB.Text = "Nimesi on " + laskurit + ". suosituin tyttöjen nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurit++;
            }
            if (VastausLB.Visible == false)
            {
                VastausLB.Text = "Nimesi ei löytynyt suosituimpien nimien joukossa.";
                VastausLB.Visible = true;
            }
        }

        private void NimiTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TarkastaBT_Click(sender,e);
            }
        }
    }
}