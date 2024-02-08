using System;
using System.Text;

namespace ConsoleApplication1
{
	/// <summary
	/// This program tests the String class substring methods.
	/// </summary>

	public class SubString
	{
		public static void Main()
		{
			// Two strings
			string letters = "abcdefghijklmabcdefghijklm";
			string output; // this string will acculumate all of the text below

			output = "The original string is " + "\"" + letters + "\"\n";

			// add to output the substring of letters from index 20 to the end of the string
			output += "Substring from index 20 to end is " +
				"\"" + letters.Substring(20) + "\"\n";

			// add to ouput a substring of letters from index 0 up to index 6
			output += "Substring from index 0 up to 6 is " +
				"\"" + letters.Substring(0, 6) + "\"";

			// Print output
			Console.WriteLine("Demonstrating String Class Substring Methods\n\n"
							 + output + "\n");
		}
	}

}
