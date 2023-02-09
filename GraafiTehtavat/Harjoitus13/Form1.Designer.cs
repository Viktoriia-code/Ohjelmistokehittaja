namespace Harjoitus13
{
    partial class SuosittuNimi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.NimiTB = new System.Windows.Forms.TextBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.TarkastaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(637, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna nimesi, niin tarkistan, onko se 50 suosittuimman joukossa:";
            // 
            // NimiTB
            // 
            this.NimiTB.Location = new System.Drawing.Point(12, 72);
            this.NimiTB.Name = "NimiTB";
            this.NimiTB.Size = new System.Drawing.Size(166, 31);
            this.NimiTB.TabIndex = 1;
            this.NimiTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NimiTB_KeyDown);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(12, 133);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(82, 23);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "vastaus";
            this.VastausLB.Visible = false;
            // 
            // TarkastaBT
            // 
            this.TarkastaBT.BackColor = System.Drawing.Color.Orange;
            this.TarkastaBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TarkastaBT.Location = new System.Drawing.Point(210, 64);
            this.TarkastaBT.Name = "TarkastaBT";
            this.TarkastaBT.Size = new System.Drawing.Size(129, 44);
            this.TarkastaBT.TabIndex = 3;
            this.TarkastaBT.Text = "Tarkasta";
            this.TarkastaBT.UseVisualStyleBackColor = false;
            this.TarkastaBT.Click += new System.EventHandler(this.TarkastaBT_Click);
            // 
            // SuosittuNimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 188);
            this.Controls.Add(this.TarkastaBT);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.NimiTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SuosittuNimi";
            this.Text = "Onko nimesi suosittujen joukossa?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox NimiTB;
        private Label VastausLB;
        private Button TarkastaBT;
    }
}