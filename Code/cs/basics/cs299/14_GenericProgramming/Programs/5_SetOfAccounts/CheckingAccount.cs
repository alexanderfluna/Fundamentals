using System;
using System.Timers;

namespace TestingProject
{
	/// <summary>
	/// A checking account that charges transaction fees.
	///</summary>
	public class CheckingAccount: BankAccount	
	{

        /// Constructs a checking account with a zero.
        /// calls the superclass constructor first
        /// @param name the account name
        /// @param initialBalance the initial balance
        public CheckingAccount(string name):
                                base(name)
        {
            // Initialize transaction count
            transactionCount = 0;

        }		
 
		/// Constructs a checking account with a given balance.
		/// calls the superclass constructor first
        /// @param name the account name
		/// @param initialBalance the initial balance
		public CheckingAccount(string name, double initialBalance): 
                                base(name, initialBalance)	
		{        	
			// Initialize transaction count
			transactionCount = 0;
			
		}		

		public override void Deposit(double amount) 	
		{  
			transactionCount++;
			// Now add amount to balance 
			base.Deposit(amount); 
		}
	   
		public override void Withdraw(double amount)		
		{  
			transactionCount++;
			// Now subtract amount from balance 
			base.Withdraw(amount); 
		}

		/// Deducts the accumulated fees and resets the
		/// transaction count.
		public void DeductFees()	
		{  
			if (transactionCount > FREE_TRANSACTIONS) 
			{  
				double fees = TRANSACTION_FEE *
					(transactionCount - FREE_TRANSACTIONS);
				base.Withdraw(fees);
			}
			transactionCount = 0;
		}

		private int transactionCount;

		private const int FREE_TRANSACTIONS = 3;
		private const double TRANSACTION_FEE = 2.0;
	}

}
