// GenericSetTester.cs - A client of Set<T> - working with sets of different types. 

using System;
using System.Collections;

 
namespace ConsoleApplication1
{
	class GenericSetTester
	{

		public static void Main()
		{
			Die d1 = new Die(6),  d2 = new Die(10),
				d3 = new Die(16), d4 = new Die(8);
			int sum = 0;
			string netString = "";


			// Working with sets of dice:
			Set<Die>  s1 = new Set<Die>(       // A set of dice
				new Die[]{d1, d2, d3, d4});
			foreach(Die d in s1)
			{
				d.Toss();
				Console.WriteLine("{0}", d);
			}


			// Working with sets of ints
			Set<int> s2 = new Set<int>(        // A set of ints
						 new int[]{1, 2, 3, 4});
			foreach(int i in s2)
				sum += i;
			Console.WriteLine("Sum: {0}", sum);


			// Working with sets of strings
			Set<string> s3 = new Set<string>(  // A set of strings
							new string[]{"a", "b", "c", "d"});
			foreach(string str in s3)
				netString += str;
			Console.WriteLine("Appended string: {0}", netString);

		}
	}
}
