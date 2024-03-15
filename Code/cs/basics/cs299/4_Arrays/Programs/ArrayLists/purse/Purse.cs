using System;
using System.Collections;

namespace TestingProject
{
	/// <summary>
	/// A purse holds a collection of coins.
	/// </summary>
	public class Purse
	{
		///  Constructs an empty purse.
		public Purse()
		{
			coins = new ArrayList();
		}

		///   Add a coin to the purse.
		///   @param aCoin the coin to add
		public void Add(Coin aCoin)
		{
			coins.Add(aCoin);
		}

		///  Get the total value of the coins in the purse.
		///  @return the sum of all coin values
		public double GetTotal()
		{
			double total = 0;
			for (int i = 0; i < coins.Count; i++)
			{
				Coin aCoin = (Coin)coins[i];
				total = total + aCoin.GetValue();
			}
			return total;
		}

		private ArrayList coins;
	}



}
