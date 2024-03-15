using System;

namespace TestingProject
{
	///<summary>
	/// adapted from java program version 1.2 27 Mar 1998, author Cay Horstmann
	/// uses two-dimensional arrays
	/// uses output formatting with fields
	///</summary>
 
	public class CompoundInterest
	{
		public static double FutureValue(double initialBalance,
			                             double nyear, double p)
		{
			return initialBalance * Math.Pow(1 + p / 12 / 100,
				                             12 * nyear);
		}

		public static void Main()
		{
			double[,] balance;
			balance = new double[5,4];
			for (int i = 0; i < 5; i++)
				for (int j = 0; j < 4; j++)
					balance[i,j] = FutureValue(10000, 10 + 10 * i,
						                       5 + 0.5 * j);
			Console.Write("  ");
			for (int j = 0; j < 4; j++)
				Console.Write("{0,10:f2}", 5 + 0.5 * j);

			Console.WriteLine("");
			for (int i = 0; i < 5; i++)
			{
				Console.Write("{0}", 10 + 10 * i);
				for (int j = 0; j < 4; j++)
					Console.Write("{0,10:f2}", balance[i,j]);
				Console.WriteLine();
			}
			Console.WriteLine("\n");
		}
	}

}
