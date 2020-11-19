namespace TPR.StopWatch.UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.lstLaps = new System.Windows.Forms.ListBox();
            this.btnLaps = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblSplitTimes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(108, 41);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(49, 13);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "00:00:00";
            // 
            // tmrTick
            // 
            this.tmrTick.Interval = 500;
            this.tmrTick.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lstLaps
            // 
            this.lstLaps.FormattingEnabled = true;
            this.lstLaps.Location = new System.Drawing.Point(71, 132);
            this.lstLaps.Name = "lstLaps";
            this.lstLaps.Size = new System.Drawing.Size(120, 95);
            this.lstLaps.TabIndex = 1;
            // 
            // btnLaps
            // 
            this.btnLaps.Location = new System.Drawing.Point(86, 74);
            this.btnLaps.Name = "btnLaps";
            this.btnLaps.Size = new System.Drawing.Size(75, 23);
            this.btnLaps.TabIndex = 2;
            this.btnLaps.Text = "Lap Times";
            this.btnLaps.UseVisualStyleBackColor = true;
            this.btnLaps.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(5, 74);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(187, 74);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblSplitTimes
            // 
            this.lblSplitTimes.AutoSize = true;
            this.lblSplitTimes.Location = new System.Drawing.Point(49, 116);
            this.lblSplitTimes.Name = "lblSplitTimes";
            this.lblSplitTimes.Size = new System.Drawing.Size(0, 13);
            this.lblSplitTimes.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblSplitTimes);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnLaps);
            this.Controls.Add(this.lstLaps);
            this.Controls.Add(this.lblDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Timer tmrTick;
        private System.Windows.Forms.ListBox lstLaps;
        private System.Windows.Forms.Button btnLaps;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblSplitTimes;
    }
}

