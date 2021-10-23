using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestExample
{
    public class BankAccount
    {

        private double balance;

        public BankAccount()
        {

        }
        public BankAccount(double balance)
        {
            this.balance = balance;
        }

        public double getBalance() { return balance; }

        public void witdraw(double amount)
        {

            if (amount > balance)
                throw new ArgumentOutOfRangeException(nameof(amount));

            balance -= amount;
        }

        public void add(double amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount));

            balance += amount;
        }
    }
}
