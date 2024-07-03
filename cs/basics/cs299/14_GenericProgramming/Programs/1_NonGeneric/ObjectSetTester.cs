// ObjectSetTester.cs - A client of ObjectSet - working with sets of Die objects. 

using System;
using System.Collections;
 
namespace ConsoleApplication1
{
	class ObjectSetTester
	{

		public static void Main()
		{
			ObjectSet s1 = new ObjectSet(),
				s2 = new ObjectSet();

			Die d1 = new Die(6),  d2 = new Die(10),
				d3 = new Die(16), d4 = new Die(8);

			s1.Insert(d1); s1.Insert(d2);  s1.Insert(d3);
			s1.Insert(d4); s1.Insert(d1);  s1.Insert(d1);
			s1.Delete(d1); s1.Delete(d2); 

			s2.Insert(d3); s2.Insert(d3); s2.Insert(d4); 

			Console.WriteLine("s1: {0}", s1);
			Console.WriteLine("s2: {0}", s2);

			// Exercises:
			// Console.WriteLine("{0}", s2.Intersection(s1));
			// Console.WriteLine("{0}", s2.Union(s1));
			// Console.WriteLine("{0}", s2.Diff(s1));

			if (s1.Subset(s2))
				Console.WriteLine("s1 is a subset of s2");
			else 
				Console.WriteLine("s1 is not a subset of s2");

			if (s2.Subset(s1))
				Console.WriteLine("s2 is a subset of s1");
			else 
				Console.WriteLine("s2 is not a subset of s1");
		}
	}
}
