using System;

namespace TestingProject
{
	/// <summary>
	///	This program tests the DataSet class.
	/// </summary>
	public class DataSetTester	{
		public static void Main()		{
			DataSet bankData = new DataSet();

			bankData.Add(new BankAccount(0));
			bankData.Add(new BankAccount(10000));
			bankData.Add(new BankAccount(2000));

			Console.WriteLine("Average balance = {0}", bankData.GetAverage());
			Measurable max = bankData.GetMaximum();
			Console.WriteLine("Highest balance = {0}", max.GetMeasure());

			DataSet coinData = new DataSet();

			coinData.Add(new Coin(0.25, "quarter"));
			coinData.Add(new Coin(0.1, "dime"));
			coinData.Add(new Coin(0.05, "nickel"));

			Console.WriteLine("Average coin value = {0}", coinData.GetAverage());
			max = coinData.GetMaximum();
			Console.WriteLine("Highest coin value = {0}",max.GetMeasure());
		}		
	}
}
