using System;

namespace TPR.AutoRepair.BL
{
    public abstract class Vehicle // Base class for all vehicles
    {
        // Field
        private string vin = "";

        // Properties
        public string VIN
        {
            get { return vin; }
            set
            {
                if (value.Length != 17)
                {
                    string msg = "VIN must be 17 characters long";
                    InvalidVINException e = new InvalidVINException(msg);
                    e.Attempt = value;
                    throw e;
                }

                vin = value;
            }
        }
        public string Make { get; set; }
        public string Model { get; set; }


        // Methods
        public override string ToString() // override the ToString method in System.Object
        {
            return Make + " " + Model;
        }
    }
}
