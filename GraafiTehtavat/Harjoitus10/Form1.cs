namespace Harjoitus10
{
    public partial class BmiLaskuri : Form
    {
        public BmiLaskuri()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0;
            double pituus = 0;
            paino = Convert.ToDouble(PainoTB.Text);
            pituus = Convert.ToDouble(PituusTB.Text)/100;
            double bmi = Math.Round(paino/(pituus*pituus), 2);
            if (bmi < 18.5)
            {
                BmiLB.Text = "Painoindeksisi on: " + bmi;
                BmiLB.ForeColor = Color.Aqua;
                BmiLB.Visible = true;
                KuvausLB.Text = "Alipaino";
                KuvausLB.ForeColor = Color.Aqua;
                KuvausLB.Visible = true;
            }
            else if (bmi < 25)
            {
                BmiLB.Text = "Painoindeksisi on: " + bmi;
                BmiLB.ForeColor = Color.Green;
                BmiLB.Visible = true;
                KuvausLB.Text = "Normaalipaino";
                KuvausLB.ForeColor = Color.Green;
                KuvausLB.Visible = true;
            }
            else if (bmi < 40)
            {
                BmiLB.Text = "Painoindeksisi on: " + bmi;
                BmiLB.ForeColor = Color.Gold;
                BmiLB.Visible = true;
                KuvausLB.Text = "Ylipaino";
                KuvausLB.ForeColor = Color.Gold;
                KuvausLB.Visible = true;
            }
            else
            {
                BmiLB.Text = "Painoindeksisi on: " + bmi;
                BmiLB.ForeColor = Color.Red;
                BmiLB.Visible = true;
                KuvausLB.Text = "Huomattava ylipaino";
                KuvausLB.ForeColor = Color.Red;
                KuvausLB.Visible = true;
            }
        }
    }
}