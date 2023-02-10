using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Harjoitus15
{
    public partial class StopWatchForm : Form
    {
        private Stopwatch stopWatch;
        public StopWatchForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", stopWatch.Elapsed);
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }

        private void StopWatchForm_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }
    }
}