using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    class Reserve:Account
    {
        //fields
        private string wishlist;
        private int interest;
        protected double reservebalance;

        //properties
        public int Interest
        {
            get { return this.interest; }
            set { this.interest = value; }
        }
        public string Wishlist
        {
            get { return this.wishlist; }
            set { this.wishlist = value; }
        }

        //constructors
        public Reserve():base()
        {
            this.interest = 3;
        }
        //methods
        //account number 
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
