// Alexander Luna | Assignment 2 | Problem 3
using System;

namespace TestingProject
{
    /// <summary>
    /// The time deposit account is like a savings account, but you promise to
    /// leave the money in the account for a particular number of months, and
    /// there is a penalty for early withdrawal.
    /// Make all subclasses of BankAccount implement the Reservable interface
    /// </summary>
    public class TimeDepositAccount : BankAccount, Reservable
    {
        /// Constructs a time deposit account with an initial balance, interest rate, and months to maturity
		/// @param initialBalance the initial balance
		/// @param interestRate the interest rate
        /// @param monthsToMaturity the months to maturity
        public TimeDepositAccount(double initialBalance, double interestRate, int monthsToMaturity) : base(initialBalance)
        {
            // Initialize fields
            this.interestRate = interestRate;
            this.monthsToMaturity = monthsToMaturity;
            this.reservedAmount = 0;
        }

        /// Constructs a time deposit account with an initial balance, interest rate, months to maturity, and reserved amount
		/// @param initialBalance the initial balance
		/// @param interestRate the interest rate
        /// @param monthsToMaturity the months to maturity
        /// @param reservedAmount the reserved amount
        public TimeDepositAccount(double initialBalance, double interestRate, int monthsToMaturity, double reservedAmount) : base(initialBalance)
        {
            // Initialize fields
            this.interestRate = interestRate;
            this.monthsToMaturity = monthsToMaturity;
            this.reservedAmount = reservedAmount;
        }

        /// Withdraws money from the account
        /// @param amount the amount to be withdrawn
        public override void Withdraw(double amount)
        {
            // If there are remaining months to maturity
            if (monthsToMaturity > 0)
            {
                // Withdraw the money plus a penalty rate
                Console.WriteLine("\tEarly withdrawal penalty of 10% charged:");
                base.Withdraw(amount += amount * PENALTY_RATE);
            }
            else
            {
                // Else withdraw the money
                base.Withdraw(amount);
            }
        }

        /// Adds the earned interest to the account balance
        /// Decrement the count of months
        public override void EndofMonth()
        {
            // If there are remaining months to maturity
            if (monthsToMaturity > 0)
            {
                double interest = GetBalance() * (interestRate / 100); // calculate the interest
                Deposit(interest);  // deposit the interest
                monthsToMaturity--; // decrement the months
            }
        }

        /// Ensures that after the call, GetMeasure() will return a measure as least 
		/// as large as the argument of Reserve() (reserved amount) until Release() is called
        /// @param amount the amount to be reserved
		public void Reserve(double amount)
        {
            // Verify the amount is non-negative
            if (amount < 0)
                throw new ArgumentException("\tTRANSACTION FAILED: Amount must be non-negative");

            // Verify there is enough balance to reserve
            if (GetMeasure() - reservedAmount < amount)
                throw new InvalidOperationException("\tTRANSACTION FAILED: Not enough balance to reserve");

            // Add the amount to the reserved amount
            reservedAmount += amount;
        }

        /// Release() will reduce the reserved amount with the value of its argument
        public void Release(double amount)
        {
            // Verify the amount is non-negative
            if (amount < 0)
                throw new ArgumentException("\tTRANSACTION FAILED: Amount must be non-negative");

            // Verify there is enough reserved amount to release
            if (reservedAmount < amount)
                throw new InvalidOperationException("\tTRANSACTION FAILED: Cannot release more than amount reserved");

            // Release the amount from the reserved amount
            reservedAmount -= amount;
        }

        /// Calls the base method GetBalance()
        /// @return the account's balance
        public double GetMeasure()
        {
            return GetBalance();
        }

        private int monthsToMaturity;
        private readonly double interestRate;
        private const double PENALTY_RATE = 0.1; // 10% penalty rate for early withdrawal
        private double reservedAmount;
    }
}