using System;

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
			BankAccount harrysChecking = new BankAccount();
			harrysChecking.Deposit(2000);
			harrysChecking.Withdraw(500);
			Console.WriteLine(harrysChecking.GetBalance());
		}
	}
}
