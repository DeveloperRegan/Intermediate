//Terence Regan
//File I.O



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

namespace TPR.FileIO.Assignement.UI
{
    public partial class Form1 : Form
    {
        //Created a variable for the file location
        private string file ="";

        //Creates a bool that becomes true when the textbox changes and false when it is saved or Loaded
        bool hasChanged = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if(hasChanged == true)
            {
                DialogResult dlgResult = MessageBox.Show("Do you want to Save before you make a new file", "Create New File", MessageBoxButtons.YesNoCancel);
                if (dlgResult == DialogResult.Yes)
                {
                    //if the user has not saved or opened a file yet, it will call the save prompt function, else it will just save the file.
                    if (file == "")
                        SavePrompt();
                    else
                        Save(file);
                }else if (dlgResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }       
        }


        private void nmuNew_Click(object sender, EventArgs e)
        {
            
            DialogResult dlgResult=  MessageBox.Show("Do you want to Save before you make a new file" , "Create New File",  MessageBoxButtons.YesNoCancel);
            if(dlgResult == DialogResult.Yes)
            {
                //if the user has not saved or opened a file yet, it will call the save prompt function, else it will just save the file.
                if (file == "")
                    SavePrompt();
                else
                    Save(file);
            }
            else if(dlgResult == DialogResult.No)
            {
                txtDisplay.Text = "";
            }
          
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                //Assignes the dlgOpen.FileName to File;
                file = dlgOpen.FileName;
                open(file);
            }
        }
        private void mnuSave_Click(object sender, EventArgs e)
        {
            //If the user has not saved before or opened a file, will prompt user where to save.
            if (file == "")
                SavePrompt();
            Save(file);
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            SavePrompt();  
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        #region Method City

        private void Save(string filePath)
        {
            StreamWriter Writer = new StreamWriter(filePath);
            try
            {
                Writer.Write(txtDisplay.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could Not Save");

            }
            finally
            {
                Writer.Close();
                hasChanged = false;
                staDate.Text = DateTime.Now.ToString();
                staPath.Text = file;
            }
        }

        private void open(string FilePath)
        {
            StreamReader Reader = new StreamReader(FilePath);

            try
            {
                txtDisplay.Text = Reader.ReadToEnd().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could Not Save");

            }
            finally
            {
                Reader.Close();
                hasChanged = false;
                staDate.Text = DateTime.Now.ToString();
                staPath.Text = file;
            }
        }

        private void SavePrompt()
        {
            
            SaveFileDialog dlgSave = new SaveFileDialog();

            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                file = dlgSave.FileName;
                //Calls the save Method
                Save(file);
            }
        }

        #endregion
    }
}
