using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    class Checking:Account
    {
        //field
        private double minBalance;
        private double maxBalance;

  
        //properties
        public double MinBalance
        { get { return this.minBalance; }}

        public double MaxBalance
        { get { return this.maxBalance; } }


        //constructors

        public Checking():base()
        {
            this.minBalance = 500;
            this.maxBalance=1000000000000;
        }

        //methods
        //random account number assigned
        public override double AccountNumb()
        {
            return base.AccountNumb();
        }
        //keeps track of balance
        public override double Balance()
        {
            return base.Balance();
        }
        public override double DepositBalance(double input)
        {
            return base.DepositBalance(input);
        }
        public override double StoreDeposit(double input)
        {
            return base.StoreDeposit(input);
        }

    }
}