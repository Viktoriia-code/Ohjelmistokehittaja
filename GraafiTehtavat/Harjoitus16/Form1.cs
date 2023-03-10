using System;
using System.Windows.Forms;

namespace Harjoitus16
{
    public partial class CountDownForm : System.Windows.Forms.Form
    {
        private int kokonaisaika;
        public CountDownForm()
        {
            InitializeComponent();
        }

        private void CountDownForm_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false;
            for (int i = 0; i < 60; i++)
            {
                MinutesCB.Items.Add(i.ToString());
                SecondsCB.Items.Add(i.ToString());
            }
            MinutesCB.SelectedIndex = 0;
            SecondsCB.SelectedIndex = 10;
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false;
            StopBT.Enabled = true;
            TimeLB.Enabled = true;
            int minutes = int.Parse(MinutesCB.SelectedItem.ToString());
            int seconds = int.Parse(SecondsCB.SelectedItem.ToString());
            kokonaisaika = (minutes * 60) + seconds;
            CountDownTimerTM.Enabled = true;
            string mins = String.Format("{0,2:D2}", minutes);
            string secs = String.Format("{0,2:D2}", seconds);
            TimeLB.Text = mins + ":" + secs;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true;
            StopBT.Enabled = false;
            kokonaisaika = 0;
            CountDownTimerTM.Enabled = false;
            TimeLB.Enabled = false;
            TimeLB.Text = "00:00";
        }

        private void CountDownTimerTM_Tick(object sender, EventArgs e)
        {
            if (kokonaisaika > 0)
            {
                kokonaisaika--;
                int minutes = kokonaisaika / 60;
                int seconds = kokonaisaika - (minutes * 60);
                string mins = String.Format("{0,2:D2}", minutes);
                string secs = String.Format("{0,2:D2}", seconds);
                TimeLB.Text = mins + ":" + secs;
            }
            else
            {
                CountDownTimerTM.Stop();
                MessageBox.Show("Aikasi loppui!");
                StopBT_Click(sender,e);
            }
        }
    }
}