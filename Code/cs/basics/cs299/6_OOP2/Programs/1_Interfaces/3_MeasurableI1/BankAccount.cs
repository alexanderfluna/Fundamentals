using System;

namespace ConsoleApplication
{
    public class BankAccount : MeasurableI
    {
        private double balance; // the bank account's balance

        // Empty constructor
        public BankAccount()
        {
            balance = 0;
        }

        // Constructor with initial balance
        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        // Deposit money into the account
        public void Deposit(double amount)
        {
            balance += amount;
        }

        // Withdraw money from the account
        public void Withdraw(double amount)
        {
            if (amount < balance)
                balance -= amount;
        }

        // Implementing the GetMeasure() function from MeasurableI
        public double GetMeasure()
        {
            return balance;
        }
    }
}