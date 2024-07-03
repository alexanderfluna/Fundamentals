// ObjectSetTester2.cs - A client of ObjectSet - working with sets of different types. 

using System;
using System.Collections;
 
namespace ConsoleApplication1
{
	class ObjectSetTester
	{

		public static void Main()
		{
			Die d1 = new Die(6),  d2 = new Die(10),
				d3 = new Die(16), d4 = new Die(8);
			int sum = 0;
			string netString = "";

			ObjectSet 
				s1 = new ObjectSet(                  // A set of dice
				new Die[]{d1, d2, d3, d4}),
				s2 = new ObjectSet(                  // A set of ints
				new Object[]{1, 2, 3, 4}),
				s3 = new ObjectSet(                  // A set of strings
				new string[]{"a", "b", "c", "d"}),
				s4 = new ObjectSet(                  // A set of mixed things...
				new Object[]{new Die(6), "a", 7});

			foreach(Object o in s1)
			{
				((Die)o).Toss();
				Console.WriteLine("{0}", (Die)o);
			}

			Console.WriteLine("--------------");

			// Alternative in foreach context:
			foreach(Die d in s1)
			{
				d.Toss();
				Console.WriteLine("{0}", d);
			}
			Console.WriteLine("--------------");

			foreach(Object o in s2)
				sum += ((int)o);
			Console.WriteLine(
				"Sum: {0}", sum);
			Console.WriteLine("--------------");

			foreach(Object o in s3)
				netString += ((string)o);
			Console.WriteLine(
				"NetString: {0}", netString);
			Console.WriteLine("--------------");

			foreach(Object o in s4)
				Console.WriteLine("{0}", o);

			Console.WriteLine("--------------");
		}
	}
}

