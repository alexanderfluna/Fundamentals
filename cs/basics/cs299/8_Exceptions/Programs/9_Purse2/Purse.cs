using System;
using System.Collections;

namespace TestingProject
{
	/// <summary>
	/// A purse holds a collection of coins.
	/// </summary>	
	public class Purse
	{
		///   Constructs an empty purse.
		public Purse()
		{
			coins = new ArrayList();
		}

		/// Add a coin to the purse.
		/// @param aCoin the coin to add
		public void Add(Coin aCoin)
		{
			coins.Add(aCoin);
		}

		/// Get the total value of the coins in the purse.
		///   @return the sum of all coin values
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

		///  Counts the number of coins in the purse
		///  @return the number of coins
		public int Count()
		{
			return coins.Count;
		}

		 ///  Tests if the purse has a coin that matches
		 ///  a given coin.
		 ///  @param aCoin the coin to match
		 ///  @return true if there is a coin equal to aCoin
		public bool Find(Coin aCoin)
		{
			for (int i = 0; i < coins.Count; i++)
			{
				Coin c = (Coin)coins[i];
				if (c.Equals(aCoin)) return true; // found a match
			}
			return false; // no match in the entire array list
		}

		 ///  Counts the number of coins in the purse that match
		 ///  a given coin.
		 ///  @param aCoin the coin to match
		 ///  @return the number of coins equal to aCoin
		public int Count(Coin aCoin)
		{
			int matches = 0;
			for (int i = 0; i < coins.Count; i++)
			{
				Coin c = (Coin)coins[i];
				if (c.Equals(aCoin)) matches++; // found a match
			}
			return matches;
		}

		/// Finds the coin with the largest value. 
		///(Precondition: The purse is not empty)
		/// @return a coin with maximum value in this purse
		public Coin GetMaximum()
		{
			Assert.Test(coins.Count > 0, "The purse is not empty in Coin.GetMaximum");
			Coin max = (Coin)coins[0];
			for (int i = 1; i < coins.Count; i++) 
			{
				Coin c = (Coin)coins[i];
				if (c.GetValue() > max.GetValue())
					max = c;
			}
			return max;
		}

		private ArrayList coins;
	}



}
