using System;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary
	/// This program tests the contructors of class String
	/// </summary>
	public class StringConstructors {
		public static void Main() 		{
			char [] charArray = {'b', 'i', 'r', 't', 'h', ' ', 'd', 'a', 'y' };
			byte [] byteArray = {(byte) 'n', (byte) 'e', (byte) 'w', (byte) ' ', 
								 (byte) 'y', (byte) 'e', (byte) 'a', (byte) 'r' };
			StringBuilder builder;
			string s, s1, s2, s3, output;

			// s = new String("hello"); no such constructor
			s = "hello";
			// builder = "Welcome to C# Programming!"; // cannot convert
			builder = new StringBuilder( "Welcome to C# Programming!" );
			builder = new StringBuilder(s);

			// use the String constructors
			s1 = new String('a',5); // 5 a's
			s2 = new String(charArray);
            // starting at 6, length 3
			s3 = new String(charArray,6,3);		

			output = "s1 = " + s1 +
			       "\ns2 = " + s2 +
			       "\ns3 = " + s3 ;			

			Console.WriteLine("Testing String class constructors\n");
			Console.WriteLine(output);
			Console.WriteLine();
		}
	}

}
