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
        private string warning;

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
        public string Warning
        {
            get { return this.warning; }
        }
        //constructors
        public Reserve():base()
        {
            this.interest = 3;
            warning = "Your balance is low.";
        }
        //methods
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
