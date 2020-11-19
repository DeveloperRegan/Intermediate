//Terence Regan 3/27/17
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPR.Banking.BL;
using TPR.Banking.PL;


namespace TPR.Banking.UI
{
    public partial class frmBanking : Form
    {

        private string filepath = "Banking.xml";
        private CustomerCollection customers;

        Customer C;
        public frmBanking()
        {
            InitializeComponent();
     
          
        }


        private void frmBanking_Load(object sender, EventArgs e)
        {
            try
            {
                customers = new CustomerCollection();

                customers.LoadFromDB();

                customers.OnUpdate += RebindCustomers;
                RebindCustomers();

      

                

                 customers.OnUpdate += RebindCustomers;
                 RebindCustomers();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {//coerce Selected to be a customer
            Customer Selected = lstCustomers.SelectedItem as Customer;
            //Makes sure Selected is not null
            if(Selected !=null)
            {
                txtFirstName.Text = Selected.FirstName;
                txtLastName.Text = Selected.LastName;
                dtpBirthdate.Value = Selected.BirthDate;
                txtSSN.Text = Selected.SSN;
                lblDisplayAge.Text = Selected.Age.ToString();
                lblCustomerID.Text = Selected.CustomerId.ToString();
                //Rebinds the transactions to the selected value
                RebindTransactions(Selected);
            }
               
        }

        private void RebindTransactions(Customer C)
        { //Sets the datasource to null, and links the respective lists to the dataGrids
            dgdDeposits.DataSource = null;
            dgdDeposits.DataSource = C.DepositList;
            dgdDeposits.Columns[1].DefaultCellStyle.Format = "C";
            

            dgdWithdrawl.DataSource = null;
            dgdWithdrawl.DataSource = C.WithdrawlList;
            dgdWithdrawl.Columns[1].DefaultCellStyle.Format = "C";
           
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dtpBirthdate.ResetText();
            lblAge.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtSSN.Text = "";
            lblDisplayAge.Text = "";

            lblCustomerID.Text = customers.GetNextID().ToString();

            lstCustomers.SelectedItem = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer Selected = lstCustomers.SelectedItem as Customer;
            if (Selected != null)
            {
                string fn = txtFirstName.Text;
                string ln = txtLastName.Text;
                string ssn = txtSSN.Text;
                DateTime DOB = dtpBirthdate.Value;

                Selected.FirstName = fn;
                Selected.LastName = ln;
                Selected.SSN = ssn;
                Selected.BirthDate = DOB;
                Selected.UpdateDB();
            }
            else
            {
                C = new Customer();
                C.BirthDate = dtpBirthdate.Value;
                C.CustomerId = customers.GetNextID();
                C.FirstName = txtFirstName.Text;
                C.LastName = txtLastName.Text ;
                C.SSN = txtSSN.Text ;

                customers.Add(C);
                C.InsertIntoDB();
             }

        
            RebindCustomers();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           

                    Customer selected = lstCustomers.SelectedItem as Customer;
            if (selected != null)
            {
             DialogResult result = MessageBox.Show("Do you want to delete " + selected.FullName + " forever? ","Delete " + selected.FullName +"?",MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                   
                    customers.Remove(selected);
                    selected.DeleteDB();
                    RebindCustomers();

                }

            }
        }
        private void RebindCustomers()
        {
            lstCustomers.DataSource = null;
            lstCustomers.DataSource = customers;
            lstCustomers.DisplayMember = "FullName";
        }

     


        private void btnSaveXML_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess.SaveToXml(filepath, customers, typeof(CustomerCollection));
                MessageBox.Show("Data saved to " + filepath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
           
            }
        }

        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            customers = DataAccess.LoadFromXml(filepath, typeof(CustomerCollection)) as CustomerCollection;
            customers.OnUpdate += RebindCustomers;
            RebindCustomers();
            MessageBox.Show("Data loaded from " + filepath);
        }
    }
}
