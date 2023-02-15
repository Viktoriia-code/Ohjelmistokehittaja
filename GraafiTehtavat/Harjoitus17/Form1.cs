using System.IO;

namespace Harjoitus17
{
    public partial class Muistio : Form
    {
        string tiedostopolku = "";
        public Muistio()
        {
            InitializeComponent();
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog atk = new OpenFileDialog()
            { Filter = "Rikastekstiformaatti|*.rtf", ValidateNames = true, Multiselect = false })
            {
                if (atk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader vl = new StreamReader(atk.FileName))
                    {
                        tiedostopolku = atk.FileName;
                        Task<string> teksti = vl.ReadToEndAsync();
                        TekstilaatikkoRTB.Rtf = teksti.Result;
                    }
                }
            }
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Text = "";
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tallennaNimelläToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}