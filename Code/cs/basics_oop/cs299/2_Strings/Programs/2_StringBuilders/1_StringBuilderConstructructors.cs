using System;
using System.Text;

namespace ConsoleApplication1
{
    ///<summary
    /// This program tests the StringBuilder constructor methods
    /// </summary>
	public class StringBuilderConstructors 
	{
		public static void Main()
		{
			Console.WriteLine("Demonstrating StringBuilder Class Constructors\n");
			
			StringBuilder result;
   
			result = new StringBuilder(); // contains System.String.Empty
			Console.WriteLine("result = new StringBuilder();\t\t    result is " 
				             + "\"" + result.ToString() + "\"");
			result = new StringBuilder(10); // capacity
			Console.WriteLine("result = new StringBuilder(10);\t\t    result is " 
				             + "\"" + result.ToString() + "\"");
			result = new StringBuilder(10,20);//capacity, maxCapacity
			Console.WriteLine("result = new StringBuilder(10,20);\t    result is " 
				             + "\"" + result.ToString() + "\"");
			result = new StringBuilder("hello"); // value
			Console.WriteLine("result = new StringBuilder(\"hello\");\t    result is " 
				             + "\"" + result.ToString() + "\"");
			result = new StringBuilder("hello",3); // value, capacity
			Console.WriteLine("result = new StringBuilder(\"hello\", 3);\t    result is " 
				             + "\"" + result.ToString() + "\"");
			result = new StringBuilder("hello",1,3,10); //value, start index, length, capacity
			Console.WriteLine("result = new StringBuilder(\"hello\",1,3,10); result is " 
				             + "\"" + result.ToString() + "\"");
			Console.WriteLine();
			
			
						
		}
	}
}
