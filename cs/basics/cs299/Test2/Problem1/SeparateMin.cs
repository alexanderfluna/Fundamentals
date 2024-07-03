// Alexander Luna | Test 2 | SeparateMin.cs

using System;

namespace TestingProject
{
	public class SeparateMin
	{
		public static void Main()
		{
			BankAccount[] accounts = new BankAccount[3];

			accounts[0] = new BankAccount(50);
			accounts[1] = new BankAccount(200);
			accounts[2] = new BankAccount(110);

			Console.WriteLine("The smallest balance is "
					   + Min(accounts).GetMeasure());

			Coin[] coins = new Coin[3];

			coins[0] = new Coin(0.25, "quarter");
			coins[1] = new Coin(0.1, "dime");
			coins[2] = new Coin(0.05, "nickel");

			Console.WriteLine("The smallest coin value is "
					   + Min(coins).GetMeasure());

		}

		/*
		public static BankAccount Min(BankAccount [] a)
		{
			BankAccount smallest = a[0];
			for (int i = 1; i < a.Length; i++)
				if (a[i].GetMeasure() < smallest.GetMeasure())
					smallest = a[i];
			return smallest;
		}

		public static Coin Min(Coin [] a)
		{
			Coin smallest = a[0];
			for (int i = 1; i < a.Length; i++)
				if (a[i].GetMeasure() < smallest.GetMeasure())
					smallest = a[i];
			return smallest;
		}
		*/

		public static Measurable Min(Measurable [] a)
        {
			Measurable smallest = a[0];
			for (int i = 1; i < a.Length; i++)
            {
				if (a[i].GetMeasure() < smallest.GetMeasure())
                {
					smallest = a[i];
                }
            }
			return smallest;
        }
	}
}
