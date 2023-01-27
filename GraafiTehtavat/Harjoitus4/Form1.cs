namespace Harjoitus4
{
    public partial class Harjoitus4 : Form
    {
        public Harjoitus4()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = synttariDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays);
            VuosinaLB.Text = Math.Floor(erotus / 365.25) + " vuotta";
            KuukausinaLB.Text = Math.Floor(erotus*12 / 365.25) + " kuukautta";
            PaivinaLB.Text = erotus + " päivää";
            TunteinaLB.Text = erotus * 24 + " tuntia";
            MinuutteinaLB.Text = erotus * 24 * 60 + " minuuttia";
            SekunteinaLB.Text = erotus * 24 * 3600 + " sekuntia";

            VuosinaLB.Visible = true;
            KuukausinaLB.Visible = true;
            PaivinaLB.Visible = true;
            TunteinaLB.Visible = true;
            MinuutteinaLB.Visible = true;
            SekunteinaLB.Visible = true;
        }
    }
}