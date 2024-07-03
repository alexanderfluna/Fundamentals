// Alexander Luna | Assignment 2 | Problem 3
using System;
using System.Collections;
using System.Diagnostics;

namespace TestingProject
{
	/// <summary>
    /// A bank account has a balance that can be changed by 
    /// deposits and withdrawals
    /// </summary>
	public abstract class BankAccount
	{  
		///  Constructs a bank account with a zero balance.
		public BankAccount()
		{  
			balance = 0;
		}

		///  Constructs a bank account with a given balance.
		///  @param initialBalance the initial balance
		public BankAccount(double initialBalance)
		{  
			balance = initialBalance;
		}
 
		///   Deposits money into the bank account.
		///  @param amount the amount to deposit
		public virtual void Deposit(double amount) 
		{
			// Verify the amount is non-negative
			if (amount < 0)
				throw new ArgumentException("\tTRANSACTION FAILED: Amount must be non-negative");

			balance += amount;
		}

	    ///  Withdraws money from the bank account.
		///  @param amount the amount to withdraw
		public virtual void Withdraw(double amount) 
		{
			// Verify the amount is non-negative
			if (amount < 0)
				throw new ArgumentException("\tTRANSACTION FAILED: Amount must be non-negative");

			// Verify there is enough balance in the account to withdraw
			if (balance - amount < 0)
				throw new ArgumentException("\tTRANSACTION FAILED: Attempted to withdraw more money than is available.");

			balance -= amount;
		}

		 /// Gets the current balance of the bank account.
		 ///  @return the current balance
		public double GetBalance()
		{  
			return balance; 
		}

		///  Transfers money from the bank account to another account
		///   @param amount the amount to transfer
		///   @param other the other account
		public void Transfer(double amount, BankAccount other)
		{  
			Withdraw(amount);
			other.Deposit(amount);
		}

		/// Introduce an abstract method EndofMonth with no implementation
		public abstract void EndofMonth();

		private double balance; 
	}
}
