// RandomSerializable.cs - The Random class - Serializable. 

using System;

namespace ConsoleApplication1
{
	// This version can produce a fix prefix of numbers 
	// before drawing random numbers
	[Serializable]
	public class Random 
	{

		// Singleton pattern:
		// Keeps track of unique instance of this class
		private static Random uniqueInstance = null;

		private int[] firstNumbers;
		private int idx; 

		// Holds the instance of System.Random
		private System.Random systemRandom;

		// Singleton pattern: Private constructor.
		private Random(params int[] firstNumbers)
		{
			systemRandom = new System.Random(unchecked((int)DateTime.Now.Ticks));
			this.firstNumbers = new int[firstNumbers.Length];
			for(int i = 0; i < firstNumbers.Length; i++)
				this.firstNumbers[i] = firstNumbers[i];
			idx = 0;
		}

		public static Random Instance(params int[] firstNumbers)
		{
			if (uniqueInstance == null)
				uniqueInstance = new Random(firstNumbers);
			return uniqueInstance;
		}

		public int Next(int lower, int upper)
		{
			if (idx < firstNumbers.Length)
			{
				int res = firstNumbers[idx];
				idx++;
				return res;
			} 
			else
			{
				// delegate to systemRandom
				return systemRandom.Next(lower,upper);
			}
		}

	}

}
