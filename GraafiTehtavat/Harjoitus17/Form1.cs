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
        // Tiedosto -> Avaa
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
        // Tiedosto -> Uusi
        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TekstilaatikkoRTB.Text != "")
            {
                tallennaNimelläToolStripMenuItem_Click(sender, e);
                TekstilaatikkoRTB.Text = "";
            }
            else
            {
                TekstilaatikkoRTB.Text = "";
            }
        }
        // Tiedosto -> Tallenna
        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tiedostopolku))
            {
                using (SaveFileDialog ttk = new SaveFileDialog()
                { Filter = "Rikastekstiformaatti|*.rtf", ValidateNames = true })
                {
                    if(ttk.ShowDialog()==DialogResult.OK)
                    {
                        StreamWriter tiedosto = new StreamWriter(ttk.FileName);
                        tiedosto.WriteLine(this.TekstilaatikkoRTB.Rtf);
                        tiedosto.Close();
                    }
                }
            }
            else
            {
                using (StreamWriter vk = new StreamWriter(tiedostopolku))
                {
                    vk.WriteLineAsync(TekstilaatikkoRTB.Rtf);
                }
            }
        }
        // Tiedosto -> Tallenna nimellä
        private void tallennaNimelläToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ttk = new SaveFileDialog()
            { Filter = "TextDocument|*.txt", ValidateNames = true })
            {
                if (ttk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                    {
                        jonokirjoittaja.WriteLineAsync(TekstilaatikkoRTB.Text);
                    }
                }
            }
        }
        // Tiedosto -> Tulostuksen esikatselu
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