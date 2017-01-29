using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    class Reserve : Account
    {
        //fields
        private string wishlist;
        private int interest;

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
        public Reserve(double balance) : base()
        {
            this.interest = 3;
            this.balance = balance;
        }
        //methods
    }
}
