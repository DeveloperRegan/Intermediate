//Terence Regan.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR.Exam1.UI
{
    public partial class frmDisplay : Form
    {
        //Initializes the REctangle Class
        Rectangle rectangle = new Rectangle();
        public frmDisplay()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtLength.Text == "" || txtWidth.Text=="")
            {
                MessageBox.Show("Please fill in the length and width");           
            }
            else
            {
                float width;
                float.TryParse(txtWidth.Text, out width);
                rectangle.width = width;

                float height;
                float.TryParse(txtLength.Text, out  height);
                rectangle.height = height;
                //calls the methods of the rectangle class.
                txtPerimter.Text = rectangle.Perimeter(rectangle.width, rectangle.height);
                txtArea.Text = rectangle.Area(rectangle.width, rectangle.height);
            }
        }

        private void Inputs_changed(object sender, EventArgs e)
        {//sets the area and perimeter text boxes to empty string if the input values are changed.
            txtArea.Text = "";
            txtPerimter.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
