using System;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary
    /// This program demonstrates the length and capacity methods 
    /// of the StringBuilder class.

    public class StringBuilderModification
    {
        public static void Main()
        {
            Console.WriteLine("Stringresultfer length and capacity Methods\n");

            // New Stringbuilder
            StringBuilder result =
                new StringBuilder("hello there");

            // Create new string starting at index 6 & grabbing the next 3 characters of result            
            string temp = result.ToString(6, 3);
            Console.WriteLine("result = {0}, temp = {1}", result, temp);
            //string temp = result; //cannot convert
            //StringBuilder temp =(StringBuilder) result.ToString(3,6); //cannot convert

            // Insert "hello" into index 6 of the string
            result.Insert(6, "hello ");
            Console.WriteLine("result = {0}", result);

            // Remove the following 6 characters from index 6 of the string
            result.Remove(6, 6);
            Console.WriteLine("result = {0}", result);

            // Replace all lowercases 'h' in the string with uppercase 'H'
            result.Replace('h', 'H');
            Console.WriteLine("result = {0}", result);

            // Starting at index 6 and the following 1 character:
            // Replace any lowercases 'h' to an uppercase 'H'
            result.Replace('H', 'h', 6, 1);
            Console.WriteLine("result = {0}", result);

            // Starting from index 6 to the end of the string - 6
            // Replace all uppercase 'H' with lowercase 'h'
            result.Replace('H', 'h', 6, result.Length - 6);
            Console.WriteLine("result = {0}", result);
            // result.Replace('H','h',6,result.Length); //overflow

            // Replaces all "Hello" with "HELLO"
            result.Replace("Hello", "HELLO");
            Console.WriteLine("result = {0}", result);

            Console.WriteLine();
        }
    }

}
