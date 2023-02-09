namespace Harjoitus14
{
    partial class DiaryForm
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
            this.NoteTB = new System.Windows.Forms.TextBox();
            this.SaveBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoteTB
            // 
            this.NoteTB.Location = new System.Drawing.Point(12, 53);
            this.NoteTB.Multiline = true;
            this.NoteTB.Name = "NoteTB";
            this.NoteTB.Size = new System.Drawing.Size(504, 295);
            this.NoteTB.TabIndex = 0;
            // 
            // SaveBT
            // 
            this.SaveBT.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.SaveBT.Location = new System.Drawing.Point(12, 354);
            this.SaveBT.Name = "SaveBT";
            this.SaveBT.Size = new System.Drawing.Size(504, 48);
            this.SaveBT.TabIndex = 1;
            this.SaveBT.Text = "Tallenna päiväkirjaan";
            this.SaveBT.UseVisualStyleBackColor = false;
            this.SaveBT.Click += new System.EventHandler(this.SaveBT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Memory Notes ~";
            // 
            // DiaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 414);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveBT);
            this.Controls.Add(this.NoteTB);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DiaryForm";
            this.Text = "Päiväkirja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NoteTB;
        private Button SaveBT;
        private Label label2;
    }
}