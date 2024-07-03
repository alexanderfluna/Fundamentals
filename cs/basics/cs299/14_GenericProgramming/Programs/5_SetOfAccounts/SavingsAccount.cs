using System;

namespace TestingProject
{
	/// <summary>
	/// Summary description for Class1.
	/// An account that earns interest at a fixed rate.
	/// </summary>
	public class SavingsAccount: BankAccount
	{  
		/// Constructs a bank account with a given interest rate.
		///	@param rate the interest rate
		public SavingsAccount(string name, double rate):base(name) {  
			interestRate = rate;
		}

		/// Adds the earned interest to the account balance.
		public void AddInterest() 	{  
			double interest = GetBalance() * interestRate / 100;
			Deposit(interest); 
		}

		private double interestRate;
	}
}
