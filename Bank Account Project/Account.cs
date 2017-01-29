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

        private double accountNumber;

        protected double balance;
        protected double deposit;
        protected double withdrawal;

        //properties
        public double Withdrawal
        {
            get { return this.withdrawal; }
            set { this.withdrawal = value; }
        }
        public double Deposit
        {
            get { return this.deposit; }
            set { this.deposit = value; }
        }
        public double AcctNumber
        { get { return this.accountNumber; } }

        public double Bal
        { get { return this.balance; } }

        //constructors
        public Account()
        {
            firstName = "Barack";
            lastName = "Obama";
        }

        //methods
        //creates random Account Number
        public virtual double AccountNumb()
        {
            Random rand = new Random();
            this.accountNumber = rand.Next(100000000, 1000000000);
            return accountNumber;
        }

        //Computes General Balance(resets values)
        public virtual double Balance()
        {
            balance = balance + deposit - withdrawal;
            deposit = 0;
            withdrawal = 0;
            return balance;
        }
        //Computers Balance when withdrawal equals zero
        public virtual double DepositBalance(double input)
        {
            deposit = input;
            withdrawal = 0;
            balance = balance + deposit - withdrawal;
            return balance;
        }

        //Computers balance when deposit equals zero
        public virtual double WithBalance(double input)
        {
            withdrawal = input;
            deposit = 0;
            balance = balance + deposit - withdrawal;
            return balance;
        }

        //displays online banking menu
        public virtual void DisplayMenu()
        {
            Console.WriteLine("Fake US Bank Inc.\nWelcome to your online bank account, " + firstName + " " + lastName);
            Console.WriteLine("Please choose from the options below:\n1.View Client Info\n2.View Account Balance:");
            Console.WriteLine("     2A.Checking\n     2B.Reserve\n     2C.Savings");
            Console.WriteLine("3.Deposit Funds:\n     3A.Checking\n     3B.Reserve\n     3C.Savings");
            Console.WriteLine("4.Withdraw Funds:\n     4A.Checking\n     4B.Reserve\n     4C.Savings");
            Console.WriteLine("5.Exit");
        }

        //client info
        public string ClientInfo()
        {
            string clientinfo = ("Account Holder: " + firstName + " " + lastName);
            return clientinfo;
        }
    }
}
