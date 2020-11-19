using System;

namespace TPR.AutoRepair.BL
{
    public class InvalidVINException : Exception
    {
        // Property
        public string Attempt { get; set; }

        // Constructor
        public InvalidVINException(string message)
            : base(message)
        { }


    }
}
