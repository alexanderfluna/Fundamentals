// Alexander Luna | Assignment 2 | Problem 3
using System;
using System.Timers;

namespace TestingProject
{
	/// <summary>
	/// A checking account that charges transaction fees.
	///</summary>
	/// Make all subclasses of BankAccount implement the Reservable interface
	public class CheckingAccount: BankAccount, Reservable
	{
		/// Constructs a checking account with a given balance
		/// @param initialBalance the initial balance
		public CheckingAccount(double initialBalance): base(initialBalance)
        {
			// Initialize fields
			reservedAmount = 0;
			transactionCount = 0;
        }
 
		/// Constructs a checking account with a given balance and reserved amount
		/// @param initialBalance the initial balance
		/// @param reservedAmoun the reserved amount
		public CheckingAccount(double initialBalance, double reservedAmount): base(initialBalance)	
		{
			// Initialize fields
			this.reservedAmount = reservedAmount;
			transactionCount = 0;
		}		

		/// Deposits money into the account
		/// @param amount the amount to be deposited
		public override void Deposit(double amount) 	
		{
			// Add amount to balance 
			base.Deposit(amount);

			// Increment the transaction count
			transactionCount++;
		}
	   
		/// Withdraws money from the account
		/// @param amount the amount the be withdrawn
		public override void Withdraw(double amount)		
		{
			// Subtract amount from balance 
			base.Withdraw(amount);

			// Increment the transaction count
			transactionCount++;
		}

		/// Deducts the accumulated fees and resets the transaction count.
		/// Renamed the DeductFee method into EndofMonth
		public override void EndofMonth()
		{  
			if (transactionCount > FREE_TRANSACTIONS) 
			{  
				double fees = TRANSACTION_FEE *
					(transactionCount - FREE_TRANSACTIONS);
				base.Withdraw(fees);
			}
			transactionCount = 0;
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

			// Release the amount from the reserved amount
			reservedAmount -= amount;
		}

		/// Returns the account's balance
		public double GetMeasure()
		{
			return GetBalance();
		}

		private int transactionCount;
		private double reservedAmount;
		private const int FREE_TRANSACTIONS = 3;
		private const double TRANSACTION_FEE = 2.0;
	}

}
