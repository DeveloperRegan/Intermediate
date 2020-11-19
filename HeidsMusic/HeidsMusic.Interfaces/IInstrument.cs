
namespace HeidsMusic.Utility
{
     public enum InstrumentType
     {
         Bassoon,
         Clarinet,
         Percussion,
         Flute,
         FrenchHorn,
         Piano,
         Saxophone,
         Trumpet,
         Tuba
     }

    public interface IInstrument
    {
        string Manufacturer { get; set; }
        float Cost { get; set; }
        string Model { get; set; }

        InstrumentType InstrumentType { get; set; }
    }

    public interface IInstrumentCollection
    {
        void Save();
        void Load();
    }
}


