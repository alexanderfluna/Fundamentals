using System;
using System.Timers;

namespace TestingProject
{
	/// <summary>
	/// A checking account that charges transaction fees.
	///</summary>
	public class CheckingAccount: BankAccount, Reservable
	{ 
 
		/// Constructs a checking account with a given balance.
		/// calls the superclass constructor first
		///@param initialBalance the initial balance
		public CheckingAccount(double initialBalance): base(initialBalance)	
		{  
			// Construct superclass
			// super(initialBalance); //cannot explicitly call the superclass 
			                          //constructor in C# !!
	      	
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
		public override void EndOfMonth()
		{  
			if (transactionCount > FREE_TRANSACTIONS) 
			{  
				double fees = TRANSACTION_FEE *
					(transactionCount - FREE_TRANSACTIONS);
				base.Withdraw(fees);
			}
			transactionCount = 0;
		}

		

		public void Reserve(double amount)
        {
            throw new NotImplementedException();
        }

        public void Release(double amount)
        {
            throw new NotImplementedException();
        }

        public double GetMeasure(object anObject)
        {
            throw new NotImplementedException();
        }

        private int transactionCount;

		private const int FREE_TRANSACTIONS = 3;
		private const double TRANSACTION_FEE = 2.0;
	}

}
