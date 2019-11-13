using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.UI
{
    public class Account
    {
        public Account(decimal balance)
        {
            this.Balance = balance;
        }

        public decimal Balance { get; private set; }

        public void Deposit(decimal depositAmount)
        {
            if (depositAmount < 0) throw new ArgumentOutOfRangeException(nameof(depositAmount), "depositAmmount must be positive");

            Balance = Balance + depositAmount;
        }
    }
}
