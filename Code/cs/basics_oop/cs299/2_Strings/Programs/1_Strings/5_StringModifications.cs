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
            // Two strings
            string letters = "AAbcDEFghijklmAbcDEFghijklm";
            string output = "The string is \"" + letters + "\"\n";

            // Char array
            char[] charArray = new char[4];

            // Start at index 6 and copy the next 3 characters of letters string
            letters.CopyTo(6, charArray, 0, 3);

            // Print char array
            output += "\nCopyTo: charArray is";
            for (int i = 0; i < charArray.Length; i++)
                output += " '" + charArray[i] + "'";

            // Insert the given string into index 1 of the string
            letters = letters.Insert(1, "xxx"); // creates a new String object
            output += "\n\nInsert(1,\"xxx\");\nThe string is " + letters;

            // Remove the following 3 characters at index 1 of the stirng
            letters = letters.Remove(1, 3); // creates a new String object
            output += "\n\nRemove(1,3);\nThe string is " + letters;

            // Replace all lowercase 'i' in the string with uppercase 'I'
            letters = letters.Replace('i', 'I'); // creates a new String object
            output += "\n\nReplace('i','I');\nThe string is " + letters;

            // Replace all instances of "DEF" in the string with "XXX"
            letters = letters.Replace("DEF", "XXX"); // creates a new String object
            output += "\n\nReplace(\"DEF\",\"XXX\");\nThe string is " + letters;

            // Pads the start of the string with as many * required to fit the desired string length
            string result = "abc".PadLeft(6, '*');
            output += "\n\n\"abc\".PadLeft(6,'*');\nresult is " + result;

            // Pad the end of the string with as many * required to fit the desired string length
            result = "abc".PadRight(6, '*');
            output += "\n\n\"abc\".PadRight(6,'*');\nresult is " + result;

            // Removes all white space surrounding the letters
            result = "   abc   ".Trim();
            output += "\n\n\"   abc   \".Trim();\nresult is " + result;

            // Trims from the string all characters found in the char array
            charArray = new char[2] { '*', '_' };
            result = "___abc***".Trim(charArray);
            output += "\n\n\"___abc***\".Trim(charArray); //charArray is {'*','_'}; \nresult is " + result;

            // Trims from the string all characters found in the char array before the text begins
            result = "___abc***".TrimStart(charArray);
            output += "\n\n\"___abc***\".TrimStart(charArray); //charArray is {'*','_'}; \nresult is " + result;

            // Trims from the string all characters found in the char array after the text ends
            result = "___abc***".TrimEnd(charArray);
            output += "\n\n\"___abc***\".TrimEnd(charArray); //charArray is {'*','_'}; \nresult is " + result;

            Console.WriteLine("Testing String modification methods\n" +
                              "Each modification creates a new String object.\n\n" +
                              output);
            Console.WriteLine();
        }
    }

}
