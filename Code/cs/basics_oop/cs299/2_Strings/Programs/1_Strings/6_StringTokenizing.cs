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

            // Strings of words
            string words = "This text to be split to words. The delimiters are space and period.";

            // Array of strings
            string[] tokens;// = new string[15];

            // Array of chars containing ' ' & '.'
            char[] separators = new char[2] { ' ', '.' };

            // Split the words of the string and insert into tokens array
            tokens = words.Split(separators);

            // Iterate through each string in tokens array
            foreach (string current in tokens)
                // Print out each string in array
                Console.WriteLine("|" + current + "|");

            // Print array's length
            Console.WriteLine("The length of array tokens is {0}.", tokens.Length);

            // Returns -1 because there are no spaces
            Console.WriteLine("The index of space in the first token is {0}.",
                              tokens[0].IndexOf(" "));

            // Returns -1 because there are no spaces
            Console.WriteLine("The index of space in the last token is {0}\n.",
                tokens[tokens.Length - 1].IndexOf(" "));
        }
    }

}
