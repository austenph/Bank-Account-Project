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
        protected string type;

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
            firstName = "Barack";
            lastName = "Obama";
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
        public virtual void ClientInfo()
        {
            Console.WriteLine("Fake US Bank Inc.,");
            Console.WriteLine("Bank Account Holder: " + firstName + " " + lastName);
            Console.WriteLine("Account Type: " + type);
            Console.WriteLine("Account Number: " + AcctNumb);
            Console.WriteLine("Routing Number: " + Routing);
            Console.WriteLine("Total Balance: " + Balance);
            
        }
        
    }
}
