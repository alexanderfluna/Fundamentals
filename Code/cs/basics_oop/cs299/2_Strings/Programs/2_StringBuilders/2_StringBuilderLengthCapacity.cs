using System;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary
	/// This program demonstrates the length and capacity methods 
	/// of the StringBuilder class.
	
	public class StringBuilderLengthCapacity 
	{
		public static void Main()
		{
			Console.WriteLine("Stringresultfer length and capacity Methods\n");
			
			StringBuilder result =
				new StringBuilder( "Hello" );

			Console.WriteLine("result = {0}, Length = {1}, Capacity = {2}, MaxCapacity = {3}",
				             result, result.Length, result.Capacity, result.MaxCapacity);
			
			result.Append(", how are you?");
			Console.WriteLine("\nresult = {0}, Length = {1}, Capacity = {2}",
				result, result.Length, result.Capacity);

			result.EnsureCapacity( 10 );
			Console.WriteLine("\nNew capacity = " + result.Capacity);

			result.EnsureCapacity( 33 );
			Console.WriteLine("\nNew capacity = " + result.Capacity);

			result.Capacity = 60;
			Console.WriteLine("\nNew capacity = " + result.Capacity);

			Console.WriteLine();						
		}
	}

}
