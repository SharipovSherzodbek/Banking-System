using System;
using System.Collections.Generic;

namespace Banking_System.Classes
{
    public class BankAccount
    {
        public int BankAccountNumber { get; set; }
        public int Balance { get; set; }

        public BankAccount()
        {
            Balance = 0;
        }
    }   
}