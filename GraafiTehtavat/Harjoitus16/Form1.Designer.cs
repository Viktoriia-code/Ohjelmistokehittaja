namespace Harjoitus16
{
    partial class CountDownForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MinutesCB = new System.Windows.Forms.ComboBox();
            this.SecondsCB = new System.Windows.Forms.ComboBox();
            this.TimeLB = new System.Windows.Forms.Label();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.CountDownTimerTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minuutit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sekunnit:";
            // 
            // MinutesCB
            // 
            this.MinutesCB.FormattingEnabled = true;
            this.MinutesCB.Location = new System.Drawing.Point(12, 60);
            this.MinutesCB.Name = "MinutesCB";
            this.MinutesCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MinutesCB.Size = new System.Drawing.Size(105, 37);
            this.MinutesCB.TabIndex = 2;
            // 
            // SecondsCB
            // 
            this.SecondsCB.FormattingEnabled = true;
            this.SecondsCB.Location = new System.Drawing.Point(171, 60);
            this.SecondsCB.Name = "SecondsCB";
            this.SecondsCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SecondsCB.Size = new System.Drawing.Size(105, 37);
            this.SecondsCB.TabIndex = 3;
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLB.Location = new System.Drawing.Point(46, 112);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(196, 77);
            this.TimeLB.TabIndex = 4;
            this.TimeLB.Text = "00:00";
            // 
            // StartBT
            // 
            this.StartBT.BackColor = System.Drawing.Color.YellowGreen;
            this.StartBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBT.Location = new System.Drawing.Point(12, 207);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(122, 43);
            this.StartBT.TabIndex = 5;
            this.StartBT.Text = "START";
            this.StartBT.UseVisualStyleBackColor = false;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.BackColor = System.Drawing.Color.Tomato;
            this.StopBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopBT.Location = new System.Drawing.Point(154, 207);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(122, 43);
            this.StopBT.TabIndex = 6;
            this.StopBT.Text = "STOP";
            this.StopBT.UseVisualStyleBackColor = false;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // CountDownTimerTM
            // 
            this.CountDownTimerTM.Interval = 1000;
            this.CountDownTimerTM.Tick += new System.EventHandler(this.CountDownTimerTM_Tick);
            // 
            // CountDownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 277);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.SecondsCB);
            this.Controls.Add(this.MinutesCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CountDownForm";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.CountDownForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox MinutesCB;
        private ComboBox SecondsCB;
        private Label TimeLB;
        private Button StartBT;
        private Button StopBT;
        private System.Windows.Forms.Timer CountDownTimerTM;
    }
}