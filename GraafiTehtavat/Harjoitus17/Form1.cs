using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Harjoitus17
{
    public partial class MuistioForm : Form
    {
        string tiedostopolku = "";
        public MuistioForm()
        {
            InitializeComponent();
        }
        // Tiedosto -> Avaa
        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog atk = new OpenFileDialog()
                { Filter = "TextDocument|*.txt|Rich Text Format|*.rtf", ValidateNames = true, Multiselect = false })
                {
                    if (atk.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamReader vl = new StreamReader(atk.FileName))
                        {
                            tiedostopolku = atk.FileName;
                            Text = tiedostopolku;
                            TekstilaatikkoRTB.Text = File.ReadAllText(tiedostopolku);
                            Task<string> teksti = vl.ReadToEndAsync();
                            TekstilaatikkoRTB.Rtf = teksti.Result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe avattaessa tiedostoa: " + ex.Message);
            } 
        }
        // Tiedosto -> Uusi
        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TekstilaatikkoRTB.Text))
                {
                    MessageBox.Show("Sinun tulee tallentaa ensin.");
                    tallennaNimelläToolStripMenuItem_Click(sender, e);
                    TekstilaatikkoRTB.Text = "";
                }
                else
                {
                    TekstilaatikkoRTB.Text = string.Empty;
                    Text = "Nimetön";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message);
            }
        }
        // Tiedosto -> Tallenna
        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tiedostopolku))
                {
                    using (SaveFileDialog ttk = new SaveFileDialog()
                    { Filter = "TextDocument|*.txt|Rich Text Format|*.rtf", ValidateNames = true })
                    {
                        if (ttk.ShowDialog()==DialogResult.OK)
                        {
                            StreamWriter tiedosto = new StreamWriter(ttk.FileName);
                            tiedosto.WriteLine(this.TekstilaatikkoRTB.Rtf);
                            tiedosto.Close();
                        }
                    }
                }
                else
                {
                    using(StreamWriter vk = new StreamWriter(tiedostopolku))
                    {
                        vk.WriteLineAsync(TekstilaatikkoRTB.Rtf);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message);
            }
        }
        // Tiedosto -> Tallenna nimellä
        private void tallennaNimelläToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ttk = new SaveFileDialog()
            { Filter = "TextDocument|*.txt|Rich Text Format|*.rtf", ValidateNames = true })
            {
                if (ttk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                    {
                        jonokirjoittaja.WriteLineAsync(TekstilaatikkoRTB.Rtf);
                    }
                }
            }
        }
        // Tiedosto -> Tulostuksen esikatselu
        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(TekstilaatikkoRTB.Text, TekstilaatikkoRTB.Font, Brushes.Black, 12, 10);
        }
        // Tiedosto -> Tulosta
        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        // Tiedosto -> Poistu
        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Muokkaa -> Undo
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Undo();
        }
        // Muokkaa -> Redo
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Redo();
        }
        // Muokkaa -> Kopioi
        private void kopioiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Copy();
        }
        // Muokkaa -> Leikkaa
        private void leikkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Cut();
        }
        // Enable Copy and Cut when Tekstilaatikko is empty
        private void TekstilaatikkoRTB_TextChanged(object sender, EventArgs e)
        {
            if (TekstilaatikkoRTB.Text.Length > 0)
            {
                kopioiToolStripMenuItem.Enabled = true;
                leikkaaToolStripMenuItem.Enabled = true;
            }
            else
            {
                kopioiToolStripMenuItem.Enabled = false;
                leikkaaToolStripMenuItem.Enabled = false;
            }
        }
        // Muokkaa -> Liitä
        private void liitäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Paste();
        }
        // Muokkaa -> Poista
        private void poistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.SelectedText = "";
        }
        // Muokkaa -> Valitse kaikki
        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.SelectAll();
        }
        // Muotoile -> Tekstin rivittys
        private void tekstinRivittysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tekstinRivittysToolStripMenuItem.Checked == true)
            {
                tekstinRivittysToolStripMenuItem.Checked = false;
                TekstilaatikkoRTB.WordWrap = false;
            }
            else
            {
                tekstinRivittysToolStripMenuItem.Checked = true;
                TekstilaatikkoRTB.WordWrap = true;
            }
        }
        // Muotoile -> Kirjasin
        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            TekstilaatikkoRTB.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }
        // Muotoile -> Tekstin korostus
        private void tekstinKorostusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.SelectionBackColor = Color.Yellow;
        }
        // Apua -> Tietoa
        private void tietoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tietoa tietoa = new tietoa();
            tietoa.ShowDialog();
        }
    }
}