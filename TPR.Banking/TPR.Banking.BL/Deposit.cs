using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TPR.Banking.BL
{
    //Inherits from the transcatins Abstract

    public class Deposit
    {
        public int ID { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        public Deposit(int id, Double amount, DateTime date)
        {
            ID = id;
            Amount = amount;
            Date = date;
        }
        public Deposit()
        { }

        public Deposit(DataRow row)
        {
            ID = Convert.ToInt32(row["TransactionID"]);
            Amount = Convert.ToDouble(row["TransactionAmount"]);
            Date = Convert.ToDateTime(row["TransactionDate"]);

        }
    }
}
