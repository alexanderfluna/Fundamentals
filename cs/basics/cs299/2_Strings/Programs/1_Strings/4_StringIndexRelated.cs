using System;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
	/// <summary
	/// This program tests the String class index methods and other related methods.
	/// </summary>

	public class StringIndexMethods
	{
		public static void Main()
		{
			// Two strings
			string letters = "AAbcDEFghijklmAbcDEFghijklm";
			string output = "The string is \"" + letters + "\"\n"; // accumulates below

			// test IndexOf to locate a character in a string
			////
			output += "\n'A' is located at index " +
				letters.IndexOf('A');

			output += "\n'A' is located at index " +
				letters.IndexOf('A', 1); // the second parameter is the start index
										// you want to start searching from in the string

			output += "\n'A' is located at index " +
				letters.IndexOf('A', 2, 10);  //start at 2, examine 10 characters

			output += "\n'A' is located at index " +
				letters.IndexOf('A', 2, 20);  //start at 2, examine 20 characters

			output += "\n'$' is located at index " +
				letters.IndexOf('$'); // returns -1 since there is no $ in the string

			// test LastIndexOf to find a character in a string
			////
			output += "\n\nLast 'A' is located at index " +
				letters.LastIndexOf('A'); //search backwards from the end of the string

			output += "\nLast 'A' is located at index " +
				letters.LastIndexOf('A', 25, 3); // start at position 25 and examine 
												 // next 3 positions

			output += "\nLast '$' is located at index " +
				letters.LastIndexOf('$'); // returns -1 since there is no $ in the string

			// test indexOf to locate a substring in a string
			////
			output += "\n\n\"DEF\" is located at index " +
				letters.IndexOf("DEF"); // search through into string

			output += "\n\"DEF\" is located at index " +
				letters.IndexOf("DEF", 7); // starts from index 7

			output += "\n\"hello\" is located at index " +
				letters.IndexOf("hello"); // returns -1 because there is no "hello" in the string

			// test lastIndexOf to find a substring in a string
			output += "\n\nLast \"DEF\" is located at index " +
				letters.LastIndexOf("DEF"); // search backwards through the enitre string

			output += "\nLast \"DEF\" is located at index " +
				letters.LastIndexOf("DEF", 25); // start at position 25, search backwards

			output += "\nLast \"hello\" is located at index " +
				letters.LastIndexOf("hello"); // returns -1 because there is no "hello" in the string

			// test IndexOfAny
			char[] anyOfArray = { 'z', 'm', 'g' };
			output += "\n\nEither 'z' or 'm' or 'g' is located at index " +
					  letters.IndexOfAny(anyOfArray); // returns the index of the first character found

			// Related methods - using an enumerator
			//
			output += "\n\nHere are the string letters through by an enumerator\n";
			IEnumerator en = letters.GetEnumerator(); // create a new enumerator from letters
			en.Reset(); // reset the enumerator
			while (en.MoveNext()) // iterate through the enumerator
			{
				char ch = (char)en.Current;	// convert the current element to a char
				output += ch + " ";	// add the current char to output
			}
			output += "END\n\n";

			// Related methods - StartsWith, EndsWith
			//
			string[] strings = { "started", "starting", "ended", "ending" }; // array of strings

			// Test method startsWith
			for (int i = 0; i < strings.Length; i++) // iterate through strings array
				if (strings[i].StartsWith("st")) // if the current string starts with "st"
					output += "\"" + strings[i] + // add the current string to the output
						"\" starts with \"st\"\n";

			output += "\n";

			// Test method EndsWith
			for (int i = 0; i < strings.Length; i++) // iterate through strings array
				if (strings[i].EndsWith("ed")) // if the current string ends with "ed"
					output += "\"" + strings[i] + // add the current string to the output
						"\" ends with \"ed\"\n";


			Console.WriteLine("Testing String class index Methods\n\n{0}", output);
		}
	}

}
