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
                do
                {
                    Console.WriteLine("Please enter your 9 digit account number");
                    int enteredNumber = Convert.ToInt32(Console.ReadLine());
                    if (enteredNumber == accountNumber)
                    {
                        //TODO 2. add do-while loop & If-statment for PIN Number attempt
                        #region PIN Number Login
                       
                        int pinNumberAttempt = 0;
                       
                        do
                        {
                            Console.WriteLine("Please enter your 4 digit PIN");
                            int enteredPIN = Convert.ToInt32(Console.ReadLine());
                            if (enteredPIN == accountPIN)
                            {
                                Console.Clear();
                                //TODO 3. Create MainMenu for ATM
                                bool mainMenu = true;
                                do
                                {
                                    Console.WriteLine("Please Select one of the following options: ");
                                    Console.WriteLine("\n(1)Check Account Balance" +
                                        "\n(2) Make Deposit" + 
                                        "\n(3) Make Withdrawl" +
                                        "\n(4) Make Transfer" +
                                        "\n(5) Exit");

                                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                                    Console.Clear();

                                    //TODO 4. Create Switch statement for users choice
                                    #region userChoice Switch Statement

                                    #endregion
                                } while (mainMenu);
                                
                               
                            }
                            else
                            {
                                Console.WriteLine("Pin number entered is incorrect. Please try again.");
                                pinNumberAttempt++;
                                if (pinNumberAttempt >= 3)
                                {
                                    Console.WriteLine("Too many failed attempts. Your account has been locked.");
                                    accountNumberAttempt = 4;
                                    repeat = false;
                                   
                                }
                            }
                            
                        } while (pinNumberAttempt < 3 );
                       
                        #endregion

                    }//end Account Number IF statement
                    else
                    {
                        Console.WriteLine("Account number entered is incorrect. Please try again.");
                        accountNumberAttempt++;
                        if (accountNumberAttempt >= 3)
                        {
                            Console.WriteLine("Too many failed attempts. Your account has been locked.");
                            repeat = false;
                        }
                    }//end account number else statement
                    
                } while (accountNumberAttempt < 3);
                #endregion
            } while (repeat);//end Do-While (entire application)
        }//end Main()
    }//end class Program
}//end namespace
