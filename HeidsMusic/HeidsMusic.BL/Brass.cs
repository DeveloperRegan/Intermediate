
using HeidsMusic.Utility;

namespace HeidsMusic.Business
{
    public class Brass : Instrument
    {
        public string Finish { get; set; }

        public int ValveCount { get; set; }

        public Brass()
        {
        }
        // Constructor params: Finish, Valve Count (INT), Cost (FLOAT), Manufacturer, Model, InstrumentType)
        public Brass(string finish, int valve, float cost, string manufacturer, string model, InstrumentType instrumenttype)
        {
            Finish = finish;
            ValveCount = valve;
            Cost = cost;
            Manufacturer = manufacturer;
            Model = model;
            InstrumentType = instrumenttype;
        }
    }
}
