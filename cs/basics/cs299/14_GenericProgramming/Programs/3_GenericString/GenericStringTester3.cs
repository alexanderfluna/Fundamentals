// GenericStringTester2.cs - The generic method ReportCompare in the generic String programs.

using System;

namespace ConsoleApplication1
{
	class StringApp
	{

		public static void Main()
		{

			ReportCompare(new String<int>(), new String<int>(1));
			ReportCompare(new String<int>(1), new String<int>(1));
			ReportCompare(new String<int>(1,2,3), new String<int>(1));
			ReportCompare(new String<int>(1), new String<int>(1,2,3));
			ReportCompare(new String<int>(1,2,3), new String<int>(1,2,3));
		}

		public static void ReportCompare<T>(String<T> s, String<T> t)
		where T: IComparable<T>
							 {
		Console.WriteLine("Result of comparing {0} and {1}: {2}", 
		s, t, s.CompareTo(t));
	}   

}

}
