namespace TPR.Banking.UI
{
    partial class frmBanking
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
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.grpCustomers = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblDisplayAge = new System.Windows.Forms.Label();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dgdDeposits = new System.Windows.Forms.DataGridView();
            this.lbDeposit = new System.Windows.Forms.Label();
            this.lblWithDrawel = new System.Windows.Forms.Label();
            this.dgdWithdrawl = new System.Windows.Forms.DataGridView();
            this.btnSaveXML = new System.Windows.Forms.Button();
            this.btnLoadXML = new System.Windows.Forms.Button();
            this.grpCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDeposits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdWithdrawl)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(12, 12);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(120, 225);
            this.lstCustomers.TabIndex = 0;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // grpCustomers
            // 
            this.grpCustomers.Controls.Add(this.btnDelete);
            this.grpCustomers.Controls.Add(this.btnUpdate);
            this.grpCustomers.Controls.Add(this.btnNew);
            this.grpCustomers.Controls.Add(this.lblDisplayAge);
            this.grpCustomers.Controls.Add(this.dtpBirthdate);
            this.grpCustomers.Controls.Add(this.txtSSN);
            this.grpCustomers.Controls.Add(this.txtLastName);
            this.grpCustomers.Controls.Add(this.txtFirstName);
            this.grpCustomers.Controls.Add(this.lblAge);
            this.grpCustomers.Controls.Add(this.lblBirthDate);
            this.grpCustomers.Controls.Add(this.lblSSN);
            this.grpCustomers.Controls.Add(this.lblLastName);
            this.grpCustomers.Controls.Add(this.lblFirstName);
            this.grpCustomers.Controls.Add(this.lblCustomerID);
            this.grpCustomers.Controls.Add(this.lblID);
            this.grpCustomers.Location = new System.Drawing.Point(248, 12);
            this.grpCustomers.Name = "grpCustomers";
            this.grpCustomers.Size = new System.Drawing.Size(272, 225);
            this.grpCustomers.TabIndex = 1;
            this.grpCustomers.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(186, 178);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(105, 178);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(9, 178);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblDisplayAge
            // 
            this.lblDisplayAge.AutoSize = true;
            this.lblDisplayAge.Location = new System.Drawing.Point(102, 153);
            this.lblDisplayAge.Name = "lblDisplayAge";
            this.lblDisplayAge.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayAge.TabIndex = 11;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdate.Location = new System.Drawing.Point(105, 125);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(100, 20);
            this.dtpBirthdate.TabIndex = 10;
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(105, 99);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(100, 20);
            this.txtSSN.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(105, 72);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(105, 37);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 7;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(6, 153);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(6, 125);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 5;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(6, 99);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(32, 13);
            this.lblSSN.TabIndex = 4;
            this.lblSSN.Text = "SSN:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 72);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 45);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(102, 16);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // dgdDeposits
            // 
            this.dgdDeposits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdDeposits.Location = new System.Drawing.Point(12, 270);
            this.dgdDeposits.Name = "dgdDeposits";
            this.dgdDeposits.Size = new System.Drawing.Size(526, 124);
            this.dgdDeposits.TabIndex = 2;
            // 
            // lbDeposit
            // 
            this.lbDeposit.AutoSize = true;
            this.lbDeposit.Location = new System.Drawing.Point(37, 251);
            this.lbDeposit.Name = "lbDeposit";
            this.lbDeposit.Size = new System.Drawing.Size(51, 13);
            this.lbDeposit.TabIndex = 3;
            this.lbDeposit.Text = "Deposits:";
            // 
            // lblWithDrawel
            // 
            this.lblWithDrawel.AutoSize = true;
            this.lblWithDrawel.Location = new System.Drawing.Point(37, 409);
            this.lblWithDrawel.Name = "lblWithDrawel";
            this.lblWithDrawel.Size = new System.Drawing.Size(68, 13);
            this.lblWithDrawel.TabIndex = 5;
            this.lblWithDrawel.Text = "Withdrawals:";
            // 
            // dgdWithdrawl
            // 
            this.dgdWithdrawl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdWithdrawl.Location = new System.Drawing.Point(12, 428);
            this.dgdWithdrawl.Name = "dgdWithdrawl";
            this.dgdWithdrawl.Size = new System.Drawing.Size(526, 124);
            this.dgdWithdrawl.TabIndex = 4;
            // 
            // btnSaveXML
            // 
            this.btnSaveXML.Location = new System.Drawing.Point(13, 563);
            this.btnSaveXML.Name = "btnSaveXML";
            this.btnSaveXML.Size = new System.Drawing.Size(119, 23);
            this.btnSaveXML.TabIndex = 12;
            this.btnSaveXML.Text = "Save to XML";
            this.btnSaveXML.UseVisualStyleBackColor = true;
            this.btnSaveXML.Click += new System.EventHandler(this.btnSaveXML_Click);
            // 
            // btnLoadXML
            // 
            this.btnLoadXML.Location = new System.Drawing.Point(154, 563);
            this.btnLoadXML.Name = "btnLoadXML";
            this.btnLoadXML.Size = new System.Drawing.Size(132, 23);
            this.btnLoadXML.TabIndex = 12;
            this.btnLoadXML.Text = "Load from XML";
            this.btnLoadXML.UseVisualStyleBackColor = true;
            this.btnLoadXML.Click += new System.EventHandler(this.btnLoadXML_Click);
            // 
            // frmBanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 598);
            this.Controls.Add(this.lblWithDrawel);
            this.Controls.Add(this.dgdWithdrawl);
            this.Controls.Add(this.btnLoadXML);
            this.Controls.Add(this.btnSaveXML);
            this.Controls.Add(this.lbDeposit);
            this.Controls.Add(this.dgdDeposits);
            this.Controls.Add(this.grpCustomers);
            this.Controls.Add(this.lstCustomers);
            this.Name = "frmBanking";
            this.Text = "Banking";
            this.Load += new System.EventHandler(this.frmBanking_Load);
            this.grpCustomers.ResumeLayout(false);
            this.grpCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDeposits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdWithdrawl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.GroupBox grpCustomers;
        private System.Windows.Forms.Label lblDisplayAge;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dgdDeposits;
        private System.Windows.Forms.Label lbDeposit;
        private System.Windows.Forms.Label lblWithDrawel;
        private System.Windows.Forms.DataGridView dgdWithdrawl;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSaveXML;
        private System.Windows.Forms.Button btnLoadXML;
    }
}

