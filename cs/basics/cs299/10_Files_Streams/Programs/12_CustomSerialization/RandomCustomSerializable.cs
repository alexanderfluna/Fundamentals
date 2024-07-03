//RandomCustomSerializable.cs - The Random class - With OnDeserialization method. 

using System;
using System.Runtime.Serialization;


namespace ConsoleApplication1
{
	// This version can produce a fixed prefix of numbers 
	// before drawing random numbers
	[Serializable]
	public class Random: IDeserializationCallback 
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

		public void OnDeserialization(Object notUsed)
		{
			Console.WriteLine(
				"OnDeserialization: Random. The 10 Next numbers will be 6");
			// Cheat, such that subsequent call to Next is controlled:
			firstNumbers = new int[10]{6, 6, 6, 6, 6, 6, 6, 6, 6, 6};
			idx = 0;
		}   

	}



}
