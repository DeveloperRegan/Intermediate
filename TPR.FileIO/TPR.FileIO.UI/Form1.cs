using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR.FileIO.UI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            DialogResult dlgResult;

            // dlgResult = MessageBox.Show("hi", "Test", MessageBoxButtons.OKCancel);

            ColorDialog dlgColor = new ColorDialog();

            dlgResult = dlgColor.ShowDialog();

           

            if(dlgResult == DialogResult.OK)
            {
                txtBlank.ForeColor = dlgColor.Color;
            }
        }

        private void btnFont(object sender, EventArgs e)
        {
            FontDialog dlgFont = new FontDialog();

          DialogResult  dlgResult = dlgFont.ShowDialog();

            if (dlgResult== DialogResult.OK)
            {
                txtBlank.Font = dlgFont.Font;
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {


            SaveFileDialog dlgSave = new SaveFileDialog();

            dlgSave.Filter = "Text Files| *.txt|Image Files| *.jpg";


            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                save(dlgSave.FileName);
            }

        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();


            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                open(dlgOpen.FileName);
            }
        }
        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
          
                  }

        #region CustomMethods
        private void save(string filePath)
        {
            StreamWriter SW = new StreamWriter(filePath);
            try
            {
                SW.Write(txtBlank.Text);
                SW.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could Not Save");
                
            }
            finally
            {
                SW.Close();
            }

        }

        private void open(string filePath)
        {
            StreamReader SR = new StreamReader(filePath);
            SR.ReadToEnd();
            SR.Close();
        }
        #endregion
    }
}
