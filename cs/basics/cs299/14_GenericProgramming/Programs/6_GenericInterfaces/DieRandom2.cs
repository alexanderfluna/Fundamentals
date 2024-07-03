// DieRandom2.cs - A class Die that implements IComparable<T>.
using System;

namespace ConsoleApplication1
{
	public class Die: IComparable<Die> 
	{
		private int numberOfEyes;
		private Random randomNumberSupplier; 
		private const int maxNumberOfEyes = 6;

		public Die()
		{
			randomNumberSupplier = Random.Instance();
			numberOfEyes = NewTossHowManyEyes();
		}   

		public int CompareTo(Die other)
		{
			return this.numberOfEyes.CompareTo(other.numberOfEyes);
		}
    
		public void Toss()
		{
			numberOfEyes = NewTossHowManyEyes();
		}

		private int NewTossHowManyEyes ()
		{
			return randomNumberSupplier.Next(1,maxNumberOfEyes + 1);
		}

		public int NumberOfEyes() 
		{
			return numberOfEyes;
		}

		public override String ToString()
		{
			return String.Format("[{0}]", numberOfEyes);
		}

	}

	public class Random 
	{

		// Singleton pattern:
		// Keeps track of unique instance of this class
		private static Random uniqueInstance = null;

		// Holds the instance of System.Random
		private System.Random systemRandom;

		// Singleton pattern: Private constructor.
		private Random()
		{
			systemRandom = new System.Random(unchecked((int)DateTime.Now.Ticks));
		}

		public static Random Instance()
		{
			if (uniqueInstance == null)
				uniqueInstance = new Random();
			return uniqueInstance;
		}

		public int Next(int lower, int upper)
		{
			// delegate to systemRandom
			return systemRandom.Next(lower,upper);
		}

	}

	class App
	{

		public static void Main()
		{

			Die[] dice = new Die[]{new Die(), new Die(), new Die(), new Die(),
									  new Die(), new Die(), new Die(), new Die(),
			};
			Console.WriteLine("Before sorting");
			foreach(Die d in dice)
				Console.Write("{0} ", d);
    
			Console.WriteLine();

			Console.WriteLine("After sorting");
			Array.Sort(dice);
			foreach(Die d in dice)
				Console.Write("{0} ", d);

		}

	}

}
