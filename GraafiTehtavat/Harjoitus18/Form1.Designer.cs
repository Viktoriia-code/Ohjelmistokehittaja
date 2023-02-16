namespace Harjoitus18
{
    partial class AvainhenkilotForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SchoolCB = new System.Windows.Forms.ComboBox();
            this.PersonCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SchoolAddressLB = new System.Windows.Forms.Label();
            this.SchoolIndexLB = new System.Windows.Forms.Label();
            this.SchoolCityLB = new System.Windows.Forms.Label();
            this.SchoolPhoneLB = new System.Windows.Forms.Label();
            this.PersonPhoneLB = new System.Windows.Forms.Label();
            this.PersonEmailLB = new System.Windows.Forms.Label();
            this.PersonDepartmentLB = new System.Windows.Forms.Label();
            this.PersonTitleLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oppilaitosten avainhenkilöt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valitse oppilaitos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(321, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valitse vastuuhenkilö:";
            // 
            // SchoolCB
            // 
            this.SchoolCB.FormattingEnabled = true;
            this.SchoolCB.Location = new System.Drawing.Point(39, 166);
            this.SchoolCB.Name = "SchoolCB";
            this.SchoolCB.Size = new System.Drawing.Size(179, 32);
            this.SchoolCB.TabIndex = 3;
            this.SchoolCB.SelectedIndexChanged += new System.EventHandler(this.SchoolCB_SelectedIndexChanged);
            // 
            // PersonCB
            // 
            this.PersonCB.FormattingEnabled = true;
            this.PersonCB.Location = new System.Drawing.Point(321, 166);
            this.PersonCB.Name = "PersonCB";
            this.PersonCB.Size = new System.Drawing.Size(179, 32);
            this.PersonCB.TabIndex = 4;
            this.PersonCB.TextChanged += new System.EventHandler(this.PersonCB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(344, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Viktoriia Beloborodova | Keuda, 16.2.2023";
            // 
            // SchoolAddressLB
            // 
            this.SchoolAddressLB.AutoSize = true;
            this.SchoolAddressLB.Location = new System.Drawing.Point(39, 220);
            this.SchoolAddressLB.Name = "SchoolAddressLB";
            this.SchoolAddressLB.Size = new System.Drawing.Size(72, 24);
            this.SchoolAddressLB.TabIndex = 6;
            this.SchoolAddressLB.Text = "Osoite";
            // 
            // SchoolIndexLB
            // 
            this.SchoolIndexLB.AutoSize = true;
            this.SchoolIndexLB.Location = new System.Drawing.Point(39, 266);
            this.SchoolIndexLB.Name = "SchoolIndexLB";
            this.SchoolIndexLB.Size = new System.Drawing.Size(127, 24);
            this.SchoolIndexLB.TabIndex = 7;
            this.SchoolIndexLB.Text = "Postinumero";
            // 
            // SchoolCityLB
            // 
            this.SchoolCityLB.AutoSize = true;
            this.SchoolCityLB.Location = new System.Drawing.Point(39, 312);
            this.SchoolCityLB.Name = "SchoolCityLB";
            this.SchoolCityLB.Size = new System.Drawing.Size(162, 24);
            this.SchoolCityLB.TabIndex = 8;
            this.SchoolCityLB.Text = "Postitoimipaikka";
            // 
            // SchoolPhoneLB
            // 
            this.SchoolPhoneLB.AutoSize = true;
            this.SchoolPhoneLB.Location = new System.Drawing.Point(39, 358);
            this.SchoolPhoneLB.Name = "SchoolPhoneLB";
            this.SchoolPhoneLB.Size = new System.Drawing.Size(78, 24);
            this.SchoolPhoneLB.TabIndex = 9;
            this.SchoolPhoneLB.Text = "Puhelin";
            // 
            // PersonPhoneLB
            // 
            this.PersonPhoneLB.AutoSize = true;
            this.PersonPhoneLB.Location = new System.Drawing.Point(321, 358);
            this.PersonPhoneLB.Name = "PersonPhoneLB";
            this.PersonPhoneLB.Size = new System.Drawing.Size(78, 24);
            this.PersonPhoneLB.TabIndex = 13;
            this.PersonPhoneLB.Text = "Puhelin";
            // 
            // PersonEmailLB
            // 
            this.PersonEmailLB.AutoSize = true;
            this.PersonEmailLB.Location = new System.Drawing.Point(321, 312);
            this.PersonEmailLB.Name = "PersonEmailLB";
            this.PersonEmailLB.Size = new System.Drawing.Size(114, 24);
            this.PersonEmailLB.TabIndex = 12;
            this.PersonEmailLB.Text = "Sähköposti";
            // 
            // PersonDepartmentLB
            // 
            this.PersonDepartmentLB.AutoSize = true;
            this.PersonDepartmentLB.Location = new System.Drawing.Point(321, 266);
            this.PersonDepartmentLB.Name = "PersonDepartmentLB";
            this.PersonDepartmentLB.Size = new System.Drawing.Size(78, 24);
            this.PersonDepartmentLB.TabIndex = 11;
            this.PersonDepartmentLB.Text = "Osasto";
            // 
            // PersonTitleLB
            // 
            this.PersonTitleLB.AutoSize = true;
            this.PersonTitleLB.Location = new System.Drawing.Point(321, 220);
            this.PersonTitleLB.Name = "PersonTitleLB";
            this.PersonTitleLB.Size = new System.Drawing.Size(59, 24);
            this.PersonTitleLB.TabIndex = 10;
            this.PersonTitleLB.Text = "Titteli";
            // 
            // AvainhenkilotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 516);
            this.Controls.Add(this.PersonPhoneLB);
            this.Controls.Add(this.PersonEmailLB);
            this.Controls.Add(this.PersonDepartmentLB);
            this.Controls.Add(this.PersonTitleLB);
            this.Controls.Add(this.SchoolPhoneLB);
            this.Controls.Add(this.SchoolCityLB);
            this.Controls.Add(this.SchoolIndexLB);
            this.Controls.Add(this.SchoolAddressLB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PersonCB);
            this.Controls.Add(this.SchoolCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AvainhenkilotForm";
            this.Text = "Oppilaitosten avainhenkilöt";
            this.Load += new System.EventHandler(this.AvainhenkilotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox SchoolCB;
        private ComboBox PersonCB;
        private Label label4;
        private Label SchoolAddressLB;
        private Label SchoolIndexLB;
        private Label SchoolCityLB;
        private Label SchoolPhoneLB;
        private Label PersonPhoneLB;
        private Label PersonEmailLB;
        private Label PersonDepartmentLB;
        private Label PersonTitleLB;
    }
}