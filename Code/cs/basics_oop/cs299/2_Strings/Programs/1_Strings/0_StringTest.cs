using System;

namespace TestingProject
{
	/// <summary>
	/// Testing the == operator with stringa
	/// </summary>
	
	public class StringTest 
	{
		public static void Main () 
		{
			String name = "Peter", visitor = "Peter Thomas";
			name = name + " Thomas";

			if (name==visitor)
				Console.WriteLine("The strings match. Visitor is " + name);
			else
				Console.WriteLine("The strings don't match. " + name + 
                                  " is not the same as " + visitor);
		}
	}
}
