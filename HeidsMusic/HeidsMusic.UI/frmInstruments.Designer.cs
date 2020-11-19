namespace HeidsMusic.Presentation
{
    partial class frmInstruments
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearBrass = new System.Windows.Forms.Button();
            this.btnFillBrass = new System.Windows.Forms.Button();
            this.btnSaveBrass = new System.Windows.Forms.Button();
            this.dgvBrass = new System.Windows.Forms.DataGridView();
            this.btnLoadBrass = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearWoodwinds = new System.Windows.Forms.Button();
            this.btnFillWoodwinds = new System.Windows.Forms.Button();
            this.btnSaveWoodwinds = new System.Windows.Forms.Button();
            this.dgvWoodwinds = new System.Windows.Forms.DataGridView();
            this.btnLoadWoodwinds = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrass)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWoodwinds)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearBrass);
            this.groupBox1.Controls.Add(this.btnFillBrass);
            this.groupBox1.Controls.Add(this.btnSaveBrass);
            this.groupBox1.Controls.Add(this.dgvBrass);
            this.groupBox1.Controls.Add(this.btnLoadBrass);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 190);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brass Instruments";
            // 
            // btnClearBrass
            // 
            this.btnClearBrass.Location = new System.Drawing.Point(6, 78);
            this.btnClearBrass.Name = "btnClearBrass";
            this.btnClearBrass.Size = new System.Drawing.Size(75, 23);
            this.btnClearBrass.TabIndex = 8;
            this.btnClearBrass.Text = "Clear";
            this.btnClearBrass.UseVisualStyleBackColor = true;
            this.btnClearBrass.Click += new System.EventHandler(this.btnClearBrass_Click);
            // 
            // btnFillBrass
            // 
            this.btnFillBrass.Location = new System.Drawing.Point(6, 20);
            this.btnFillBrass.Name = "btnFillBrass";
            this.btnFillBrass.Size = new System.Drawing.Size(75, 23);
            this.btnFillBrass.TabIndex = 7;
            this.btnFillBrass.Text = "Fill";
            this.btnFillBrass.UseVisualStyleBackColor = true;
            this.btnFillBrass.Click += new System.EventHandler(this.btnFillBrass_Click);
            // 
            // btnSaveBrass
            // 
            this.btnSaveBrass.Location = new System.Drawing.Point(6, 49);
            this.btnSaveBrass.Name = "btnSaveBrass";
            this.btnSaveBrass.Size = new System.Drawing.Size(75, 23);
            this.btnSaveBrass.TabIndex = 6;
            this.btnSaveBrass.Text = "Save";
            this.btnSaveBrass.UseVisualStyleBackColor = true;
            this.btnSaveBrass.Click += new System.EventHandler(this.btnSaveBrass_Click);
            // 
            // dgvBrass
            // 
            this.dgvBrass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrass.Location = new System.Drawing.Point(105, 20);
            this.dgvBrass.Name = "dgvBrass";
            this.dgvBrass.Size = new System.Drawing.Size(700, 150);
            this.dgvBrass.TabIndex = 5;
            // 
            // btnLoadBrass
            // 
            this.btnLoadBrass.Location = new System.Drawing.Point(6, 107);
            this.btnLoadBrass.Name = "btnLoadBrass";
            this.btnLoadBrass.Size = new System.Drawing.Size(75, 23);
            this.btnLoadBrass.TabIndex = 4;
            this.btnLoadBrass.Text = "Load";
            this.btnLoadBrass.UseVisualStyleBackColor = true;
            this.btnLoadBrass.Click += new System.EventHandler(this.btnLoadBrass_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearWoodwinds);
            this.groupBox2.Controls.Add(this.btnFillWoodwinds);
            this.groupBox2.Controls.Add(this.btnSaveWoodwinds);
            this.groupBox2.Controls.Add(this.dgvWoodwinds);
            this.groupBox2.Controls.Add(this.btnLoadWoodwinds);
            this.groupBox2.Location = new System.Drawing.Point(6, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(805, 202);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Woodwind Instruments";
            // 
            // btnClearWoodwinds
            // 
            this.btnClearWoodwinds.Location = new System.Drawing.Point(6, 77);
            this.btnClearWoodwinds.Name = "btnClearWoodwinds";
            this.btnClearWoodwinds.Size = new System.Drawing.Size(75, 23);
            this.btnClearWoodwinds.TabIndex = 9;
            this.btnClearWoodwinds.Text = "Clear";
            this.btnClearWoodwinds.UseVisualStyleBackColor = true;
            this.btnClearWoodwinds.Click += new System.EventHandler(this.btnClearWoodwinds_Click);
            // 
            // btnFillWoodwinds
            // 
            this.btnFillWoodwinds.Location = new System.Drawing.Point(6, 19);
            this.btnFillWoodwinds.Name = "btnFillWoodwinds";
            this.btnFillWoodwinds.Size = new System.Drawing.Size(75, 23);
            this.btnFillWoodwinds.TabIndex = 11;
            this.btnFillWoodwinds.Text = "Fill";
            this.btnFillWoodwinds.UseVisualStyleBackColor = true;
            this.btnFillWoodwinds.Click += new System.EventHandler(this.btnFillWoodwinds_Click);
            // 
            // btnSaveWoodwinds
            // 
            this.btnSaveWoodwinds.Location = new System.Drawing.Point(6, 48);
            this.btnSaveWoodwinds.Name = "btnSaveWoodwinds";
            this.btnSaveWoodwinds.Size = new System.Drawing.Size(75, 23);
            this.btnSaveWoodwinds.TabIndex = 10;
            this.btnSaveWoodwinds.Text = "Save";
            this.btnSaveWoodwinds.UseVisualStyleBackColor = true;
            this.btnSaveWoodwinds.Click += new System.EventHandler(this.btnSaveWoodwinds_Click);
            // 
            // dgvWoodwinds
            // 
            this.dgvWoodwinds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWoodwinds.Location = new System.Drawing.Point(99, 19);
            this.dgvWoodwinds.Name = "dgvWoodwinds";
            this.dgvWoodwinds.Size = new System.Drawing.Size(700, 150);
            this.dgvWoodwinds.TabIndex = 9;
            // 
            // btnLoadWoodwinds
            // 
            this.btnLoadWoodwinds.Location = new System.Drawing.Point(6, 106);
            this.btnLoadWoodwinds.Name = "btnLoadWoodwinds";
            this.btnLoadWoodwinds.Size = new System.Drawing.Size(75, 23);
            this.btnLoadWoodwinds.TabIndex = 8;
            this.btnLoadWoodwinds.Text = "Load";
            this.btnLoadWoodwinds.UseVisualStyleBackColor = true;
            this.btnLoadWoodwinds.Click += new System.EventHandler(this.btnLoadWoodwinds_Click);
            // 
            // frmInstruments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 437);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmInstruments";
            this.Text = "Instruments";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrass)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWoodwinds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFillBrass;
        private System.Windows.Forms.Button btnSaveBrass;
        private System.Windows.Forms.DataGridView dgvBrass;
        private System.Windows.Forms.Button btnLoadBrass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFillWoodwinds;
        private System.Windows.Forms.Button btnSaveWoodwinds;
        private System.Windows.Forms.DataGridView dgvWoodwinds;
        private System.Windows.Forms.Button btnLoadWoodwinds;
        private System.Windows.Forms.Button btnClearBrass;
        private System.Windows.Forms.Button btnClearWoodwinds;

    }
}

