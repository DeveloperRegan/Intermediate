using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR.AutoRepair.BL
{
    public class Customer
    {
       public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName
        {
            get { return FirstName + " " + LastName; }
        }
        public List<Car> Cars { get; set; }
         
        //constructor
        public Customer()
        {
            Cars = new List<Car>();
        }
    }
}
