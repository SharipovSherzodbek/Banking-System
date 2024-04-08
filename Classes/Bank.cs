using System;
using System.Collections.Generic;

namespace Banking_System.Classes
{
    public class Bank
    {
        private List<Client> clients = new List<Client>();

        public void CreateCustomerAccount()
        {
            Console.WriteLine("Enter client name:");
            string clientName = Console.ReadLine();

            Console.WriteLine("Create bank account number...");
            int bankAccountNumber;
            if (!int.TryParse(Console.ReadLine(), out bankAccountNumber))
            {
                Console.WriteLine("Invalid format! Please enter an integer!");
                return;
            }

            BankAccount customerAccount = new BankAccount();
            customerAccount.BankAccountNumber = bankAccountNumber;
            clients.Add(new Client { Name = clientName, BankAccountNumber = bankAccountNumber });
            Console.WriteLine("Customer account created successfully!");
        }

        public void CloseCustomerAccount(int bankAccountNumber)
        {
            Client client = clients.Find(c => c.BankAccountNumber == bankAccountNumber);
            if (client != null)
            {
                clients.Remove(client);
                Console.WriteLine($"Customer account {bankAccountNumber} closed successfully!");
            }
            else
            {
                Console.WriteLine("No customer account found!");
            }
        }

        public void PerformTransactions(int bankAccountNumber)
        {
            BankAccount customerAccount = clients.Find(c => c.BankAccountNumber == bankAccountNumber)?.BankAccount;
            if (customerAccount == null)
            {
                Console.WriteLine("No customer account found!");
                return;
            }

            Console.WriteLine("Enter amount of money to transfer...");
            int transferAmount;
            if (!int.TryParse(Console.ReadLine(), out transferAmount))
            {
                Console.WriteLine("Invalid format! Please enter an integer");
                return;
            }

            if (customerAccount.Balance >= transferAmount)
            {
                customerAccount.Balance -= transferAmount;
                Console.WriteLine($"Transaction completed successfully! Your new balance is: {customerAccount.Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }

        public void MakeDeposit(int bankAccountNumber)
        {
            BankAccount customerAccount = clients.Find(c => c.BankAccountNumber == bankAccountNumber)?.BankAccount;
            if (customerAccount == null)
            {
                Console.WriteLine("No customer account found!");
                return;
            }

            Console.WriteLine("Enter amount of money to deposit...");
            int depositAmount;
            if (!int.TryParse(Console.ReadLine(), out depositAmount))
            {
                Console.WriteLine("Invalid format! Please enter an integer");
                return;
            }

            customerAccount.Balance += depositAmount;
            Console.WriteLine($"Deposit of {depositAmount} successfully made. Your new balance is: {customerAccount.Balance}");
        }

        public void WithdrawMoney(int bankAccountNumber)
        {
            BankAccount customerAccount = clients.Find(c => c.BankAccountNumber == bankAccountNumber)?.BankAccount;
            if (customerAccount == null)
            {
                Console.WriteLine("No customer account found!");
                return;
            }

            Console.WriteLine("Enter amount of money to withdraw...");
            int withdrawAmount;
            if (!int.TryParse(Console.ReadLine(), out withdrawAmount))
            {
                Console.WriteLine("Invalid format! Please enter an integer");
                return;
            }

            if (withdrawAmount <= customerAccount.Balance)
            {
                customerAccount.Balance -= withdrawAmount;
                Console.WriteLine($"Withdrawal of {withdrawAmount} successfully made. Your new balance is: {customerAccount.Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }
    }
}