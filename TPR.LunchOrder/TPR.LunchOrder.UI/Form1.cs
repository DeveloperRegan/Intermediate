/*
 * Terence Regan
 * Week 2 Lunch Order
 * Used Regions so I can collapse code easily, might have to be expanded.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR.LunchOrder.UI
{
    public partial class frmOrder : Form
    {
        
        public frmOrder()
        {
            InitializeComponent();
        }

        public float AddOnPrice = 0;
        public float Price = 0;

        //regions for main course selections
        #region MainCourseRadioButtonSelections
        private void rdoPizza_CheckedChanged(object sender, EventArgs e)
        { //Calls change add on
            ChangeAddOns("Pepperoni", "Sausage", "Shrimp",.50f, 5.95f );
            //Sets the textboxes to a placeholder text
            TotalTextsBeforePlacing();
        }

        private void rdoHambuger_CheckedChanged(object sender, EventArgs e)
        {
            //calls tthe change addon Method
            ChangeAddOns("Lettuce, tomato, and onions", "Mayonnaise and mustard", "French fries", .75f, 6.95f);
            //Sets the textboxes to a placeholder text
            TotalTextsBeforePlacing();
        }

        private void rdoSalad_CheckedChanged(object sender, EventArgs e)
        {
            //calls the change add on Method
            ChangeAddOns("Croutons", "Bacon bits", "Bread sticks", .25f, 4.95f);
            //Sets the textboxes to a placeholder text
            TotalTextsBeforePlacing();
        }


        #endregion
    

        #region Buttons
        private void btnPlace_Click(object sender, EventArgs e)
        {
            //uses a counter for the addons, if the items are selected, the price count increases.
            int addons = 0;
            //I could make this a switch case
            if (chkAddon1.Checked == true)
            { addons++; }

            if (chkAddOn2.Checked==true)
            { addons++; }

            if (chkAddOn3.Checked == true)
            { addons++; }

          // creates the subtotal float

            float subtotal = Price + (addons * AddOnPrice);

            txtSubtotal.Text = subtotal.ToString("C");
            
            txtTax.Text= GetSalesTax(subtotal).ToString("C");

            txtTotal.Text = OrderTotal(subtotal).ToString("C");

            btnPlace.Enabled = false;

            addons = 0;
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region MathStuff

        //Method to change course add ons
        private void ChangeAddOns(string addon1, string addon2, string addon3, float AddOnItemprice, float price)
        {
            chkAddon1.Text = addon1;
            chkAddOn2.Text = addon2;
            chkAddOn3.Text = addon3;
            grpAddOns.Text = "Add-On items (" + AddOnItemprice.ToString("C") + "//each)";
            AddOnPrice = AddOnItemprice;
            Price = price;
            txtSubtotal.Text = price.ToString("C");
            btnPlace.Enabled = true;

        }


        //Get sales tax method
        private float GetSalesTax(float subtotal)
        {
            return (float)Math.Round((subtotal * .0775f), 2);
        }

        //Math for the Order Total
        private float OrderTotal(float subtotal)
        {
            return (float)Math.Round((subtotal * 1.0775f),2);
        }

        //Method to change the text when options are changed
        private void TotalTextsBeforePlacing()
        {
            string temp = "Click Place Order to Get numbers";
            txtSubtotal.Text = temp;
            txtTax.Text = temp;
            txtTotal.Text = temp;
            btnPlace.Enabled = true;
        }
        #endregion

        //Places text holders
        private void chkAddon1_CheckedChanged(object sender, EventArgs e)
        {
            TotalTextsBeforePlacing();
        }


        //Places text holders
        private void chkAddOn2_CheckedChanged(object sender, EventArgs e)
        {
            TotalTextsBeforePlacing();
        }

        //Places text holders
        private void chkAddOn3_CheckedChanged(object sender, EventArgs e)
        {
            TotalTextsBeforePlacing();
        }
    }

}
