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
        private int routingNumber;
        private double accountNumber;
        private int balance;

        //properties
        public int Routing
        {
            get { return this.routingNumber;}
        }
        //constructors
        public Account ()
        {

        }
        //methods
        public virtual double AccountNumb()
        {
            Random rand = new Random();
            this.accountNumber =rand.Next(100000000, 1000000000);
            return accountNumber;
        }
    }
}
