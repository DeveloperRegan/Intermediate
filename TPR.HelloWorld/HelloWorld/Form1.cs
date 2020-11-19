/*
 *Terence Regan Hello World 
 * 
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

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Hello World code
        private void btnWorld_Click(object sender, EventArgs e)
        {


            if (lblWorld.Text == "Hello World")
            {
                lblWorld.Text = "Goodbye Cruel World";
                btnWorld.Text = "Hello";
            }
            else if (lblWorld.Text == "Goodbye Cruel World")
            { lblWorld.Text = "Hello World";
                btnWorld.Text = "GoodBYe";
            }

        }
    }
}
