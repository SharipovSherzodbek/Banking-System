using System;
using System.Collections.Generic;
namespace Banking_System.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Universal Bank");

            Bank bank = new Bank();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("1. Create Customer Account");
                Console.WriteLine("2. Perform Transactions");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Make Deposit");
                Console.WriteLine("5. Close Customer Account");
                Console.WriteLine("6. Exit");

                Console.WriteLine("Enter your choice:");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice! Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        bank.CreateCustomerAccount();
                        break;
                    case 2:
                        Console.WriteLine("Enter bank account number:");
                        int accountNumber;
                        if (!int.TryParse(Console.ReadLine(), out accountNumber))
                        {
                            Console.WriteLine("Invalid account number! Please enter a number.");
                            continue;
                        }
                        bank.PerformTransactions(accountNumber);
                        break;
                    case 3:        
                        Console.WriteLine("Enter bank account number to withdraw:");
                        int accountToWithdraw;
                        if (!int.TryParse(Console.ReadLine(), out accountToWithdraw))
                        {
                            Console.WriteLine("Invalid account number! Please enter a number.");
                            continue;
                        }
                        bank.WithdrawMoney(accountToWithdraw);
                        break;
                    case 4:
                        Console.WriteLine("Enter bank account number to deposit:");
                        int accountToDeposit;
                        if (!int.TryParse(Console.ReadLine(), out accountToDeposit))
                        {
                            Console.WriteLine("Invalid account number! Please enter a number.");
                            continue;
                        }
                        bank.MakeDeposit(accountToDeposit);
                        break;
                    case 5:
                        Console.WriteLine("Enter bank account number to close:");
                        int accountToClose;
                        if (!int.TryParse(Console.ReadLine(), out accountToClose))
                        {
                            Console.WriteLine("Invalid account number! Please enter a number.");
                            continue;
                        }
                        bank.CloseCustomerAccount(accountToClose);
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please enter a valid option.");
                        break;
                }
            }

            Console.WriteLine("Thank you for banking with us!");
        }
    }
}
