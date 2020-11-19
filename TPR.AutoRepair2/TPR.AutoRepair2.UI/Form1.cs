using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPR.AutoRepair.BL;
using System.Windows.Forms;

namespace TPR.AutoRepair2.UI
{

   
    public partial class Form1 : Form
    {
        private List<Customer> customers = new List<Customer>();
        private List<Car> cars = new List<Car>();

        public Form1()
        {
            InitializeComponent();
            Car c = new Car();

            c.vin = "12345678910121314";
            c.Make = "Ford";
            c.Model = "Mustange";
            c.year = 2017;
            cars.Add(c);
            

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.FirstName = "Terence";
            c.LastName = "Regan";
            c.ID = customers.Count + 1;

            customers.Add(c);

            RebindCustomers();


        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                Car c = new Car("Ford", "Mustang", 2018);
                c.VIN = "DDFA323423";
                Customer cust = lstCustomers.SelectedItem as Customer;
                if (cust != null)
                {
                    cust.Cars.Add(c);


                    //    MessageBox.Show(cust.Cars[cust.Cars.Count-1].ToString());
                }
            }
            catch (InvalidVINException ex)
            {
            MessageBox.Show(ex.Message, ex.Attempt + "is" + ex.Attempt.Length.ToString() + " Characters" );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void RebindCars(Customer c)
        {
            lstCars.DataSource = null;
            // lstCars.DataSource = c.Cars;

        }

        private void RebindCustomers()
        {

            lstCustomers.DataSource = null;
            lstCustomers.DataSource = customers;
            lstCustomers.DisplayMember = "DisplayName";

        }
    }
}
