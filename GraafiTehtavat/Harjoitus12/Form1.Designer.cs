namespace Harjoitus12
{
    partial class Kysymys10
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
            this.KysymysLB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Vastaus4RB = new System.Windows.Forms.RadioButton();
            this.Vastaus3RB = new System.Windows.Forms.RadioButton();
            this.Vastaus2RB = new System.Windows.Forms.RadioButton();
            this.Vastaus1RB = new System.Windows.Forms.RadioButton();
            this.VastausLB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KysymysLB
            // 
            this.KysymysLB.AutoSize = true;
            this.KysymysLB.Location = new System.Drawing.Point(25, 53);
            this.KysymysLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.KysymysLB.Name = "KysymysLB";
            this.KysymysLB.Size = new System.Drawing.Size(212, 25);
            this.KysymysLB.TabIndex = 0;
            this.KysymysLB.Text = "Vastaus 1. kysymykseen:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Vastaus4RB);
            this.groupBox1.Controls.Add(this.Vastaus3RB);
            this.groupBox1.Controls.Add(this.Vastaus2RB);
            this.groupBox1.Controls.Add(this.Vastaus1RB);
            this.groupBox1.Location = new System.Drawing.Point(283, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vastaus";
            // 
            // Vastaus4RB
            // 
            this.Vastaus4RB.AutoSize = true;
            this.Vastaus4RB.Location = new System.Drawing.Point(19, 141);
            this.Vastaus4RB.Name = "Vastaus4RB";
            this.Vastaus4RB.Size = new System.Drawing.Size(43, 29);
            this.Vastaus4RB.TabIndex = 3;
            this.Vastaus4RB.Text = "D";
            this.Vastaus4RB.UseVisualStyleBackColor = true;
            // 
            // Vastaus3RB
            // 
            this.Vastaus3RB.AutoSize = true;
            this.Vastaus3RB.Location = new System.Drawing.Point(19, 106);
            this.Vastaus3RB.Name = "Vastaus3RB";
            this.Vastaus3RB.Size = new System.Drawing.Size(42, 29);
            this.Vastaus3RB.TabIndex = 2;
            this.Vastaus3RB.Text = "C";
            this.Vastaus3RB.UseVisualStyleBackColor = true;
            // 
            // Vastaus2RB
            // 
            this.Vastaus2RB.AutoSize = true;
            this.Vastaus2RB.Location = new System.Drawing.Point(19, 71);
            this.Vastaus2RB.Name = "Vastaus2RB";
            this.Vastaus2RB.Size = new System.Drawing.Size(41, 29);
            this.Vastaus2RB.TabIndex = 1;
            this.Vastaus2RB.Text = "B";
            this.Vastaus2RB.UseVisualStyleBackColor = true;
            // 
            // Vastaus1RB
            // 
            this.Vastaus1RB.AutoSize = true;
            this.Vastaus1RB.Location = new System.Drawing.Point(19, 36);
            this.Vastaus1RB.Name = "Vastaus1RB";
            this.Vastaus1RB.Size = new System.Drawing.Size(42, 29);
            this.Vastaus1RB.TabIndex = 0;
            this.Vastaus1RB.Text = "A";
            this.Vastaus1RB.UseVisualStyleBackColor = true;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(25, 192);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(76, 25);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // Kysymys10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 258);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.KysymysLB);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Kysymys10";
            this.Text = "10 kysymystä";
            this.Load += new System.EventHandler(this.Kysymys10_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label KysymysLB;
        private GroupBox groupBox1;
        private RadioButton Vastaus4RB;
        private RadioButton Vastaus3RB;
        private RadioButton Vastaus2RB;
        private RadioButton Vastaus1RB;
        private Label VastausLB;
    }
}