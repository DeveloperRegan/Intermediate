//Terence Regan 3/27/17
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR.Banking.BL
{
    public class Person
    {
        public string SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }
        
        public int Age { get {
                return (int)((DateTime.Now - BirthDate).TotalDays / 365.2424999998009); }
            } 
        public DateTime BirthDate { get; set; }
    }
}
