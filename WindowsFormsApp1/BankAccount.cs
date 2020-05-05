using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BankAccount
    {
        

        // Instance Variables 
        private decimal Balance;
       public readonly int acnum;

        // Constructor Declaration of Class 
        public BankAccount(decimal Balance, int acnum)
        {
            this.Balance = Balance;
            this.acnum = acnum;
        }

        // Property 1 gettter 
        public decimal getBal()
        {
            return Balance;
        }
        //public decimal setBal(decimal b)
        //{
        //    this.Balance = b;
        //    return this.Balance;
        //}

        // Property 2  gettter
        public int getacnum()
        {
            return acnum;
        }
        //public decimal setacnum(int b)
        //{
        //    this.acnum = b;
        //    return this.Balance;
        //}
        // Method 1
        public decimal displaybal()
        {
            return this.getBal(); 
        }
        // Method 2 
        public decimal displayacc()
        {
            return this.getacnum();
        }
        // Method 3 
        public decimal Deposit(decimal d)
        {
            return (this.Balance += d);
        } 
        // Method 4 
        public decimal Withdraw(decimal d)
        {
            return (this.Balance -= d);
        }

        // Method 5
        public decimal GetAccountStatus()
        { 
            return this.getBal();
        }
        // Method 6
        public decimal GetAccountBalance()
        { return this.getBal();}
    }
}
