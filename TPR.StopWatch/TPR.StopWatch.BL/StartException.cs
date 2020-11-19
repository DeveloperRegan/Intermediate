using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR.StopWatch.BL
{
   public class StartException :Exception
    {
        //property

        //Constructor
        public StartException(string message) : base(message)
        {
 
        }
    }
}
