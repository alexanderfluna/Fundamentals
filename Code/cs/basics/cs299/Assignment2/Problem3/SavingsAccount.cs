// Alexander Luna | Assignment 2 | Problem 3
using System;

namespace TestingProject
{
	/// <summary>
	/// An account that earns interest at a fixed rate.
	/// </summary>
	/// Make all subclasses of BankAccount implement the Reservable interface
	public class SavingsAccount: BankAccount, Reservable
	{
		/// Constructs a savings account with a given balance and a given interest rate
		/// @param initialBalance the initial balance
		/// @param interestRate the interest rate
		public SavingsAccount(double initialBalance, double interestRate) : base(initialBalance)
        {
			// Initialize fields
			this.interestRate = interestRate;
			this.reservedAmount = 0;
		}

		/// Constructs a savings account with a given balance, given interest rate, and given reserved amount
		/// @param initialBalance the initial balance
		/// @param interestRate the interest rate
		/// 
		public SavingsAccount(double initialBalance, double interestRate, double reservedAmount) : base(initialBalance)	{  
			// Initialize fields
			this.interestRate = interestRate;
			this.reservedAmount = reservedAmount;
		}

		/// Adds the earned interest to the account balance.
		/// Renamed the AddInterest method into EndofMonth
		public override void EndofMonth()
		{  
			double interest = GetBalance() * interestRate / 100;
			Deposit(interest); 
		}

		/// Ensures that after the call, GetMeasure() will return a measure as least 
		/// as large as the argument of Reserve() (reserved amount) until Release() is called
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

			// Releease the amount from the reserved amount
			reservedAmount -= amount;
		}

		/// Returns the account's balance
		public double GetMeasure()
		{
			return GetBalance();
		}

		private double interestRate;
		private double reservedAmount;
	}
}
