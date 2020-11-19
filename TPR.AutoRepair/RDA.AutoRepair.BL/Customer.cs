
using System.Collections.Generic;
using System;
using System.Xml.Serialization;


namespace TPR.AutoRepair.BL
{
    public class Customer : IComparable<Customer>
    {
        private string firstName;
        private string lastName;
        private string phone;

        // Properties
        public int ID { get; set; }
        public string FirstName {
            get { return firstName; }
            set
            {
                firstName = value;
                Collection?.CustomerUpdated(this);
            }  
            }
        public string LastName { get
            { return lastName; }
                set {
                lastName = value;
                Collection?.CustomerUpdated(this);}
        }
        public string Phone { get; set; }
        
        public List<Car> Cars { get; set; }
        
        public string DisplayName
        {
            get { return FirstName + " " + LastName; } // read-only
        }

     
        [XmlIgnore]
        public CustomerCollection Collection { get; set; }

        // Constructor
        public Customer()
        {
            Cars = new List<Car>();
        }

        // IComparable Method
        public int CompareTo(Customer other)
        {
            return LastName.CompareTo(other.LastName);
        }
        public override string ToString()
        {
            return DisplayName;
        }
    }
}
