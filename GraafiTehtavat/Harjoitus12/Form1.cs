using System;

namespace Harjoitus12
{
    public partial class Kysymys10 : Form
    {
        int laskuri = 0;
        int oikein = 0;
        string[] vastaukset = new string[10];
        string[] oikeatVastaukset = new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };
        public Kysymys10()
        {
            InitializeComponent();
            Vastaus1RB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            Vastaus2RB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            Vastaus3RB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            Vastaus4RB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
        }

        private void Kysymys10_Load(object sender, EventArgs e)
        {

        }

        private void radiobutton_CheckedChanged(object? sender, EventArgs e)
        {
            if(sender is RadioButton && laskuri < 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                laskuri++;
                KysymysLB.Text = "Vastaus " + laskuri + ". kysymykseen:";
            }
            else
            {
                VastausLB.Text = "";
                Vastaus1RB.Enabled = false;
                Vastaus2RB.Enabled = false;
                Vastaus3RB.Enabled = false;
                Vastaus4RB.Enabled = false;
                for (int i = 0; i < 10; i++)
                {
                    if (vastaukset[i] == oikeatVastaukset[i])
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = "Oikeita vastauksia oli: " + oikein;
                VastausLB.Visible = true;
            }
            TyhjaaVastaus();
        }
        private void TyhjaaVastaus()
        {
            if (Vastaus1RB.Checked == true)
            {
                Vastaus1RB.Checked = false;
                laskuri--;
            }
            if (Vastaus2RB.Checked == true)
            {
                Vastaus2RB.Checked = false;
                laskuri--;
            }
            if (Vastaus3RB.Checked == true)
            {
                Vastaus3RB.Checked = false;
                laskuri--;
            }
            if (Vastaus4RB.Checked == true)
            {
                Vastaus4RB.Checked = false;
                laskuri--;
            }
        }
    }
}