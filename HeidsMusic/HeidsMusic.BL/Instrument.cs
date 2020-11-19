
using System;
using HeidsMusic.Utility;

namespace HeidsMusic.Business
{

    public abstract class Instrument : IInstrument
    {

        public string Manufacturer { get; set; }

        public float Cost { get; set; }

        public string Model { get; set; }

        public InstrumentType InstrumentType { get; set; }
    }
}
