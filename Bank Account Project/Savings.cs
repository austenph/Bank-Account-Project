using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    class Savings:Account
    {
        //fields
        private int interest2;
        private int minBalance;
        private int timesWithdrawn;
        //properties
        public int Interest2
        {
            get { return this.interest2; }
        }
        private int TimesWithdrawn
        {
            get { return this.timesWithdrawn; }
        }
        //constructors
        public Savings():base()
        {

        }
        public override double AccountNumb()
        {
            return base.AccountNumb();
        }
        public override double Balance( )
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
