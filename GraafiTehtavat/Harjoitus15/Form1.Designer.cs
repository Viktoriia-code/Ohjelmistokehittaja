namespace Harjoitus15
{
    partial class StopWatchForm
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
            this.TimeLB = new System.Windows.Forms.Label();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.ResetBT = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Font = new System.Drawing.Font("Verdana", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLB.Location = new System.Drawing.Point(30, 29);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(544, 88);
            this.TimeLB.TabIndex = 0;
            this.TimeLB.Text = "00:00:00.000";
            // 
            // StartBT
            // 
            this.StartBT.BackColor = System.Drawing.Color.YellowGreen;
            this.StartBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBT.Location = new System.Drawing.Point(30, 149);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(122, 49);
            this.StartBT.TabIndex = 1;
            this.StartBT.Text = "START";
            this.StartBT.UseVisualStyleBackColor = false;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.BackColor = System.Drawing.Color.Tomato;
            this.StopBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopBT.Location = new System.Drawing.Point(233, 149);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(122, 49);
            this.StopBT.TabIndex = 2;
            this.StopBT.Text = "STOP";
            this.StopBT.UseVisualStyleBackColor = false;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // ResetBT
            // 
            this.ResetBT.Location = new System.Drawing.Point(443, 149);
            this.ResetBT.Name = "ResetBT";
            this.ResetBT.Size = new System.Drawing.Size(122, 49);
            this.ResetBT.TabIndex = 3;
            this.ResetBT.Text = "RESET";
            this.ResetBT.UseVisualStyleBackColor = true;
            this.ResetBT.Click += new System.EventHandler(this.ResetBT_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StopWatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 236);
            this.Controls.Add(this.ResetBT);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.TimeLB);
            this.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "StopWatchForm";
            this.Text = "Stopwatch";
            this.Load += new System.EventHandler(this.StopWatchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TimeLB;
        private Button StartBT;
        private Button StopBT;
        private Button ResetBT;
        private System.Windows.Forms.Timer timer1;
    }
}