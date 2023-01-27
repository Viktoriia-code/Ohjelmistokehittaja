namespace Harjoitus3
{
    public partial class Harjoitus3 : Form
    {
        public Harjoitus3()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double luku1 = double.Parse(LukuYksiTB.Text);
            double luku2 = double.Parse(LukuKaksiTB.Text);
            double vastaus = 0;
            string merkki = LaskutoimitusCB.Text;
            switch (merkki)
            {
                case "+":
		            vastaus = luku1 + luku2;
                    break;
                case "-":
                    vastaus = luku1 - luku2;
                    break;
                case "*":
                    vastaus = luku1 * luku2;
                    break;
                case "/":
                    vastaus = luku1 / luku2;
                    break;
                default:
                    VastausLB.Text = "Tapahtui virhe";
                    break;
            }
            VastausLB.Text = Convert.ToString(vastaus);
            VastausLB.Visible = true;
        }
    }
}