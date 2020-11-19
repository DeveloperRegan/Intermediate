
using System;
using System.Windows.Forms;
using TPR.AutoRepair.BL;
using TPR.AutoRepair.PL;


namespace TPR.AutoRepair.UI
{
    public partial class Form1 : Form
    {
        private CustomerCollection customers;// = new CustomerCollection();
        private string filepath = "customers.xml";
        public Form1()
        {
            InitializeComponent();
          
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                customers = DataAccess.LoadFromXml(filepath, typeof(CustomerCollection)) as CustomerCollection;

                customers.OnUpdate += RebindCustomers;
                // customers.PopulateTestData();
                RebindCustomers(customers[0]);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // create a customer instance and add it to the list

            Customer c = new Customer();
            c.FirstName = txtFirstName.Text;
            c.LastName = txtLastName.Text;
            c.ID = customers.GetNextID();
            c.Phone = txtPhone.Text;

            customers.Add(c);
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                // create a car instance
                Car c = new Car();
                c.Make = txtMake.Text;
                c.Model = txtModel.Text;
                c.Year = int.Parse(txtYear.Text);

                c.VIN = txtVIN.Text; // Internally throws an exception (InvalidVINException)

                // add the car to the customer's car list
                Customer cust = lstCustomers.SelectedItem as Customer;           
                if (cust != null)
                {
                    cust.Cars.Add(c);
                    RebindCars(cust);
                    //MessageBox.Show(cust.Cars[0].ToString());
                }
            }
            catch (InvalidVINException ex)
            {
                MessageBox.Show(ex.Message, ex.Attempt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        
        }

        private void RebindCustomers(Customer c)
        {
            // hooks up the customer list to the listbox on the form
            MessageBox.Show("You just did something with " + c.ToString());
            customers.Sort();

            lstCustomers.DataSource = null;
            lstCustomers.DataSource = customers;
            lstCustomers.DisplayMember = "DisplayName";
        }

        private void RebindCars(Customer c)
        {
            // hooks up the cars (from a specific customer) to the listbox on the form

            lstCars.DataSource = null;
            lstCars.DataSource = c.Cars;
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer selected = lstCustomers.SelectedItem as Customer;
            if (selected != null) // selected customer is valid...
            {
                // so update the text boxes
                txtFirstName.Text = selected.FirstName; 
                txtLastName.Text = selected.LastName;
                txtPhone.Text = selected.Phone;

                // and update the car listbox
                RebindCars(selected);
            }
        }

        private void lstCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car selected = lstCars.SelectedItem as Car;
            if (selected != null) // selected car is valid...
            {
                // so update the text boxes
                txtVIN.Text = selected.VIN;
                txtMake.Text = selected.Make;
                txtModel.Text = selected.Model;
                txtYear.Text = selected.Year.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DataAccess.SaveToXML(filepath, customers, typeof(CustomerCollection));
            }
            catch (Exception)
            {
                e.Cancel = true;
                MessageBox.Show("Uh Oh!");
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            Customer selected = lstCustomers.SelectedItem as Customer;
            if (selected != null) // selected customer is valid...
            {
                // so update the text boxes
                string fn = txtFirstName.Text;
                string ln = txtLastName.Text;
                string p = txtPhone.Text;

                selected.FirstName = fn;
                selected.LastName = ln;
                selected.Phone = p;
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            Customer selected = lstCustomers.SelectedItem as Customer;
            if (selected != null)
            {
                customers.Remove(selected);
            }
        }
    }
}
