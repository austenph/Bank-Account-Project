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
            //instantiating objects for my children classes
            Account client = new Account();//keeping track of our clients information

            Checking checking = new Checking();
            checking.AccountNumb();

            Reserve reserve = new Reserve();
            reserve.AccountNumb();

            Savings savings = new Savings();
            savings.AccountNumb();

            //menu
            bool test = false;//way to break out of menu loop
            string streamclient = ("Account Number: " + checking.AcctNumber);
            string streamaccount = (client.ClientInfo());
            using (StreamWriter checkingsummary = new StreamWriter("CheckingSummary.txt", true))
            {
                checkingsummary.WriteLine(streamclient);
                checkingsummary.WriteLine(streamaccount);
            }
                do
            {
                List<string> checkDepositList = new List<string>();
                List<string> checkWithdrawalList = new List<string>();
               
                string checkdeposit = ("Transaction: " + "+$" +checking.Deposit+  " at " + DateTime.Now.ToString() + " Current Balance: $" + checking.Bal);
                checkDepositList.Add(checkdeposit);
                string checkwithdraw = ("Transaction: " + "-$" +checking.Withdrawal+ " at " + DateTime.Now.ToString() + " Current Balance: $" + checking.Bal);
                checkWithdrawalList.Add(checkwithdraw);
                string reservedeposit = ("Transaction: " + "+$" + reserve.Deposit + " at " + DateTime.Now.ToString() + " Current Balance: $"+ reserve.Bal);
                string reservewithdraw = ("Transaction: " + "-$" + reserve.Withdrawal+ " at " + DateTime.Now.ToString() + " Current Balance: $"+ reserve.Bal);
                string savingsdeposit = ("Transaction: " + "+$" + savings.Deposit + " at " + DateTime.Now.ToString() + " Current Balance: $" + savings.Bal);
                string savingswithdraw = ("Transaction: " + "-$" + savings.Withdrawal+  " at " + DateTime.Now.ToString() + " Current Balance: $"+savings.Bal);

                using (StreamWriter checkingsummary = new StreamWriter("CheckingSummary.txt",true))
                {
                        if (checking.Deposit > 0)
                    {
                        foreach (string checkingtext in checkDepositList)
                        {
                            checkingsummary.WriteLine(checkingtext);
                        }
                    }
                    if (checking.Withdrawal > 0)
                    {
                        foreach (string checktext in checkWithdrawalList)
                        {
                            checkingsummary.WriteLine(checktext);
                        }
                    }
                }
                //reserve
                StreamWriter reservesummary = new StreamWriter("ReserveSummary.txt", true);
                using (reservesummary)
                {
                    reservesummary.WriteLine(streamclient);
                    reservesummary.WriteLine(streamaccount);
                    reservesummary.WriteLine(checkdeposit);
                    reservesummary.WriteLine(checkwithdraw);
                }
                //savings
                StreamWriter savingsummary = new StreamWriter("SavingsSummary.txt", true);
                using (savingsummary)
                {
                    savingsummary.WriteLine(streamclient);
                    savingsummary.WriteLine(streamaccount);
                    savingsummary.WriteLine(checkdeposit);
                    savingsummary.WriteLine(checkwithdraw);
                }

                Console.WriteLine("Hit Enter to Display Banking Menu");
                Console.ReadLine();

                client.DisplayMenu();//the online banking menu

                string userchoice = Console.ReadLine();//user input from menu options
                switch (userchoice)//menu choices, methods
                {
                    case "1"://Display Client Info
                        Console.Clear();
                        Console.WriteLine(client.ClientInfo());
                        break;
                    case "2A"://Display Checking Account Balance
                        Console.Clear();
                        checking.Balance();
                       Console.WriteLine("Checking Account Balance: $" + checking.Bal);
                        break;
                    case "2B"://Display Checking Account Balance
                        Console.Clear();
                        reserve.Balance();
                        Console.WriteLine("Reserve Account Balance: $" +reserve.Bal);
                        break;
                    case "2C"://Display Savings Account Balance
                        Console.Clear();
                        savings.Balance();
                        Console.WriteLine("Savings Account Balance: $" + savings.Bal);
                        break;
                    case "3A"://Checking Account Deposit
                        Console.Clear();
                        Console.WriteLine("How much would you like to deposit?");
                        checking.Deposit = double.Parse(Console.ReadLine());
                        Console.WriteLine("You deposited: $" + checking.Deposit);
                        checking.DepositBalance(checking.Deposit);
                        break;
                    case "3B":
                        Console.Clear();//Reserve Account Deposit
                        Console.WriteLine("How much would you like to deposit?");
                        reserve.Deposit = double.Parse(Console.ReadLine());
                        Console.WriteLine("You deposited: $" + reserve.Deposit);
                        break;
                    case "3C":
                        Console.Clear();//Savings Account Deposit
                        Console.WriteLine("How much would you like to deposit?");
                        savings.Deposit = double.Parse(Console.ReadLine());
                        Console.WriteLine("You deposited: $" +savings.Deposit);
                        break;
                    case "4A"://Checking Account Withdrawal
                        Console.Clear();
                        Console.WriteLine("How much would you like to withdraw?");
                        checking.Withdrawal = double.Parse(Console.ReadLine());
                        Console.WriteLine("You withdrew: $" + checking.Withdrawal);
                        checking.WithBalance(checking.Withdrawal);
                        break;

                    case "4B":
                        Console.Clear();//Reserve Account Withdrawal
                        Console.WriteLine("How much would you like to withdraw?");
                        reserve.Withdrawal = double.Parse(Console.ReadLine());
                        Console.WriteLine("You withdrew: $" + reserve.Withdrawal);
                        break;
                    case "4C":
                        Console.Clear(); //Savings Account Withdrawal
                        Console.WriteLine("How much would you like to withdraw?");
                        savings.Withdrawal = double.Parse(Console.ReadLine());
                        Console.WriteLine("You withdrew: $" + savings.Withdrawal);
                        break;
                    case "5":
                        Console.Clear();//Exit Banking
                        Console.WriteLine("You have chosen to exit the online banking. Thanks and come again!");
                        Environment.Exit(0);
                        break;
                    default://catch all, breaks the loop
                        Console.Clear();
                        test = false;
                        break;
                }
                //strings that input to the StreamWriter
                //checking
                
            } while (!test);
        }

    }
}
