namespace Harjoitus6
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if (KayttajaTB.Text == "Jyri" && SalasanaTB.Text == "Kulta")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                VirheviestiLB.Text = "Käyttäjätunnus tai salasana virheellinen!";
                VirheviestiLB.Visible = true;
            }
        }

        private void SalasanaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (SalasanaCB.Checked)
            {
                SalasanaTB.PasswordChar = '\0';
            } else
            {
                SalasanaTB.PasswordChar = '*';
            }
        }

    }
}