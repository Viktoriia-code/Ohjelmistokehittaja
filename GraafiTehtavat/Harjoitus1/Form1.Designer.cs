namespace TekstiVaihto
{
    partial class Harjoitus1
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
            this.otsikkoLB = new System.Windows.Forms.Label();
            this.vaihdatekstiBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.otsikkoLB.Location = new System.Drawing.Point(39, 24);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(94, 32);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Otsikko";
            // 
            // vaihdatekstiBT
            // 
            this.vaihdatekstiBT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vaihdatekstiBT.Location = new System.Drawing.Point(39, 84);
            this.vaihdatekstiBT.Name = "vaihdatekstiBT";
            this.vaihdatekstiBT.Size = new System.Drawing.Size(156, 65);
            this.vaihdatekstiBT.TabIndex = 1;
            this.vaihdatekstiBT.Text = "Vaihta Teksti";
            this.vaihdatekstiBT.UseVisualStyleBackColor = true;
            this.vaihdatekstiBT.Click += new System.EventHandler(this.vaihdatekstiBT_Click);
            // 
            // Harjoitus1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 187);
            this.Controls.Add(this.vaihdatekstiBT);
            this.Controls.Add(this.otsikkoLB);
            this.Name = "Harjoitus1";
            this.Text = "Harjotus 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label otsikkoLB;
        private Button vaihdatekstiBT;
    }
}