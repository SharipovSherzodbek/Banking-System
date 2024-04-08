using System;
using System.Collections.Generic;

namespace Banking_System.Classes
{
    public class Client
    {
        public string Name { get; set; }
        public int BankAccountNumber { get; set; }
        public BankAccount BankAccount { get; set; } = new BankAccount();
    }
}