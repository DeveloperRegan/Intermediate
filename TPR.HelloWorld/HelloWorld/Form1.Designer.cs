namespace HelloWorld
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
            this.btnWorld = new System.Windows.Forms.Button();
            this.lblWorld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWorld
            // 
            this.btnWorld.Location = new System.Drawing.Point(67, 132);
            this.btnWorld.Name = "btnWorld";
            this.btnWorld.Size = new System.Drawing.Size(75, 23);
            this.btnWorld.TabIndex = 0;
            this.btnWorld.Text = "Click Me";
            this.btnWorld.UseVisualStyleBackColor = true;
            this.btnWorld.Click += new System.EventHandler(this.btnWorld_Click);
            // 
            // lblWorld
            // 
            this.lblWorld.AutoSize = true;
            this.lblWorld.Location = new System.Drawing.Point(67, 72);
            this.lblWorld.Name = "lblWorld";
            this.lblWorld.Size = new System.Drawing.Size(62, 13);
            this.lblWorld.TabIndex = 1;
            this.lblWorld.Text = "Hello World";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblWorld);
            this.Controls.Add(this.btnWorld);
            this.Name = "Form1";
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWorld;
        private System.Windows.Forms.Label lblWorld;
    }
}

