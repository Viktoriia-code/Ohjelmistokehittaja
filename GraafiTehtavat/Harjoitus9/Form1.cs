namespace Harjoitus9
{
    public partial class Har9 : Form
    {
        public Har9()
        {
            InitializeComponent();
        }

        private void MuunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double asteet = Convert.ToDouble(AsteetTB.Text);
            if (CelsiusRB.Checked)
            {
                vastaus = (asteet * 1.8) + 32;
                VastausLB.Text = asteet + "°C = " + Math.Round(vastaus, 4) + "°F";
                VastausLB.Visible = true;
            }
            else if (FahrenheitRB.Checked)
            {
                vastaus = (asteet - 32) / 1.8;
                VastausLB.Text = asteet + "°F = " + Math.Round(vastaus, 4) + "°C";
                VastausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = "Et valinnut muunnettavaa astetta tai antanut oikeaa lukua.";
                VastausLB.Visible = true;
            }
        }
    }
}