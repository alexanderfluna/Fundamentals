using System;

namespace TestingProject
{
	/// <summary>
	/// Summary description for Class1.
	/// An account that earns interest at a fixed rate.
	/// </summary>
	public class SavingsAccount: BankAccount, Reservable
	{  
		/// Constructs a bank account with a given interest rate.
		///	@param rate the interest rate
		public SavingsAccount(double rate) {  
			interestRate = rate;
		}

		/// Adds the earned interest to the account balance.
		public override void EndOfMonth()
		{  
			double interest = GetBalance() * interestRate / 100;
			Deposit(interest); 
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

		private double interestRate;
		private double reservedAmount;
	}
}
