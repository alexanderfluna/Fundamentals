using System;

namespace TestingProject
{
    public class TimeDepositAccount : BankAccount, Reservable
    {
        public TimeDepositAccount(double initialBalance, double interestRate, int monthsToMaturity) : base(initialBalance)
        {
            this.interestRate = interestRate;
            this.monthsToMaturity = monthsToMaturity;
        }

        public override void EndOfMonth()
        {
            if (monthsToMaturity > 0)
            {
                double interest = GetBalance() * (interestRate / 100);
                Deposit(interest);
                monthsToMaturity--;
            }
        }

        public void Reserve(double amount)
        {
            AssertNonNegative(amount);
            reservedAmount += amount;
        }

        public void Release(double amount)
        {
            AssertNonNegative(amount);
            reservedAmount -= amount;
        }

        public double GetMeasure()
        {
            return GetBalance() - reservedAmount;
        }

        public override void Withdraw(double amount)
        {
            if (monthsToMaturity > 0)
            {
                Console.WriteLine("\tEarly withdrawal penalty charged.");
                base.Withdraw(amount * PENALTY_RATE);
            }
            else
            {
                base.Withdraw(amount);
            }
        }

        private int monthsToMaturity;
        private double interestRate;
        private const double PENALTY_RATE = 0.1; // 10% penalty rate for early withdrawal
        private double reservedAmount;
    }
}
