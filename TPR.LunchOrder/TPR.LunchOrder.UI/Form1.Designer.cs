namespace TPR.LunchOrder.UI
{
    partial class frmOrder
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
            this.grpCourse = new System.Windows.Forms.GroupBox();
            this.rdoSalad = new System.Windows.Forms.RadioButton();
            this.rdoPizza = new System.Windows.Forms.RadioButton();
            this.rdoHambuger = new System.Windows.Forms.RadioButton();
            this.grpAddOns = new System.Windows.Forms.GroupBox();
            this.chkAddOn3 = new System.Windows.Forms.CheckBox();
            this.chkAddOn2 = new System.Windows.Forms.CheckBox();
            this.chkAddon1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnPlace = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpCourse.SuspendLayout();
            this.grpAddOns.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCourse
            // 
            this.grpCourse.Controls.Add(this.rdoSalad);
            this.grpCourse.Controls.Add(this.rdoPizza);
            this.grpCourse.Controls.Add(this.rdoHambuger);
            this.grpCourse.Location = new System.Drawing.Point(12, 29);
            this.grpCourse.Name = "grpCourse";
            this.grpCourse.Size = new System.Drawing.Size(227, 100);
            this.grpCourse.TabIndex = 0;
            this.grpCourse.TabStop = false;
            this.grpCourse.Text = "Main Course";
            // 
            // rdoSalad
            // 
            this.rdoSalad.AutoSize = true;
            this.rdoSalad.Location = new System.Drawing.Point(6, 67);
            this.rdoSalad.Name = "rdoSalad";
            this.rdoSalad.Size = new System.Drawing.Size(88, 17);
            this.rdoSalad.TabIndex = 2;
            this.rdoSalad.Text = "Salad - $4.95";
            this.rdoSalad.UseVisualStyleBackColor = true;
            this.rdoSalad.CheckedChanged += new System.EventHandler(this.rdoSalad_CheckedChanged);
            // 
            // rdoPizza
            // 
            this.rdoPizza.AutoSize = true;
            this.rdoPizza.Location = new System.Drawing.Point(7, 44);
            this.rdoPizza.Name = "rdoPizza";
            this.rdoPizza.Size = new System.Drawing.Size(86, 17);
            this.rdoPizza.TabIndex = 1;
            this.rdoPizza.Text = "Pizza- $ 5.95";
            this.rdoPizza.UseVisualStyleBackColor = true;
            this.rdoPizza.CheckedChanged += new System.EventHandler(this.rdoPizza_CheckedChanged);
            // 
            // rdoHambuger
            // 
            this.rdoHambuger.AutoSize = true;
            this.rdoHambuger.Location = new System.Drawing.Point(7, 20);
            this.rdoHambuger.Name = "rdoHambuger";
            this.rdoHambuger.Size = new System.Drawing.Size(107, 17);
            this.rdoHambuger.TabIndex = 0;
            this.rdoHambuger.Text = "Hamburger-$6.95";
            this.rdoHambuger.UseVisualStyleBackColor = true;
            this.rdoHambuger.CheckedChanged += new System.EventHandler(this.rdoHambuger_CheckedChanged);
            // 
            // grpAddOns
            // 
            this.grpAddOns.Controls.Add(this.chkAddOn3);
            this.grpAddOns.Controls.Add(this.chkAddOn2);
            this.grpAddOns.Controls.Add(this.chkAddon1);
            this.grpAddOns.Location = new System.Drawing.Point(314, 29);
            this.grpAddOns.Name = "grpAddOns";
            this.grpAddOns.Size = new System.Drawing.Size(260, 100);
            this.grpAddOns.TabIndex = 1;
            this.grpAddOns.TabStop = false;
            this.grpAddOns.Text = "Add-On Items ($.75/each)";
            // 
            // chkAddOn3
            // 
            this.chkAddOn3.AutoSize = true;
            this.chkAddOn3.Location = new System.Drawing.Point(7, 71);
            this.chkAddOn3.Name = "chkAddOn3";
            this.chkAddOn3.Size = new System.Drawing.Size(84, 17);
            this.chkAddOn3.TabIndex = 2;
            this.chkAddOn3.Text = "French Fries";
            this.chkAddOn3.UseVisualStyleBackColor = true;
            this.chkAddOn3.CheckedChanged += new System.EventHandler(this.chkAddOn3_CheckedChanged);
            // 
            // chkAddOn2
            // 
            this.chkAddOn2.AutoSize = true;
            this.chkAddOn2.Location = new System.Drawing.Point(7, 47);
            this.chkAddOn2.Name = "chkAddOn2";
            this.chkAddOn2.Size = new System.Drawing.Size(163, 17);
            this.chkAddOn2.TabIndex = 1;
            this.chkAddOn2.Text = "Ketchup, Mustard, and Mayo";
            this.chkAddOn2.UseVisualStyleBackColor = true;
            this.chkAddOn2.CheckedChanged += new System.EventHandler(this.chkAddOn2_CheckedChanged);
            // 
            // chkAddon1
            // 
            this.chkAddon1.AutoSize = true;
            this.chkAddon1.Location = new System.Drawing.Point(7, 27);
            this.chkAddon1.Name = "chkAddon1";
            this.chkAddon1.Size = new System.Drawing.Size(167, 17);
            this.chkAddon1.TabIndex = 0;
            this.chkAddon1.Text = "Lettuce, Tomator, and Onions";
            this.chkAddon1.UseVisualStyleBackColor = true;
            this.chkAddon1.CheckedChanged += new System.EventHandler(this.chkAddon1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.txtTax);
            this.groupBox3.Controls.Add(this.txtSubtotal);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.lblTax);
            this.groupBox3.Controls.Add(this.lblSubtotal);
            this.groupBox3.Location = new System.Drawing.Point(13, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 199);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(104, 80);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // txtTax
            // 
            this.txtTax.Enabled = false;
            this.txtTax.Location = new System.Drawing.Point(104, 51);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 4;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(103, 20);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(7, 88);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Order Total";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(6, 58);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(66, 13);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax (7.75%):";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(7, 20);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // btnPlace
            // 
            this.btnPlace.Enabled = false;
            this.btnPlace.Location = new System.Drawing.Point(499, 155);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(75, 23);
            this.btnPlace.TabIndex = 3;
            this.btnPlace.Text = "Place Order";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(503, 216);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 364);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlace);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpAddOns);
            this.Controls.Add(this.grpCourse);
            this.Name = "frmOrder";
            this.Text = "Lunch Order";
            this.grpCourse.ResumeLayout(false);
            this.grpCourse.PerformLayout();
            this.grpAddOns.ResumeLayout(false);
            this.grpAddOns.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCourse;
        private System.Windows.Forms.RadioButton rdoSalad;
        private System.Windows.Forms.RadioButton rdoPizza;
        private System.Windows.Forms.RadioButton rdoHambuger;
        private System.Windows.Forms.GroupBox grpAddOns;
        private System.Windows.Forms.CheckBox chkAddOn3;
        private System.Windows.Forms.CheckBox chkAddOn2;
        private System.Windows.Forms.CheckBox chkAddon1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Button btnExit;
    }
}

