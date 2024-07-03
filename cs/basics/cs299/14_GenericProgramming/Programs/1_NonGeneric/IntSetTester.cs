// InSetTester.cs - A client of IntSet. 

using System;
using System.Collections;

namespace ConsoleApplication1
{
	class App
	{

		public static void Main()
		{
			IntSet s1 = new IntSet(),
				s2 = new IntSet();

			s1.Insert(1); s1.Insert(2);  s1.Insert(3);
			s1.Insert(4); s1.Insert(5);  s1.Insert(6);
			s1.Insert(5); s1.Insert(6);  s1.Insert(8);
			s1.Delete(3); s1.Delete(6);  s1.Insert(9);

			s2.Insert(8); s2.Insert(9); 

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
