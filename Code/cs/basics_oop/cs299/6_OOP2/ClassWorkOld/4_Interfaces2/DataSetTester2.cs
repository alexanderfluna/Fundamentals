using System;

namespace TestingProject
{
	/// <summary>
	///	   This program demonstrates the use of a Measurer.
	/// </summary>
	public class DataSetTester2
	{
		public static void Main()
		{
			Measurer m = new RectangleMeasurer();
			DataSet rectangleData = new DataSet(m);

            rectangleData.Add(new Rectangle(5, 10, 20, 30));
            rectangleData.Add(new Rectangle(10, 20, 30, 40));
            rectangleData.Add(new Rectangle(20, 30, 5, 10));

            Console.WriteLine("Average area = " + rectangleData.GetAverage());
            Rectangle max = (Rectangle)rectangleData.GetMaximum();
			Console.WriteLine("Rectangle with maximum area = " + max);

            m = new CoinMeasurer();
            DataSet coinData = new DataSet(m);

            coinData.Add(new Coin(0.25, "quarter"));
            coinData.Add(new Coin(0.1, "dime"));
            coinData.Add(new Coin(0.05, "nickel"));
            
            Console.WriteLine("\nAverage coin value = {0}", coinData.GetAverage());
            Coin maxCoin = (Coin) coinData.GetMaximum();
            Console.WriteLine("Highest coin value = {0}", maxCoin.GetValue());

            m = new BankAccountMeasurer();
            DataSet accountData = new DataSet(m);

            accountData.Add(new BankAccount(1000));
            accountData.Add(new BankAccount(2000));
            accountData.Add(new BankAccount(0));

            Console.WriteLine("\nAverage bank account balance = {0}", accountData.GetAverage());
            BankAccount maxAccount = (BankAccount)accountData.GetMaximum();
            Console.WriteLine("Highest bank account balance = {0}\n", maxAccount.GetBalance());

		}
	}

}
