using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    class Account
    {
        //fields
        private string firstName;
        private string lastName;
        private double routingNumber;
        private double accountNumber;
        protected double balance;
        protected double transaction;

        //properties
        public double Routing
        {
            get { return this.routingNumber;}
        }
        public double AcctNumb
        {
            get { return this.accountNumber; }
        }
        public double Balance
        {
            get { return this.balance; }
        }

        //constructors
        public Account()
        {
            firstName = "Obama";
            lastName = "Barack";
            routingNumber = 24000980012;
        }

        //methods
        public virtual double AccountNumb()
        {
            Random rand = new Random();
            this.accountNumber =rand.Next(100000000, 1000000000);
            return accountNumber;
        }
        public virtual double Withdrawal()
        {
            this.balance -= this.transaction;
            return balance;
        }
        public virtual double Deposit()
        {
            this.balance += this.transaction;
            return balance;
        }
    }
}
