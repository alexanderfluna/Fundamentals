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
			string letters = "AAbcDEFghijklmAbcDEFghijklm";
			string output = "The string is \"" + letters + "\"\n";

			// test IndexOf to locate a character in a string

			output += "\n'A' is located at index " +
				letters.IndexOf( 'A');
			
			output += "\n'A' is located at index " +
				letters.IndexOf( 'A', 1 );

			output += "\n'A' is located at index " +
				letters.IndexOf( 'A', 1, 4 );  //start at 1, examine 4 characters

			output += "\n'A' is located at index " +
				letters.IndexOf( 'A', 2, 4 );  //start at 2, examine 4 characters

			output += "\n'$' is located at index " +
				letters.IndexOf( '$' );			

			// test LastIndexOf to find a character in a string
			output += "\n\nLast 'A' is located at index " +
				letters.LastIndexOf( 'A' ); //search backwards from the end of the string

			output += "\nLast 'A' is located at index " +
				letters.LastIndexOf( 'A', 25, 3 ); // start at position 25 and examine 
			                                       // next 3 positions

			output += "\nLast '$' is located at index " +
				letters.LastIndexOf( '$' );

			// test indexOf to locate a substring in a string
			output += "\n\n\"DEF\" is located at index " +
				letters.IndexOf( "DEF" );

			output += "\n\"DEF\" is located at index " +
				letters.IndexOf( "DEF", 7 );

			output += "\n\"hello\" is located at index " +
				letters.IndexOf( "hello" );

			// test lastIndexOf to find a substring in a string
			output += "\n\nLast \"DEF\" is located at index " +
				letters.LastIndexOf( "DEF" );

			output += "\nLast \"DEF\" is located at index " +
				letters.LastIndexOf( "DEF", 25 ); // start at position 25, search backwards

			output += "\nLast \"hello\" is located at index " +
				letters.LastIndexOf( "hello" );

			// test IndexOfAny
			char[] anyOfArray =  {'z', 'm', 'g'};
			output += "\n\nEither 'z' or 'm' or 'g' is located at index " +
				      letters.IndexOfAny(anyOfArray);

			// Related methods - using an enumerator
			output += "\n\nHere are the string letters through by an enumerator\n";
			IEnumerator en = letters.GetEnumerator();
			en.Reset();
			while(en.MoveNext()) {
				char ch = (char) en.Current;
				output += ch + " ";			
			}

			// Related methods - StartsWith, EndsWith

			string [] strings = { "started", "starting", "ended", "ending" };
			
			// Test method startsWith
			for ( int i = 0; i < strings.Length; i++ )
				if ( strings[ i ].StartsWith( "st" ) )
					output += "\"" + strings[ i ] +
						"\" starts with \"st\"\n";

			output += "\n";

			
			// Test method EndsWith
			for ( int i = 0; i < strings.Length; i++ )
				if ( strings[ i ].EndsWith( "ed" ) )
					output += "\"" + strings[ i ] +
						"\" ends with \"ed\"\n";


			Console.WriteLine("Testing String class index Methods\n\n{0}", output);			
		}
	}

}
