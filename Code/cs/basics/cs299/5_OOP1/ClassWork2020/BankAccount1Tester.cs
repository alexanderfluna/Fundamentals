using System;
using System.Collections.Specialized;

namespace TestingProject
{
	/// <summary>
	/// A class to test the BankAccount class.
	/// </summary>
	public class BankAccountTeste
	{
		///   Tests the methods of the BankAccount class.
		///   @param args not used
		public static void Main()
		{
			BankAccount harrysChecking = new BankAccount(0,"Harry");
			harrysChecking.Deposit(2000);
			harrysChecking.Withdraw(500);
			Console.WriteLine(harrysChecking.GetBalance());
			
			BankAccount momsSavings = new BankAccount(0, "Mom");
			momsSavings.Deposit(20000);
			momsSavings.Withdraw(500);
			Console.WriteLine(momsSavings.GetBalance());

			BankAccount[] accnts = new BankAccount[2];
			accnts[0] = momsSavings;
			accnts[1] = harrysChecking;

			Bank theBank = new Bank(accnts);

			for (int i = 1; i <= 2; i++)
			{
				//Console.WriteLine(theBank[i]);
				Console.WriteLine("[{0}, {1}]",
					theBank[i].GetBalance(),
					theBank[i].GetName());
			}
			BankAccount georgesSavings = new BankAccount (100,"George");
			//theBank[0] = georgesSaving;
			
			for (int i = 1; i <= 2; i++)
			{
				//Console.WriteLine(theBank[i]);
				Console.WriteLine("[{0}, {1}]",
					theBank[i].GetBalance(),
					theBank[i].GetName());
			}



		}
	}
}
