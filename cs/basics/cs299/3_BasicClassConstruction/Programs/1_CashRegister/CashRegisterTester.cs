using System;

namespace TestingProject
{
	/// <summary>
	/// A class to test the CashRegister class.
	/// </summary>
	public class CashRegisterTester
	{
		public static void Main()
		{
			// Create new register object
			CashRegister register = new CashRegister();

			// Call register methods
			register.RecordPurchase(29.50); // record $29.50 purchase
			register.RecordPurchase(10.25); // record $10.25 purchase
			register.EnterPayment(50); // pay with $50
			double change = register.GiveChange(); // return the change
			Console.WriteLine(change); // print the change amount
		}
	}
}
