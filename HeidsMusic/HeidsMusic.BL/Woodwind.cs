
using HeidsMusic.Utility;

namespace HeidsMusic.Business
{
    public class Woodwind : Instrument
    {
        public Woodwind(string reedType, int reedSize, float cost, string manufacturer, string model, InstrumentType instrumentType)
        {
            Cost = cost;
            Model = model;
            Manufacturer = manufacturer;
            InstrumentType = instrumentType;
        }
        public Woodwind() { }
    }
}
