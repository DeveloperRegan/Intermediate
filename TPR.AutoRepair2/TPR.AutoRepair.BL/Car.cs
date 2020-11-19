using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR.AutoRepair.BL
{
 public class Car : Vehicle
    {

        public int year { get; set; }

        public Car()
        {
            
        }

        public Car(string make, string model, int Year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public override string ToString()
        {

            return year.ToString() + " " + Make + " " + Model;
          //  return base.ToString();
        }
    }
}
