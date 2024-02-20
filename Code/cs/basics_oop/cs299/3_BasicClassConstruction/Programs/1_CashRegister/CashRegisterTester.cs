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
			CashRegister register = new CashRegister();
			register.RecordPurchase(29.50);
			register.RecordPurchase(9.25);
			register.EnterPayment(50);
			double change = register.GiveChange();
			Console.WriteLine(change);      
		}
	}
}
