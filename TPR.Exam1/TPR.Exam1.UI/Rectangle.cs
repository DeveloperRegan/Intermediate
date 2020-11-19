using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR.Exam1.UI
{
   public class Rectangle
    {
        //height and width properties
        public float height { get; set; }
        public float width { get; set; }

        
        public string Perimeter (float a, float b)
        {
             return ((2 * a) +(2 *  b)).ToString() ;           
        }

        public string Area (float a, float b)
        {
            return (a * b).ToString();
        }

    }
}
