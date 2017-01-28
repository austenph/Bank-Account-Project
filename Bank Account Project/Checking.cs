using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    class Checking:Account
    {
        //fields
        private string accountLevel;
        private int minBalance;
        private double maxBalance;
  
        //properties

        public int MinBalance
        {
            get { return this.minBalance; }
        }
        public double MaxBalance
        {
            get { return this.maxBalance; }
        }

        //constructors

        public Checking():base()
        {
            this.accountLevel = "Presidental Performance Select";
            this.minBalance = 500;
            this.maxBalance=1000000000000;
            this.balance = 487000;
            this.type = "Checkings";

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
        public override void ClientInfo()
        {
            base.ClientInfo();
            Console.WriteLine("Checking Account Type: " + accountLevel);
            Console.WriteLine("Minimum Balance Required: $" + minBalance);
        }
    }
}
