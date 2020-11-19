namespace TPR.Calculator.UI
{
    partial class frmCalc
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMuliple = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnNegaitveValue = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnRecipicol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Enabled = false;
            this.txtDisplay.Location = new System.Drawing.Point(41, 13);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(211, 20);
            this.txtDisplay.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(53, 56);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(134, 56);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(53, 102);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(31, 23);
            this.btnSeven.TabIndex = 3;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(97, 102);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(31, 23);
            this.btnEight.TabIndex = 4;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(134, 102);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(31, 23);
            this.btnNine.TabIndex = 5;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(174, 102);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(31, 23);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.ChangeMath);
            // 
            // btnMuliple
            // 
            this.btnMuliple.Location = new System.Drawing.Point(174, 131);
            this.btnMuliple.Name = "btnMuliple";
            this.btnMuliple.Size = new System.Drawing.Size(31, 23);
            this.btnMuliple.TabIndex = 10;
            this.btnMuliple.Text = "*";
            this.btnMuliple.UseVisualStyleBackColor = true;
            this.btnMuliple.Click += new System.EventHandler(this.ChangeMath);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(134, 131);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(31, 23);
            this.btnSix.TabIndex = 9;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(97, 131);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(31, 23);
            this.btnFive.TabIndex = 8;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(53, 131);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(31, 23);
            this.btnFour.TabIndex = 7;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(174, 160);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(31, 23);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.ChangeMath);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(134, 160);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(31, 23);
            this.btnThree.TabIndex = 13;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(97, 160);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(31, 23);
            this.btnTwo.TabIndex = 12;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(53, 160);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(31, 23);
            this.btnOne.TabIndex = 11;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(174, 189);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(31, 23);
            this.btnPlus.TabIndex = 18;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.ChangeMath);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(134, 189);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(31, 23);
            this.btnDecimal.TabIndex = 17;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnNegaitveValue
            // 
            this.btnNegaitveValue.Location = new System.Drawing.Point(97, 189);
            this.btnNegaitveValue.Name = "btnNegaitveValue";
            this.btnNegaitveValue.Size = new System.Drawing.Size(31, 23);
            this.btnNegaitveValue.TabIndex = 16;
            this.btnNegaitveValue.Text = "+/-";
            this.btnNegaitveValue.UseVisualStyleBackColor = true;
            this.btnNegaitveValue.Click += new System.EventHandler(this.btnNegaitveValue_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(53, 189);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(31, 23);
            this.btnZero.TabIndex = 15;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(211, 160);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(31, 52);
            this.btnEquals.TabIndex = 19;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.Location = new System.Drawing.Point(211, 102);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(31, 23);
            this.btnSquareRoot.TabIndex = 20;
            this.btnSquareRoot.Text = "sqrt";
            this.btnSquareRoot.UseVisualStyleBackColor = true;
            this.btnSquareRoot.Click += new System.EventHandler(this.btnSquareRoot_Click);
            // 
            // btnRecipicol
            // 
            this.btnRecipicol.Location = new System.Drawing.Point(211, 131);
            this.btnRecipicol.Name = "btnRecipicol";
            this.btnRecipicol.Size = new System.Drawing.Size(31, 23);
            this.btnRecipicol.TabIndex = 21;
            this.btnRecipicol.Text = "1/x";
            this.btnRecipicol.UseVisualStyleBackColor = true;
            this.btnRecipicol.Click += new System.EventHandler(this.btnRecipicol_Click);
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 275);
            this.Controls.Add(this.btnRecipicol);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnNegaitveValue);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnMuliple);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtDisplay);
            this.Name = "frmCalc";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMuliple;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnNegaitveValue;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnRecipicol;
    }
}

