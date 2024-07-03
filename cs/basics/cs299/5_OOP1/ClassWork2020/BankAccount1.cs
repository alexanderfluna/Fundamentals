using System;

namespace TestingProject
{
	/// <summary>
	/// A bank account has a balance that can be changed by 
	/// deposits and withdrawals.
	/// </summary>
	
		public class BankAccount
		{  
			///Constructs a bank account with a zero balance.
			public BankAccount()
			{   
				balance = 0;
				name = "";
			}

			
			/// Constructs a bank account with a given balance.
			/// @param initialBalance the initial balance
			public BankAccount(double initialBalance, String name)
			{   
				balance = initialBalance;
			    this.name = name;
			}

			///   Deposits money into the bank account.
			///   @param amount the amount to deposit
			public void Deposit(double amount)
			{  
				double newBalance = balance + amount;
				balance = newBalance;
			}

			/// Withdraws money from the bank account.
			/// @param amount the amount to withdraw
			public void Withdraw(double amount)
			{   
				double newBalance = balance - amount;
				balance = newBalance;
			}

			///   Gets the current balance of the bank account.
			///  @return the current balance
			public double GetBalance()
			{   
				return balance;
			}

		public String GetName()
		{
			return name;
		}
		
		public override String ToString()
        {
            return String.Format("[name = {0}, balance = {1}]", 
				name, balance);
        }

        private double balance;
		private String name;

		}
	}
