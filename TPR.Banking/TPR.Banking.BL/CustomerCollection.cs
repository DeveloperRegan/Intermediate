//Terence Regan 3/27
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPR.Banking.PL;

namespace TPR.Banking.BL
{
    public delegate void CollectionUpdate();
    //Inherits the List class
    public class CustomerCollection: List<Customer>
    {
    
        public CollectionUpdate OnUpdate { get; set; }
        // public 

        public CustomerCollection()
        {
            DataAccess.ConnectionString = "Server=tcp:regan-intermed.database.windows.net,1433;Initial Catalog=ReganDB;Persist Security Info=False;User ID=Regan;Password=P@$$word;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }

        public void LoadFromDB()
        {
            string sql = "Select * FROM tblCustomers";
            DataTable table = DataAccess.RunSelect(sql);

            Clear();
            foreach (DataRow customerRow in table.Rows)
            {
              Add(new Customer(customerRow));
            }

           
        }

        

    
        public void Populate()
        {
       

            Customer C;
            Deposit D;
            Withdrawal W;
            

            C = new Customer();
            C.BirthDate = DateTime.MinValue;
            C.CustomerId = 1;
            C.FirstName = "Kevin";
            C.LastName = "Smith";
            C.SSN = "123456789";
            C.BirthDate = Convert.ToDateTime("08/02/1970");
         
            Add(C);
            //Every Transaction happens right now.
            D = new Deposit(1,503, DateTime.Now.Date);
            C.DepositList.Add(D);
            D = new Deposit(2, 5043, DateTime.Now.Date);
            C.DepositList.Add(D);
            D = new Deposit(3, 3434.32, DateTime.Now.Date);
            C.DepositList.Add(D);

            W = new Withdrawal(1, 5343.42, DateTime.Now.Date);
            C.WithdrawlList.Add(W);
            W = new Withdrawal(2, 1235.36, DateTime.Now.Date);
            C.WithdrawlList.Add(W);
            W = new Withdrawal(3, 1233.63, DateTime.Now.Date);
            C.WithdrawlList.Add(W);

            C = new Customer();
            C.BirthDate = DateTime.MinValue;
            C.CustomerId = 2;
            C.FirstName = "John";
            C.LastName = "Wayne";
            C.SSN = "987654321";
            C.BirthDate = Convert.ToDateTime("05/26/1907");

            Add(C);

            D = new Deposit(1, 555.24, DateTime.Now.Date);
            C.DepositList.Add(D);
            D = new Deposit(2, 33.53, DateTime.Now.Date);
            C.DepositList.Add(D);
            D = new Deposit(3, 344.32, DateTime.Now.Date);
            C.DepositList.Add(D);

            W = new Withdrawal(1, 53.42, DateTime.Now.Date);
            C.WithdrawlList.Add(W);
            W = new Withdrawal(2, 4341.36, DateTime.Now.Date);
            C.WithdrawlList.Add(W);
            W = new Withdrawal(3, 923.63, DateTime.Now.Date);
            C.WithdrawlList.Add(W);

            C = new Customer();
            C.BirthDate = DateTime.MinValue;
            C.CustomerId = 3;
            C.FirstName = "Bruce";
            C.LastName = "Wayne";
            C.SSN = "193904127";
            C.BirthDate = Convert.ToDateTime("02/19/1939");

            Add(C);

            D = new Deposit(1, 503, DateTime.Now.Date);
            C.DepositList.Add(D);
            D = new Deposit(2, 5043, DateTime.Now.Date);
            C.DepositList.Add(D);
            D = new Deposit(3, 3434.32, DateTime.Now.Date);
            C.DepositList.Add(D);

            W = new Withdrawal(1, 5343.42, DateTime.Now.Date);
            C.WithdrawlList.Add(W);
            W = new Withdrawal(2, 1235.36, DateTime.Now.Date);
            C.WithdrawlList.Add(W);
            W = new Withdrawal(3, 1233.63, DateTime.Now.Date);
            C.WithdrawlList.Add(W);
        }
        public new void Add(Customer customer)
        {
            base.Add(customer);
            customer.Collection = this;

            OnUpdate?.Invoke();
        }

        public new void Remove(Customer customer)
        {
            base.Remove(customer);

            OnUpdate?.Invoke();
        }

        public int GetNextID()
        {
            int highest = 0;
            foreach (Customer c in this)
            { if (c.CustomerId > highest) highest = c.CustomerId; }
            return highest + 1;
        }

        public void CustomerUpdated(Customer c)
        {
            OnUpdate?.Invoke();
        }
    }
}