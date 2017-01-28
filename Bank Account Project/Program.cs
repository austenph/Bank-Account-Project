using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bank_Account_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Below our my StreamWriter files for each account type:
            //checkings
            StreamWriter checkingsummary = new StreamWriter("CheckingSummary.txt");
            using (checkingsummary)
            {
                checkingsummary.WriteLine("Checking Account" + DateTime.Now.ToShortTimeString());
            }
            //reserve
            StreamWriter reservesummary = new StreamWriter("ReserveSummary.txt");
            using (reservesummary)
            {
                reservesummary.WriteLine("Reserve Account" + DateTime.Now.ToShortTimeString());
            }
            //savings
            StreamWriter savingsummary= new StreamWriter("SavingsSummary.txt");
            using (savingsummary)
            {
                savingsummary.WriteLine("Savings Account" + DateTime.Now.ToShortTimeString());
            }
            //instantiating objects for my children classes
            Account client = new Account();
            Checking checking = new Checking();
            Reserve reserve = new Reserve();

            client.AccountNumb();
            client.ClientInfo();
            
            client.DisplayBalance();
            client.Transaction = 5;
            client.Withdrawal();
            client.DisplayBalance();

            //Menu
        }
    }
}
