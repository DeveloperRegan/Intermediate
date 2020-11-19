
namespace TPR.AutoRepair.BL
{
    public class Car : Vehicle, IStartable
    {
        // Fields

        // Properties
        public int Year { get; set; }

        // Constructors
        public Car() { }
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        // Methods 
        public override string ToString() // override the method in vehicle
        {
            return Year.ToString() + " " + base.ToString(); // use the vehicle ToString method as part of the result.
        }

        // IStartable Member
        public void Start()
        {

        }
    }
}
