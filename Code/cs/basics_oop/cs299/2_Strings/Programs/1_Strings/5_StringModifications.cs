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
			string letters = "AAbcDEFghijklmAbcDEFghijklm";
			string output = "The string is \"" + letters + "\"\n";

			// test CopyTo
			char[] charArray = new char[4];
			letters.CopyTo(6,charArray,0,3);
			output += "\nCopyTo: charArray is";
			for (int i = 0; i<charArray.Length; i++)
				output += " '" + charArray[i] + "'";

			// test Insert
			letters = letters.Insert(1,"xxx"); // creates a new String object
			output += "\n\nInsert(1,\"xxx\");\nThe string is "+ letters;
			
			//test Remove
			letters = letters.Remove(1,3); // creates a new String object
			output += "\n\nRemove(1,3);\nThe string is "+ letters;

			//test Replace
			letters = letters.Replace('i','I'); // creates a new String object
			output += "\n\nReplace('i','I');\nThe string is "+ letters;

			letters = letters.Replace("DEF","XXX"); // creates a new String object
			output += "\n\nReplace(\"DEF\",\"XXX\");\nThe string is "+ letters;

			string result = "abc".PadLeft(6,'*');
			output += "\n\n\"abc\".PadLeft(6,'*');\nresult is "+ result;

			result = "abc".PadRight(6,'*');
			output += "\n\n\"abc\".PadRight(6,'*');\nresult is "+ result;

			result = "   abc   ".Trim();
			output += "\n\n\"   abc   \".Trim();\nresult is "+ result;

			charArray = new char[2] {'*','_'};
			result = "___abc***".Trim(charArray);
			output += "\n\n\"___abc***\".Trim(charArray); //charArray is {'*','_'}; \nresult is "+ result;

			result = "___abc***".TrimStart(charArray);
			output += "\n\n\"___abc***\".TrimStart(charArray); //charArray is {'*','_'}; \nresult is "+ result;

			result = "___abc***".TrimEnd(charArray);
			output += "\n\n\"___abc***\".TrimEnd(charArray); //charArray is {'*','_'}; \nresult is "+ result;
			
			Console.WriteLine("Testing String modification methods\n" +
				              "Each modification creates a new String object.\n\n" +
				              output);
			Console.WriteLine();
		}
	}

}
