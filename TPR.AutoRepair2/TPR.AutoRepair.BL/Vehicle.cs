using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR.AutoRepair.BL
{
    public abstract class Vehicle
    {
        //field
        public string vin = "";
        public string VIN { get{
                return vin;
            }

            set
            {
                if (value.Length !=17)
                {
                    InvalidVINException e = new InvalidVINException("VIN must be 17 Characters");
                    e.Attempt = value;
                    throw e;

               }
                vin = value;
            }
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public override string ToString()
        {
            return Make + " " + Model;
        }
    }
}