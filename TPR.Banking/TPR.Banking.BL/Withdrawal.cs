using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR.Banking.BL
{
    //Inherits from the Abstract transcations class
    public class Withdrawal
    {
        public int ID { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        public Withdrawal(int id, Double amount, DateTime date)
        {
            ID = id;
            Amount = amount;
            Date = date;
        }
        public Withdrawal() { }
        public Withdrawal(DataRow row)
        {
            ID = Convert.ToInt32(row["TransactionID"]);
            Amount = Convert.ToDouble(row["TransactionAmount"]);
            Date = Convert.ToDateTime(row["TransactionDate"]);

        }
    }
}
