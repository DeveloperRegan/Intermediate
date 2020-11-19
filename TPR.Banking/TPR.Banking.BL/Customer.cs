//Terence Regan
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TPR.Banking.PL;

namespace TPR.Banking.BL
{
    //Inherits from a person
  public  class Customer : Person
    {
        public int CustomerId { get; set; }   
        public Deposit LastDeposit { get; 
            } 
       public Withdrawal LastWithDrawal { get; }
        public DepositCollection DepositList { get; set; }
        public WithdrawelCollection WithdrawlList { get; set; }
        public TransactionCollection transactionList { get; set; }
  
        [XmlIgnore]
        public CustomerCollection Collection { get; set; }

      public  Customer (int id, DateTime DOB, String FirstName, String LastName, String SSN )
        {
            // Calls the other customer constructor so the program won't need to make those two lists again
            Customer c = new Customer();
            c.CustomerId = id;
            c.BirthDate = DOB;
            c.FirstName = FirstName;
            c.LastName = LastName;
            c.SSN = SSN;
        }

        public Customer(DataRow row)
        {
            DepositList = new DepositCollection();
            WithdrawlList = new WithdrawelCollection();
            
            CustomerId = Convert.ToInt32(row["CustomerID"]);
            BirthDate = Convert.ToDateTime(row["DOB"]);
            FirstName = Convert.ToString(row["FirstName"]);
            LastName = Convert.ToString(row["LastName"]);
            SSN = Convert.ToString(row["SSN"]);

            //Made two methods to sort the incoming data from the database into their relative collection.
            GetDepositsFromDB();
            getWithdrawelsFromDB();

        }

        public void GetDepositsFromDB ()
        {
            // Gets all transactions where the value is greater than 0.  
            //I made it a business rule that money in account that all positive transactions are deposits
            // 
            string sql = "Select * from tblTransactions where TransactionAmount > 0 and CustomerID = @id;";

            DataTable table = DataAccess.RunSelect(sql, getParameters().ToArray());
             
            //adds each deposit to the deposit list
            foreach (DataRow transRow in table.Rows)
            {
                DepositList.Add(new Deposit(transRow));
            }

        }

        public void getWithdrawelsFromDB()
        {
            // Gets all transactions where the value is less than 0.  
            //I made it a business rule that money in account that all negative transactions are withdrawels
            // 
            string sql = "Select * from tblTransactions where TransactionAmount < 0 and CustomerID = @id;";

            DataTable table = DataAccess.RunSelect(sql, getParameters().ToArray());

            //adds each withdrawl to the withdrawlList
            foreach (DataRow transRow in table.Rows)
            {
                WithdrawlList.Add(new Withdrawal(transRow));
            }
        }

        public  Customer()
        {//creates lists for the Customer deposits/Withdrawls
            DepositList = new DepositCollection();
            WithdrawlList = new WithdrawelCollection();
        }

        public void InsertIntoDB()
        {
            try
            {
                //Sets the identiy insert to be on, inserts the values into the db, and then sets identity insert to be false;
                string sql = "SET IDENTITY_INSERT tblCustomers ON; INSERT INTO tblCustomers (CustomerID, SSN, FirstName, LastName, DOB) VALUES (@ID, @SSN, @FirstName, @LastName, @DOB); SET IDENTITY_INSERT tblCustomers OFF;";

                DataAccess.RunSQL(sql, getParameters().ToArray());

                DataAccess.CloseConnection();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        //Probably needed to add the Update and Delete

        public void DeleteDB()
        {
            try
            {
                string sql = "DELETE FROM tblCustomers WHERE CustomerID = @ID;";
                DataAccess.RunSQL(sql, getParameters().ToArray());

                DataAccess.CloseConnection();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void UpdateDB()
        {
            try
            {
                string sql = "UPDATE tblcustomers SET FirstName = @FirstName, LastName = @Lastname, SSN = @SSN, DOB=@DOB WHERE CustomerID = @ID;";
                DataAccess.RunSQL(sql, getParameters().ToArray());

                DataAccess.CloseConnection();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        private List<SqlParameter> getParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ID", CustomerId));
            parameters.Add(new SqlParameter ("@SSN", SSN));
            parameters.Add(new SqlParameter("@FirstName", FirstName));
            parameters.Add(new SqlParameter("@Lastname", LastName));
            parameters.Add(new SqlParameter("@DOB", BirthDate));



            return parameters;
        }
    }
}
