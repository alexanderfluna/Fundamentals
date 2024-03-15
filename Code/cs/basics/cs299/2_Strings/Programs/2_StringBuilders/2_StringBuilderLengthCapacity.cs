using System;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary
    /// This program demonstrates the length and capacity methods 
    /// of the StringBuilder class.

    public class StringBuilderLengthCapacity
    {
        public static void Main()
        {
            Console.WriteLine("Stringresultfer length and capacity Methods\n");

            // New Stringbuilder string with "Hello"
            StringBuilder result =
                new StringBuilder("Hello");

            // Prints out the string, string length, string capacity, and its max capacity
            Console.WriteLine("result = {0}, Length = {1}, Capacity = {2}, MaxCapacity = {3}",
                             result, result.Length, result.Capacity, result.MaxCapacity);

            // Add to the end of the string ", how are you?"
            result.Append(", how are you?");
            Console.WriteLine("\nresult = {0}, Length = {1}, Capacity = {2}",
                result, result.Length, result.Capacity);
            
            // Capacity stays the same because it is already greater than 10
            Console.WriteLine("\nNew capacity = " + result.EnsureCapacity(10));

            // The new capacity is 33 because it is greater than 32
            Console.WriteLine("\nNew capacity = " + result.EnsureCapacity(33));

            // Changes the capacity of result
            result.Capacity = 60;
            Console.WriteLine("\nNew capacity = " + result.Capacity);

            Console.WriteLine();
        }
    }

}
