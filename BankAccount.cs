using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;

        public BankAccount(double amt)
        {
            balance = amt;
        }
        public void Deposit(double amt)
        {
            balance += amt;
        }
        public double GetBalance()
        {
            return balance;
        }
    }
}
