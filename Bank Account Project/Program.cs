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
            do
            {
                string streamclient = ("Account Number: " + checking.AcctNumber);
                string streamaccount = (client.ClientInfo());
                using (StreamWriter checkingsummary = new StreamWriter("CheckingSummary.txt"))
                {
                    checkingsummary.WriteLine(streamclient);
                    checkingsummary.WriteLine(streamaccount);
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
                        double currentdeposit= checking.Deposit;
                       double currentbal= checking.DepositBalance(currentdeposit);
                        string checkdeposit = ("Transaction: " + "+$" + currentdeposit + " at " + DateTime.Now.ToString() + " Current Balance: $" + currentbal);

                        using (StreamWriter checkingsummary = new StreamWriter("CheckingSummary.txt", true))
                        {
                            checkingsummary.WriteLine(checkdeposit);
                        }
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
                       double currentwithdrawal = checking.Withdrawal;
                        Console.WriteLine("You withdrew: $" + checking.Withdrawal);
                        double currentbalancewith = checking.WithdrawBalance(currentwithdrawal);
                        string checkwithdraw = ("Transaction: " + "-$" + currentwithdrawal + " at " + DateTime.Now.ToString() + " Current Balance: $" + currentbalancewith);
                        
                        using (StreamWriter checkingsummary = new StreamWriter("CheckingSummary.txt", true))
                        {
                            checkingsummary.WriteLine(checkwithdraw);
                        }
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
                //using (StreamWriter checkingsummary = new StreamWriter("CheckingSummary.txt", true))
                //{
                //    checkingsummary.WriteLine(streamclient);
                //    checkingsummary.WriteLine(streamaccount);
                //    checkingsummary.WriteLine(checkdeposit);
                //    checkingsummary.WriteLine(checkwithdraw);
                //}
                //reserve
                StreamWriter reservesummary = new StreamWriter("ReserveSummary.txt", true);
                using (reservesummary)
                {
                    reservesummary.WriteLine("Reserve Account Billy Bob Joe" + DateTime.Now.ToShortTimeString());
                }
                //savings
                StreamWriter savingsummary = new StreamWriter("SavingsSummary.txt");
                using (savingsummary)
                {
                    savingsummary.WriteLine("Savings Account" + DateTime.Now.ToShortTimeString());
                }
            } while (!test);
        }

    }
}
