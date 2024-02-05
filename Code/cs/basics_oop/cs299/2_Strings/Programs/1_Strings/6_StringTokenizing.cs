using System;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    /// <summary
	/// This program tests the String modification methods.
	/// </summary>

	public class StringIndexMethods 
	{
		public static void Main()
		{   
			Console.WriteLine("Testing String method Split for string tokenizing\n");
			
			// String tokenizing - using the Split function
			string words = "This text to be split to words. The delimiters are space and period.";
			string[] tokens;// = new string[15];
			char[] separators = new char[2] {' ', '.'};
			tokens = words.Split(separators);
			foreach (string current in tokens)
                Console.WriteLine("|"+current+"|");
			Console.WriteLine("The length of array tokens is {0}.", tokens.Length);
			Console.WriteLine("The index of space in the first token is {0}.",
				              tokens[0].IndexOf(" "));
			Console.WriteLine("The index of space in the last token is {0}\n.",
				tokens[tokens.Length-1].IndexOf(" "));
		}
	}

}
