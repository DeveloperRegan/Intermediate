using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR.Calculator.BL
{
    public class DivideByZeroExecption : Exception
    {
        
        public DivideByZeroExecption(string message) : base(message)
            {

        }
    }
}
