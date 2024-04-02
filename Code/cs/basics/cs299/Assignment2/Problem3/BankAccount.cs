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
			balance = balance + amount;
		}

	    ///  Withdraws money from the bank account.
		///  @param amount the amount to withdraw
		public virtual void Withdraw(double amount) 
		{  if (balance - amount < 0)
				Console.WriteLine("\tERROR: There is not enough money to withdraw");
			else
				balance = balance - amount;
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

		/// Introduce an abstract method EndofMonth with no implementation. 
		public abstract void EndOfMonth();

		protected void AssertNonNegative(double amount)
		{
			Debug.Assert(amount >= 0, "Amount should be non-negative.");
		}

		private double balance; 
	}
}
