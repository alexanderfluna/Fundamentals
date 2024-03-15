using System;
using System.Text;

namespace ConsoleApplication1
{
	/// <summary
	/// This program tests the contructors of class String
	/// </summary>
	public class StringConstructors {
		public static void Main() {
			// Char and byte arrays
			char[] charArray = { 'b', 'i', 'r', 't', 'h', ' ', 'd', 'a', 'y' };
			byte[] byteArray = {(byte) 'n', (byte) 'e', (byte) 'w', (byte) ' ',
								 (byte) 'y', (byte) 'e', (byte) 'a', (byte) 'r' };
			Console.WriteLine(charArray);
			Console.WriteLine(byteArray);
			foreach (byte b in byteArray)
            {
				Console.Write(b + " ");
				Console.WriteLine((char)b);
			}
			Console.WriteLine();

			// StringBuilder class
			StringBuilder builder;
			builder = new StringBuilder("Welcome to C# Programming!");
			// builder = "Welcome to C# Programming!"; // cannot convert

			// Regular strings
			string s, s1, s2, s3, output;
			s = "hello";
			builder = new StringBuilder(s); // utilizing StringBuilder class

			// use the String constructors
			s1 = new String('#', 8); // 8 hashes
			s2 = new String(charArray); // char array converted to a string
			s3 = new String(charArray, 6, 3); // cut charArray starting at index 6 of length 3
			// day
			// s = new String("hello"); no such constructor

			output = "s1 = " + s1 +
				   "\ns2 = " + s2 +
				   "\ns3 = " + s3;
			Console.WriteLine(output);
			Console.WriteLine();
		}
	}

}
