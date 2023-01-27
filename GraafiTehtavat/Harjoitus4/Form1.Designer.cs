namespace Harjoitus4
{
    partial class Harjoitus4
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
            this.synttariDT = new System.Windows.Forms.DateTimePicker();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.VuosinaLB = new System.Windows.Forms.Label();
            this.KuukausinaLB = new System.Windows.Forms.Label();
            this.PaivinaLB = new System.Windows.Forms.Label();
            this.TunteinaLB = new System.Windows.Forms.Label();
            this.MinuutteinaLB = new System.Windows.Forms.Label();
            this.SekunteinaLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // synttariDT
            // 
            this.synttariDT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.synttariDT.Location = new System.Drawing.Point(21, 87);
            this.synttariDT.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.synttariDT.Name = "synttariDT";
            this.synttariDT.Size = new System.Drawing.Size(345, 35);
            this.synttariDT.TabIndex = 0;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Location = new System.Drawing.Point(415, 83);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(138, 46);
            this.LaskeBT.TabIndex = 1;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // VuosinaLB
            // 
            this.VuosinaLB.AutoSize = true;
            this.VuosinaLB.BackColor = System.Drawing.Color.Red;
            this.VuosinaLB.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VuosinaLB.Location = new System.Drawing.Point(21, 169);
            this.VuosinaLB.Name = "VuosinaLB";
            this.VuosinaLB.Size = new System.Drawing.Size(108, 33);
            this.VuosinaLB.TabIndex = 2;
            this.VuosinaLB.Text = "X vuotta";
            this.VuosinaLB.Visible = false;
            // 
            // KuukausinaLB
            // 
            this.KuukausinaLB.AutoSize = true;
            this.KuukausinaLB.BackColor = System.Drawing.Color.OrangeRed;
            this.KuukausinaLB.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KuukausinaLB.Location = new System.Drawing.Point(21, 229);
            this.KuukausinaLB.Name = "KuukausinaLB";
            this.KuukausinaLB.Size = new System.Drawing.Size(147, 33);
            this.KuukausinaLB.TabIndex = 3;
            this.KuukausinaLB.Text = "X kuukautta";
            this.KuukausinaLB.Visible = false;
            // 
            // PaivinaLB
            // 
            this.PaivinaLB.AutoSize = true;
            this.PaivinaLB.BackColor = System.Drawing.Color.Yellow;
            this.PaivinaLB.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PaivinaLB.Location = new System.Drawing.Point(21, 290);
            this.PaivinaLB.Name = "PaivinaLB";
            this.PaivinaLB.Size = new System.Drawing.Size(107, 33);
            this.PaivinaLB.TabIndex = 4;
            this.PaivinaLB.Text = "X päivää";
            this.PaivinaLB.Visible = false;
            // 
            // TunteinaLB
            // 
            this.TunteinaLB.AutoSize = true;
            this.TunteinaLB.BackColor = System.Drawing.Color.LimeGreen;
            this.TunteinaLB.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TunteinaLB.Location = new System.Drawing.Point(307, 169);
            this.TunteinaLB.Name = "TunteinaLB";
            this.TunteinaLB.Size = new System.Drawing.Size(107, 33);
            this.TunteinaLB.TabIndex = 5;
            this.TunteinaLB.Text = "X päivää";
            this.TunteinaLB.Visible = false;
            // 
            // MinuutteinaLB
            // 
            this.MinuutteinaLB.AutoSize = true;
            this.MinuutteinaLB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MinuutteinaLB.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinuutteinaLB.Location = new System.Drawing.Point(307, 229);
            this.MinuutteinaLB.Name = "MinuutteinaLB";
            this.MinuutteinaLB.Size = new System.Drawing.Size(140, 33);
            this.MinuutteinaLB.TabIndex = 6;
            this.MinuutteinaLB.Text = "X minuuttia";
            this.MinuutteinaLB.Visible = false;
            // 
            // SekunteinaLB
            // 
            this.SekunteinaLB.AutoSize = true;
            this.SekunteinaLB.BackColor = System.Drawing.Color.RoyalBlue;
            this.SekunteinaLB.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SekunteinaLB.Location = new System.Drawing.Point(307, 290);
            this.SekunteinaLB.Name = "SekunteinaLB";
            this.SekunteinaLB.Size = new System.Drawing.Size(132, 33);
            this.SekunteinaLB.TabIndex = 7;
            this.SekunteinaLB.Text = "X sekuntia";
            this.SekunteinaLB.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(192, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Iän laskeminen";
            // 
            // Harjoitus4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SekunteinaLB);
            this.Controls.Add(this.MinuutteinaLB);
            this.Controls.Add(this.TunteinaLB);
            this.Controls.Add(this.PaivinaLB);
            this.Controls.Add(this.KuukausinaLB);
            this.Controls.Add(this.VuosinaLB);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.synttariDT);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Harjoitus4";
            this.Text = "Harjoitus 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker synttariDT;
        private Button LaskeBT;
        private Label VuosinaLB;
        private Label KuukausinaLB;
        private Label PaivinaLB;
        private Label TunteinaLB;
        private Label MinuutteinaLB;
        private Label SekunteinaLB;
        private Label label1;
    }
}