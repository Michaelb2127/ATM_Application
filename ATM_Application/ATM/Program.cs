using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            
            decimal savingsBalance = 0m;
            decimal checkingBalance = 0m;
            //Account number and PIN would not be hard-coded in real-world application
            int accountNumber = 123456789;
            int accountPIN = 1234;
            
            do
            {
                //TODO 1. Add do-while loop & If-statement for Acc. Number attempt   
                #region Account Number Login
                int accountNumberAttempt = 0;
                bool accountNum = true;
                do
                {
                    Console.WriteLine("Please enter your 9 digit account number");
                    //int enteredNumber = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        int enteredNumber = Convert.ToInt32(Console.ReadLine());
                        if (enteredNumber == accountNumber)
                        {
                            //TODO 2. add do-while loop & If-statment for PIN Number attempt
                            #region PIN Number Login
                            Console.Clear();
                            int pinNumberAttempt = 0;
                            bool pin = true;
                            do
                            {

                                Console.WriteLine("Please enter your 4 digit PIN");
                                try
                                {
                                    int enteredPIN = Convert.ToInt32(Console.ReadLine());
                                    if (enteredPIN == accountPIN)
                                    {
                                        Console.Clear();
                                        //TODO 3. Create MainMenu for ATM
                                        bool mainMenu = true;
                                        do
                                        {
                                            Console.WriteLine("Please Select one of the following options: ");
                                            Console.WriteLine("(1) Check Account Balance" +
                                                "\n(2) Make Deposit" +
                                                "\n(3) Make Withdrawl" +
                                                "\n(4) Make Transfer" +
                                                "\n(5) Exit");

                                            ConsoleKey userChoice = Console.ReadKey(true).Key;
                                            Console.Clear();

                                            //TODO 4. Create Switch statement for users choice
                                            #region userChoice Switch Statement
                                            switch (userChoice)
                                            {
                                                //two cases for each in case user enters number keys or number pad (Possibly not needed for real world ATM)
                                                case ConsoleKey.D1:
                                                case ConsoleKey.NumPad1:
                                                    Console.WriteLine("Account Balances");
                                                    #region Account Balances
                                                    //TODO 5. Create Do-While loop for accounts
                                                    bool account = true;
                                                    do
                                                    {
                                                        //TODO 6. Ask user what account they would like to check balance (Checking or Savings)
                                                        Console.WriteLine("\nWhich account would you like to check?");
                                                        Console.WriteLine("(1) Checking" +
                                                            "\n(2) Savings" +
                                                            "\n(3) Go Back");
                                                        //TODO 7. Read user's input and Create Switch statement for user's choice (Checking or savings)
                                                        ConsoleKey accountChoice = Console.ReadKey(true).Key;
                                                        Console.Clear();
                                                        switch (accountChoice)
                                                        {
                                                            case ConsoleKey.D1:
                                                            case ConsoleKey.NumPad1:
                                                                Console.WriteLine($"Your checking account has a balance of: {checkingBalance:c}");
                                                                account = false;
                                                                break;
                                                            case ConsoleKey.D2:
                                                            case ConsoleKey.NumPad2:
                                                                Console.WriteLine($"Your savings account has a balance of {savingsBalance:c}");
                                                                account = false;
                                                                break;
                                                            case ConsoleKey.D3:
                                                            case ConsoleKey.NumPad3:
                                                                account = false;
                                                                break;
                                                            default:
                                                                Console.WriteLine("Please choose a valid option");
                                                                break;
                                                        }
                                                    } while (account);

                                                    #endregion
                                                    break;

                                                case ConsoleKey.D2:
                                                case ConsoleKey.NumPad2:
                                                    Console.WriteLine("Make Deposit");
                                                    #region Make Deposit
                                                    //TODO 8. Create Do-While loop for accounts
                                                    bool deposit = true;
                                                    do
                                                    {
                                                        //TODO 9. Ask user what account they would like to deposit into & how much (Checking or Savings)
                                                        Console.WriteLine("Which account would you like to make a deposit?");
                                                        Console.WriteLine("(1) Checking" +
                                                            "\n(2) Savings" +
                                                            "\n(3) Go Back");
                                                        //TODO 10. Read user's input and Create Switch statement for user's choice (Checking or savings)
                                                        ConsoleKey accountChoice = Console.ReadKey(true).Key;
                                                        Console.Clear();
                                                        switch (accountChoice)
                                                        {
                                                            case ConsoleKey.D1:
                                                            case ConsoleKey.NumPad1:
                                                                #region Checking Deposit
                                                                Console.WriteLine("Please enter the amount you would like to deposit into your Checking account: ");
                                                                string requestedCheckingDeposit = Console.ReadLine();
                                                                decimal amountToDepositChecking = Convert.ToDecimal(requestedCheckingDeposit);
                                                                checkingBalance += amountToDepositChecking;
                                                                //TODO 11. Show confirmation or error message
                                                                //NOTE: In future, handle error if user types in letter characters instead of number digits 
                                                                Console.Clear();
                                                                Console.WriteLine("{0:c} has been deposited into your checking account", amountToDepositChecking);
                                                                //String Formatting used vs String Interpolation, only to demonstrate knowledge of both
                                                                deposit = false;
                                                                #endregion
                                                                break;
                                                            case ConsoleKey.D2:
                                                            case ConsoleKey.NumPad2:
                                                                #region Savings Deposit
                                                                Console.WriteLine("Please enter the amount you would like to deposit into your Savings account: ");
                                                                string requestedDepositSavings = Console.ReadLine();
                                                                decimal amountToDepositSavings = Convert.ToDecimal(requestedDepositSavings);
                                                                savingsBalance += amountToDepositSavings;
                                                                Console.Clear();
                                                                Console.WriteLine($"{amountToDepositSavings:c} has been deposited into your savings account");
                                                                deposit = false;
                                                                #endregion
                                                                break;
                                                            case ConsoleKey.D3:
                                                            case ConsoleKey.NumPad3:
                                                                deposit = false;
                                                                break;
                                                            default:
                                                                Console.WriteLine("Please choose a valid option");
                                                                break;
                                                        }//end Deposit Choice

                                                    } while (deposit);
                                                    #endregion
                                                    break;
                                                case ConsoleKey.D3:
                                                case ConsoleKey.NumPad3:
                                                    Console.WriteLine("Make Withdrawl");
                                                    #region Make Withdrawl
                                                    //TODO 12. Create Do-While loop for accounts
                                                    bool withdrawl = true;
                                                    do
                                                    {
                                                        //TODO 13. Ask user what account they would like to withdrawl from & how much (Checking or Savings)
                                                        Console.WriteLine("Which account would you like to withdrawl from?");
                                                        Console.WriteLine("(1) Checking" +
                                                            "\n(2) Savings" +
                                                            "\n(3) Go Back");
                                                        //TODO 14.Read user's input and Create Switch statement for user's choice (Checking or savings)
                                                        ConsoleKey accountChoice = Console.ReadKey(true).Key;
                                                        Console.Clear();
                                                        switch (accountChoice)
                                                        {
                                                            case ConsoleKey.D1:
                                                            case ConsoleKey.NumPad1:
                                                                #region Checking Withdrawl
                                                                Console.WriteLine($"You have {checkingBalance:c} in your checking account.");
                                                                Console.WriteLine("How much would you like to withdrawl from your checking account? ");
                                                                string requestedWithdrawlChecking = Console.ReadLine();
                                                                decimal amountToWithdrawlChecking = Convert.ToDecimal(requestedWithdrawlChecking);
                                                                Console.Clear();
                                                                //TODO 15. Show confirmation or error message
                                                                if (amountToWithdrawlChecking <= checkingBalance)
                                                                {
                                                                    checkingBalance -= amountToWithdrawlChecking;

                                                                    Console.WriteLine($"{amountToWithdrawlChecking:c} has been successfully withdrawn from your checking account");
                                                                    withdrawl = false;
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($"Error. Your withdrawl of {amountToWithdrawlChecking:c} could not be completed due to insuffienct funds in your checking account");
                                                                    withdrawl = false;
                                                                }
                                                                #endregion
                                                                break;
                                                            case ConsoleKey.D2:
                                                            case ConsoleKey.NumPad2:
                                                                #region Savings Withdrawl
                                                                Console.WriteLine($"You have {savingsBalance:c} in your savings account.");
                                                                Console.WriteLine("How much would you like to withdrawl from your savings account? ");
                                                                string requestedWithdrawlSavings = Console.ReadLine();
                                                                decimal amountToWithdrawlSavings = Convert.ToDecimal(requestedWithdrawlSavings);
                                                                Console.Clear();
                                                                if (amountToWithdrawlSavings <= savingsBalance)
                                                                {
                                                                    savingsBalance -= amountToWithdrawlSavings;
                                                                    Console.WriteLine($"{amountToWithdrawlSavings:c} has been successfully withdrawn from your savings account.");
                                                                    withdrawl = false;
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($"Error. Your withdrawl of {amountToWithdrawlSavings:c} could not be completed due to insuffient funds in your savings account.");
                                                                    withdrawl = false;
                                                                }
                                                                #endregion
                                                                break;
                                                            case ConsoleKey.D3:
                                                            case ConsoleKey.NumPad3:
                                                                withdrawl = false;
                                                                break;
                                                            default:
                                                                Console.WriteLine("Please choose one of the given options");
                                                                break;
                                                        }

                                                    } while (withdrawl);
                                                    #endregion
                                                    break;
                                                case ConsoleKey.D4:
                                                case ConsoleKey.NumPad4:
                                                    #region Make Transfer
                                                    Console.WriteLine("Make Transfer");
                                                    //TODO 16. Create Do-While loop for accounts 
                                                    bool transfer = true;
                                                    do
                                                    {
                                                        //TODO 17. Ask user what account they would like to transfer to and from & how much (Checking to Savings or Savings to Checking)
                                                        Console.WriteLine("Which account would you like to transfer from?");
                                                        Console.WriteLine("(1) Checking to Savings" +
                                                            "\n(2) Savings to Checking" +
                                                            "\n(3) Go back");
                                                        //TODO 18. Read user's input and Create Switch statement for user's choice (Checking or savings)
                                                        ConsoleKey transferChoice = Console.ReadKey(true).Key;
                                                        Console.Clear();
                                                        switch (transferChoice)
                                                        {
                                                            case ConsoleKey.D1:
                                                            case ConsoleKey.NumPad1:
                                                                #region Checking to Savings
                                                                Console.WriteLine($"You have {checkingBalance:c} in your checking account.");
                                                                Console.WriteLine("How much would you like to transfer from your checking account? ");
                                                                string requestedTransferToSavings = Console.ReadLine();
                                                                decimal transferToSavings = Convert.ToDecimal(requestedTransferToSavings);
                                                                if (transferToSavings <= checkingBalance)
                                                                {
                                                                    Console.Clear();
                                                                    checkingBalance -= transferToSavings;
                                                                    savingsBalance += transferToSavings;
                                                                    Console.WriteLine($"{transferToSavings:c} has been successfully transferred to your savings account from your checking account");
                                                                    transfer = false;
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine($"Error. Your transfer of {transferToSavings:c} could not be completed due to insuffienct funds in your checking account");
                                                                    transfer = false;
                                                                }
                                                                #endregion
                                                                break;
                                                            case ConsoleKey.D2:
                                                            case ConsoleKey.NumPad2:
                                                                #region Savings to Checking
                                                                Console.WriteLine($"You have {savingsBalance:c} in your savings account.");
                                                                Console.WriteLine("How much would you like to transfer from your savings account?");
                                                                string requestedTransferToChecking = Console.ReadLine();
                                                                decimal transferToChecking = Convert.ToDecimal(requestedTransferToChecking);
                                                                //TODO 19. Show confirmation or error message
                                                                if (transferToChecking <= savingsBalance)
                                                                {
                                                                    Console.Clear();
                                                                    savingsBalance -= transferToChecking;
                                                                    checkingBalance += transferToChecking;
                                                                    Console.WriteLine($"{transferToChecking:c} has been successfully transferred to your checking account from your savings account.");
                                                                    transfer = false;
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine($"Error. Your transfer of {transferToChecking:c} could not be completed due to insuffienct funds in your savings account.");
                                                                    transfer = false;
                                                                }
                                                                #endregion
                                                                break;
                                                            case ConsoleKey.D3:
                                                            case ConsoleKey.NumPad3:
                                                                transfer = false;
                                                                break;
                                                            default:
                                                                Console.WriteLine("Please choose one of the given options");
                                                                break;
                                                        }

                                                    } while (transfer);

                                                    #endregion

                                                    break;
                                                case ConsoleKey.D5:
                                                case ConsoleKey.NumPad5:
                                                    Console.WriteLine("Thank you for using this ATM");
                                                    mainMenu = false;
                                                    repeat = false;
                                                    break;
                                                default:
                                                    Console.WriteLine("Please choose one of the given options");
                                                    break;
                                            }
                                            #endregion
                                        } while (mainMenu);

                                        pin = false;
                                    }//End PIN if statement
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Pin number entered is incorrect. Please try again.");
                                        pinNumberAttempt++;
                                        if (pinNumberAttempt >= 3)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Too many failed attempts. Your account has been locked.");
                                            accountNumberAttempt = 4;
                                            repeat = false;

                                        }
                                    }//end PIN else statement
                                }
                                catch (OverflowException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Please enter only a 4 digit value");
                                    pinNumberAttempt++;
                                }
                                catch (FormatException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Please enter only a 4 digit value");
                                    accountNumberAttempt++;

                                }
                                if (pinNumberAttempt >= 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Too many failed attempts. Your account has been locked.");
                                    accountNumberAttempt = 4;
                                    repeat = false;

                                }


                            } while (pinNumberAttempt < 3 && pin);

                            #endregion
                            accountNum = false;
                        }//end Account Number IF statement

                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Account number entered is incorrect. Please try again.");
                            accountNumberAttempt++;
                            if (accountNumberAttempt >= 3)
                            {
                                Console.Clear();
                                Console.WriteLine("Too many failed attempts. Your account has been locked.");
                                repeat = false;
                            }
                        }//end account number else statement
                    }
                    catch (OverflowException)
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter only a 9 digit value");
                        accountNumberAttempt++;
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter only a 9 digit value");
                        accountNumberAttempt++;
                       
                    }
                    if (accountNumberAttempt >= 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Too many failed attempts. Your account has been locked.");
                        repeat = false;
                    }



                } while (accountNumberAttempt < 3 && accountNum);
                #endregion
            } while (repeat);//end Do-While (entire application)
        }//end Main()
    }//end class Program
}//end namespace
