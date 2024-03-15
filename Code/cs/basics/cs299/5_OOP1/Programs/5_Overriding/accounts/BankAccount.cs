using System;
using System.Collections;

namespace TestingProject
{
	/// <summary>
    /// A bank account has a balance that can be changed by 
    /// deposits and withdrawals
    /// </summary>
	public class BankAccount
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
		{  
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

		private double balance; 
	}
}
