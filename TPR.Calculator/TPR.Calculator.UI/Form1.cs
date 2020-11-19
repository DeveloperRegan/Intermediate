//Terence Regan
//3/4/2017
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPR.Calculator.BL;

namespace TPR.Calculator.UI
{
    public partial class frmCalc : Form
    {
        //Instantiates an instance of the calcualtor class;
        private TPR.Calculator.BL.Calculator calc = new BL.Calculator();
        //private Calculator calc = new Calculator();
        public frmCalc()
        {
            InitializeComponent();
        }


        private void Number_Click(object sender, EventArgs e)
        {  //If the number is buttons are clicked, the display on the calculator gets the new numbers added on.
            if(sender is Button)
            {
                Button button = sender as Button;
               txtDisplay.Text = calc.ChangeDisplay(txtDisplay.Text, button.Text);
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        { 
            //Calls the back function from the calculator class, passing in the txtDisplayText.
           txtDisplay.Text = calc.Back(txtDisplay.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           txtDisplay.Text = calc.Clear();
        }

        private void ChangeMath(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = sender as Button;
                //Sets the calc.Display to the txtDisplay.Text
                calc.display = txtDisplay.Text;
                
                try
                {
                    //Does the setopperations function of the calc object.
                    calc.SetOpperations(button.Text);
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception)
                {
                    //If an exception happens, the Display TExt will be error, and the aset and bset will both be set to false;
                    txtDisplay.Text = "Error";
                    calc.aSet = false;
                    calc.bSet = false;
                    
                    throw;
                }
             
                //Displays the result.
                txtDisplay.Text = calc.display;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        { //Sets the calc.Display to the txtDisplay.Text
            calc.display = txtDisplay.Text;
            //Does the eql function of the calc object.
            calc.Eql();
            //Displays the result.
            txtDisplay.Text = calc.display;
        }

        private void btnNegaitveValue_Click(object sender, EventArgs e)
        {
           txtDisplay.Text= calc.negitveOne(txtDisplay.Text).ToString();
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
          txtDisplay.Text=  calc.SquareRoot(txtDisplay.Text).ToString();
        }

        private void btnRecipicol_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = calc.Recipricol(txtDisplay.Text).ToString();
        }
    }
}
