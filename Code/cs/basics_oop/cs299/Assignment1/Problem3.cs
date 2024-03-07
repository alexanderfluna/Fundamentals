// Alexander Luna | Problem 3
using System;

namespace Assignment1
{
    class Problem3
    {
        static void Main(string[] args)
        {
            // Print out the purpose of the program
            Console.WriteLine("This program will read a string from the keyboard " +
                "and reverse the string by \nsplitting it into two parts at position " +
                "n/2, reversing the left part, reversing \nthe right part and " +
                "combining the two reversed parts in reversed order.\n\n" +
                "Enter a string (type CTRL+Z and Enter to finish): ");

            string input; // store the user's input string

            // Keep reading from the console until the user types CTRL+Z and Enter
            while ((input = Console.ReadLine()) != null)
            {
                string reversed = Reverse(input); // reverse the string
                Console.WriteLine($"\nReversed string: {reversed}"); // print the reversed string
                Console.WriteLine("\nEnter a string: (type CTRL+Z and Enter to finish):");
            }
        }

        static string Reverse(string str)
        {
            // Base case: If the string has length 0 or 1, return the string itself
            if (str.Length <= 1)
                return str;

            // Calculate the midpoint index
            int mid = str.Length / 2;

            // Split the string into left and right parts
            string leftPart = str.Substring(0, mid);
            string rightPart = str.Substring(mid);

            // Reverse the left and right parts recursively
            string reversedLeft = Reverse(leftPart);
            string reversedRight = Reverse(rightPart);

            // Combine the reversed right part followed by the reversed left part
            return reversedRight + reversedLeft;
        }
    }
}
