using System;

namespace TestingProject
{
	/// <summary>
	/// This program tests the BankAccount class and
    /// its subclasses. 
	/// </summary>
	public class AccountTester
	{  
		public static void Main()
		{  
			SavingsAccount momsSavings 
				= new SavingsAccount(0.5);
      
			CheckingAccount harrysChecking
				= new CheckingAccount(100);
			Console.WriteLine("Harry's checking initial balance = {0:c}.", 
				               harrysChecking.GetBalance());
         
			momsSavings.Deposit(10000);
      
			momsSavings.Transfer(2000, harrysChecking);     
			harrysChecking.Withdraw(1500);
			harrysChecking.Withdraw(80);      

			momsSavings.Transfer(1000, harrysChecking);
			harrysChecking.Withdraw(400);      

			// Simulate end of month
			momsSavings.EndOfMonth();
			harrysChecking.EndOfMonth();
      
			Console.WriteLine("Mom's savings balance = {0:c}.", momsSavings.GetBalance());

			Console.WriteLine("Harry's checking balance = {0:c}.", 
				               harrysChecking.GetBalance());
		}
	}
}
