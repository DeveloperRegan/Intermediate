using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR.StopWatch.BL
{
  public  class StopException : Exception
    {
        //property

        //Constructor
        public StopException(string message) : base(message)
        {//commented
        }
    }
}
