using System;

namespace TestingProject
{
	/// <summary>
	/// Objects of this class measure rectangles by area.
	/// </summary>
	public class BankAccountMeasurer : Measurer	{
		public double Measure(Object anObject)  {
			BankAccount anAccount = (BankAccount) anObject;
            return anAccount.GetBalance(); 
		}
	}

}
