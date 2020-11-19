using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR.AutoRepair.BL
{

    public delegate void CollectionUpdate(Customer C);
    // Custom Collection that inherits from the List class
    public class CustomerCollection : List<Customer>
    {
        public CustomerCollection OnUpdate { get; set; }
        public void PopulateTestData()
        {
            Customer c;
            Car car;

            c = new Customer();
            c.FirstName = "Ryan";
            c.LastName = "Appel";
            c.ID = 4321;

            car = new Car();
            car.VIN = "YV1RS592362544261";
            car.Make = "Ford";
            car.Model = "Mustang";
            car.Year = 2009;
            c.Cars.Add(car);

            car = new Car();
            car.VIN = "3N1CB51D25L542400";
            car.Make = "Lotus";
            car.Model = "Elise";
            car.Year = 2019;
            c.Cars.Add(car);

            Add(c);


            c = new Customer();
            c.FirstName = "Brian";
            c.LastName = "Foote";
            c.ID = 4322;

            car = new Car();
            car.VIN = "1HGES16543L027005";
            car.Make = "Chevy";
            car.Model = "Monza";
            car.Year = 1980;
            c.Cars.Add(car);

            Add(c);
        }

        public new void Add(Customer customer)
        {
            base.Add(customer);
            customer.Collection = this;

            OnUpdate?.Invoke(customer);
        }

        public new void Remove(Customer customer)
        {
            base.Remove(customer);

            OnUpdate?.Invoke(customer);
        }

        public int GetNextID()
        {
            int highest = 0;
            foreach (Customer c in this)
            {
                if (c.ID > highest) highest = c.ID;
            }

            return highest + 1;
        }

        public void CustomerUpdated(Customer c)
        {
            OnUpdate?.Invoke(c);
        }
    }
}