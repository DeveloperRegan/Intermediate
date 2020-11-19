using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR.AutoRepair.BL
{
    public class InvalidVINException : Exception
    {
        public string Attempt { get; set; }
        public int AttemptLength { get; set; }
        public InvalidVINException(string message) :base(message)
        {
            
        }
    }
}
