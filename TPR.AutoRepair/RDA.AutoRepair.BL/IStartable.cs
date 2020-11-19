using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR.AutoRepair.BL
{
    public interface IStartable
    {
        void Start(); // Anything that implements IStartable must have a void Start() method
    }
}
