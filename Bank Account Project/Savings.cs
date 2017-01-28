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
        public override double Deposit()
        {
            return base.Deposit();
        }
        public override double Withdrawal()
        {
            return base.Withdrawal();
        }
        public override void DisplayBalance()
        {
            base.DisplayBalance();
        }
    }
}
