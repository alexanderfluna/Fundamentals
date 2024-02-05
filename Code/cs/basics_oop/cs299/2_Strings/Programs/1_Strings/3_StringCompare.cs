using System;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    /// <summary
	/// This program tests the String class index methods and other related methods.
	/// </summary>

	public class StringCompare 
	{
		public static void Main()
		{
			string s1, s2, s3, s4, output;

			s1 =  "hello";
			s2 =  "good bye";
			s3 = "Happy Birthday";
			s4 = "happy birthday";

			output = "s1 = " + s1 + "\ns2 = " + s2 +
				"\ns3 = " + s3 + "\ns4 = " + s4 + "\n\n";

			// test for equality
			if ( s1.Equals( "hello" ) )
				output += "s1 equals \"hello\"\n";
			else
				output += "s1 does not equal \"hello\"\n"; 

			// test for equality with ==
			if ( s1 == "hello" )
				output += "s1 == \"hello\"\n";
			else
				output += "s1 != \"hello\"\n";

			// test for equality--ignore case
			if ( s3.ToLower().Equals(s4.ToLower() ) )
				output += "Ignoring the case, s3 equals s4\n";
			else
				output += "Ignoring he case, s3 does not equal s4\n";


			if ( s3.ToLower()== s4.ToLower() )
				output += "Ignoring the case, s3 == s4\n";
			else
				output += "Ignoring he case, s3 != s4\n";

			// test compareTo
			output +=
				"\ns1.CompareTo( s2 ) is " + s1.CompareTo( s2 ) +
				"\ns2.CompareTo( s1 ) is " + s2.CompareTo( s1 ) +
				"\ns1.CompareTo( s1 ) is " + s1.CompareTo( s1 ) +
				"\ns3.CompareTo( s4 ) is " + s3.CompareTo( s4 ) +
				"\ns4.CompareTo( s3 ) is " + s4.CompareTo( s3 ) +
				"\n\n";

			Console.WriteLine("Testing string comparisons\n\n"+ output);
		}
	}

}
