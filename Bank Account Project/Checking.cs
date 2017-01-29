using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    class Checking : Account
    {
        //field

        private double minBalance;
        private double maxBalance;


        //properties
        public double MinBalance
        { get { return this.minBalance; } }

        public double MaxBalance
        { get { return this.maxBalance; } }


        //constructors

        public Checking(double balance) : base()
        {
            this.minBalance = 500;
            this.maxBalance = 1000000000000;
            this.balance = balance;
            accountType = "Checking Account";
        }

        //methods
    }
}