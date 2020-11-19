using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TPR.Banking.BL
{
    //The Withdrawl and Deposit transactions have the same information, so I made a Transaction abstract Class
    //There could easily have Transfer, or Bill Pay transactions
 
    public class Transactions
    {
        public int ID { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }


        public Transactions()
        { }

    }
}
