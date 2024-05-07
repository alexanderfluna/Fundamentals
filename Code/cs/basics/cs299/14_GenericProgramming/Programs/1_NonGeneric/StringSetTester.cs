// StringSetTester.cs - A client of StringSet. 


using System;
using System.Collections;

namespace ConsoleApplication1
{
	class StringSetTester
	{

		public static void Main()
		{
			StringSet s1 = new StringSet(),
				s2 = new StringSet();

			s1.Insert("a"); s1.Insert("b");  s1.Insert("c");
			s1.Insert("dd"); s1.Insert("ee");  s1.Insert("ff");
			s1.Insert("ggg"); s1.Insert("hhh");  s1.Insert("iii");
			s1.Delete("c"); s1.Delete("ff");  s1.Insert("iii");

			s2.Insert("a"); s2.Insert("iii"); 

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
