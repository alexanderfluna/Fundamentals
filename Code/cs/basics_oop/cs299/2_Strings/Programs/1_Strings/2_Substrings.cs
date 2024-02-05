using System;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary
	/// This program tests the String class substring methods.
	/// </summary>

	public class SubString 
	{
		public static void Main() {
			string letters = "abcdefghijklmabcdefghijklm";
			string output;

			output = "The original string is " + "\"" + letters + "\"\n";

			// test substring methods
			output += "Substring from index 20 to end is " +
				"\"" + letters.Substring( 20 ) + "\"\n";

			output += "Substring from index 0 up to 6 is " +
				"\"" + letters.Substring( 0, 6 ) + "\"";

			Console.WriteLine("Demonstrating String Class Substring Methods\n\n" 
				             + output + "\n");			
		}
	}

}
