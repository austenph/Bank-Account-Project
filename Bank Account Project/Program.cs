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
            //OBJECT INSTANTIATING
            Account client = new Account();//establishing our one client

            Checking checking = new Checking(2000);//checking account
            checking.AccountNumb();
            Reserve reserve = new Reserve(500);//reserve account
            reserve.AccountNumb();
            Savings savings = new Savings(18000);//savings account
            savings.AccountNumb();

            //CLIENT AND ACCOUNT NAME STRING PARAMETERS FOR STREAMWRITER
            string streamcheckingaccount = ("Account Number: " + checking.AcctNumber);
            string streamreserveaccount = ("Account Number: " + reserve.AcctNumber);
            string streamsavingsaccount = ("Account Number: " + savings.AcctNumber);
            string streamclientinfo = (client.ClientInfo());
            string checkingaccounttype = (checking.AccountType);
            string reserveaccounttype = (reserve.AccountType);
            string savingsaccounttype = (savings.AccountType);

            using (StreamWriter checkingsummary = new StreamWriter("CheckingSummary.txt", true))
            {
                checkingsummary.WriteLine(checkingaccounttype);
                checkingsummary.WriteLine(streamclientinfo);
                checkingsummary.WriteLine(streamcheckingaccount);

            }
            using (StreamWriter reservesummary = new StreamWriter("ReserveSummary.txt", true))
            {
                reservesummary.WriteLine(reserveaccounttype);
                reservesummary.WriteLine(streamclientinfo);
                reservesummary.WriteLine(streamreserveaccount);

            }
            using (StreamWriter savingsummary = new StreamWriter("SavingsSummary.txt", true))
            {
                savingsummary.WriteLine(savingsaccounttype);
                savingsummary.WriteLine(streamclientinfo);
                savingsummary.WriteLine(streamcheckingaccount);
            }

            bool test = false;//way to break out of menu do-while loop

            do
            {
                //PARAMETERS FOR STREAMWRITER THAT ARE TO BE DONE INSIDE OF THE LOOP
                string checkingDepositPara = ($"Transaction: +${checking.Deposit} at {DateTime.Now.ToString()} Current Balance: ${checking.Bal}");
                string checkingWithdrawalPara = ($"Transaction: -${checking.Withdrawal} at {DateTime.Now.ToString()} Current Balance: ${checking.Bal}");
                string reserveDepositPara = ($"Transaction: +${reserve.Deposit} at {DateTime.Now.ToString()} Current Balance: ${reserve.Bal}");
                string reserveWithdrawalPara = ($"Transaction: -${reserve.Withdrawal} at {DateTime.Now.ToString()} Current Balance: ${reserve.Bal}");
                string savingsDepositPara = ($"Transaction: +${savings.Deposit} at {DateTime.Now.ToString()} Current Balance: ${savings.Bal}");
                string savingsWithdrawalPara = ($"Transaction: -${savings.Withdrawal} at {DateTime.Now.ToString()} Current Balance: ${savings.Bal}");

                //INSTANTIATING STREAMWRITER FILES
                //checking
                using (StreamWriter checkingAccountStreamSummary = new StreamWriter("CheckingSummary.txt", true))
                {
                    if (checking.Deposit > 0)
                    {
                        checkingAccountStreamSummary.WriteLine(checkingDepositPara);
                        checking.Deposit = 0;
                    }
                    if (checking.Withdrawal > 0)
                    {
                        checkingAccountStreamSummary.WriteLine(checkingWithdrawalPara);
                        checking.Withdrawal = 0;
                    }
                }
                //reserve
                using (StreamWriter reserveAccountStreamSummary = new StreamWriter("ReserveSummary.txt", true))
                {
                    if (reserve.Deposit > 0)
                    {
                        reserveAccountStreamSummary.WriteLine(reserveDepositPara);
                        reserve.Deposit = 0;
                    }
                    if (reserve.Withdrawal > 0)
                    {
                        reserveAccountStreamSummary.WriteLine(reserveWithdrawalPara);
                        reserve.Withdrawal = 0;
                    }
                }
                //savings
                using (StreamWriter savingsAccountStreamSummary = new StreamWriter("SavingsSummary.txt", true))
                {
                    if (savings.Deposit > 0)
                    {
                        savingsAccountStreamSummary.WriteLine(savingsDepositPara);
                        savings.Deposit = 0;
                    }
                    if (savings.Withdrawal > 0)
                    {
                        savingsAccountStreamSummary.WriteLine(savingsWithdrawalPara);
                        savings.Withdrawal = 0;
                    }
                }
                //MENU ONLINE BANKING-- this menu is a do-while loop with a nested switch statement.
                //Choices are Client Info, Account Info for each account type, Deposit (for each), Withdrawal (for each), or Exit. 

                Console.WriteLine("Hit Enter to Display Banking Menu");
                Console.ReadLine();

                client.DisplayMenu();//the online banking menu
                string userchoice = Console.ReadLine();//user input from menu options

                switch (userchoice.ToUpper())
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
                        Console.WriteLine("Reserve Account Balance: $" + reserve.Bal);
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
                        reserve.DepositBalance(reserve.Deposit);
                        break;
                    case "3C":
                        Console.Clear();//Savings Account Deposit
                        Console.WriteLine("How much would you like to deposit?");
                        savings.Deposit = double.Parse(Console.ReadLine());
                        Console.WriteLine("You deposited: $" + savings.Deposit);
                        savings.DepositBalance(savings.Deposit);
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
                        reserve.WithBalance(reserve.Withdrawal);
                        break;
                    case "4C":
                        Console.Clear(); //Savings Account Withdrawal
                        Console.WriteLine("How much would you like to withdraw?");
                        savings.Withdrawal = double.Parse(Console.ReadLine());
                        Console.WriteLine("You withdrew: $" + savings.Withdrawal);
                        savings.WithBalance(savings.Withdrawal);
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
            } while (!test);
        }
    }
}
