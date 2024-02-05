using System;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary
	/// This program demonstrates some of the Append methods of the StringBuilder class
    /// </summary>
	public class StringBuilderAppend 
	{
		public static void Main() {
			Console.WriteLine("Demonstrating StringBuilder Append Methods\n");
			
			string s = "hello";   
			Object o = "good bye";
			char[] charArray = { 'a', 'b', 'c', 'd', 'e', 'f' };
			bool b = true;
			char c = 'Z';
			int i = 7;
			long l = 10000000;
			float f = 2.5f;
			double d = 33.333;
			StringBuilder result = new StringBuilder();

			Console.WriteLine("Appending a string to an empty StringBuilder");
			result.Append( s );
			Console.WriteLine("result = {0}\n", result);
			result.Append( " " );
			Console.WriteLine("Append( s,1,3 )");
			result.Append( s,1,3 );
			Console.WriteLine("result = {0}\n", result);
			result.Append( " " );
			Console.WriteLine("Appending a string through an Object reference"); 
			result.Append( o );
			Console.WriteLine("result = {0}\n", result);
			result.Append( " " );
			Console.WriteLine("Appending a character array");
			result.Append( charArray );
			Console.WriteLine("result = {0}\n", result);
			result.Append( " " );
			Console.WriteLine("Appending ( charArray, 0, 3 )");
			result.Append( charArray, 0, 3 );
			Console.WriteLine("result = {0}\n", result);
			result.Append( " " );
			Console.WriteLine("Appending a Boolean");
			result.Append( b );
			Console.WriteLine("result = {0}\n", result);
			result.Append( " " );
			Console.WriteLine("Appending a character");
			result.Append( c );
			Console.WriteLine("result = {0}\n", result);
			result.Append( " " );
			Console.WriteLine("Appending a repeated character");
			result.Append( c,3 );
			Console.WriteLine("result = {0}\n", result);
			result.Append( " " );
			Console.WriteLine("Appending an integer");
			result.Append( i );
			Console.WriteLine("result = {0}\n", result);
			result.Append( " " );
			Console.WriteLine("Appending a long integer");
			result.Append( l );
			Console.WriteLine("result = {0}\n", result);
			result.Append( " " );
			Console.WriteLine("Appending a float");
			result.Append( f );
			Console.WriteLine("result = {0}\n", result);
			result.Append( " " );
			Console.WriteLine("Appending a double");
			result.Append( d );
			Console.WriteLine("result = {0}\n", result);
			
		}
	}
}
