using System;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary
	/// This program demonstrates some of the Append methods of the StringBuilder class
    /// </summary>
	public class StringBuilderAppend
    {
        public static void Main()
        {
            Console.WriteLine("Demonstrating StringBuilder Append Methods\n");

            StringBuilder result = new StringBuilder();

            // String
            Console.WriteLine("Appending a string to an empty StringBuilder");
            string s = "hello";
            result.Append(s);
            Console.WriteLine("result = {0}\n", result);

            // Portion of a string starting at index 1 & the following 3 characters
            result.Append(" ");
            Console.WriteLine("Append( s,1,3 )");
            result.Append(s, 1, 3);
            Console.WriteLine("result = {0}\n", result);
            result.Append(" ");

            // Object string
            Object o = "good bye"; // object string
            Console.WriteLine("Appending a string through an Object reference");
            result.Append(o);
            Console.WriteLine("result = {0}\n", result);
            result.Append(" ");

            // Char array
            char[] charArray = { 'a', 'b', 'c', 'd', 'e', 'f' };
            Console.WriteLine("Appending a character array");
            result.Append(charArray);
            Console.WriteLine("result = {0}\n", result);
            result.Append(" ");

            // Portion of a char array starting at index 0 & the following 3 characters
            Console.WriteLine("Appending ( charArray, 0, 3 )");
            result.Append(charArray, 0, 3);
            Console.WriteLine("result = {0}\n", result);
            result.Append(" ");

            // Bool
            bool b = true;
            Console.WriteLine("Appending a Boolean");
            result.Append(b);
            Console.WriteLine("result = {0}\n", result);
            result.Append(" ");

            // Char
            char c = 'Z';
            Console.WriteLine("Appending a character");
            result.Append(c);
            Console.WriteLine("result = {0}\n", result);
            result.Append(" ");

            // Reapet char 3 times
            Console.WriteLine("Appending a repeated character");
            result.Append(c, 3);
            Console.WriteLine("result = {0}\n", result);
            result.Append(" ");

            // Int
            int i = 7;
            Console.WriteLine("Appending an integer");
            result.Append(i);
            Console.WriteLine("result = {0}\n", result);
            result.Append(" ");

            // Long
            long l = 10000000;
            Console.WriteLine("Appending a long integer");
            result.Append(l);
            Console.WriteLine("result = {0}\n", result);
            result.Append(" ");

            // Float
            float f = 2.5f;
            Console.WriteLine("Appending a float");
            result.Append(f);
            Console.WriteLine("result = {0}\n", result);
            result.Append(" ");

            // Double
            double d = 33.333;
            Console.WriteLine("Appending a double");
            result.Append(d);

            Console.WriteLine("result = {0}\n", result);
        }
    }
}
