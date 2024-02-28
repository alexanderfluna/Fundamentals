// Alexander Luna | Problem 1
using System;
using System.Text.RegularExpressions;

namespace Assignment1
{
    class Problem1
    {
        static void Main()
        {
            // Print the purpose of the program
            Console.WriteLine("This program will read from the keyboard lines of a C " +
                "or C++ program and will output for each line of the input:\n" +
                "a. The number of words in the line (only counting user-defined names and language keywords\n" +
                "b. The number of numeric literals on the line\n" +
                "c. The number of pairs of closed braces and parentheses on the line\n\n" +
                "Enter C/C++ code (type Ctrl+Z and Enter to finish):");

            string line; // store C/C++ code

            // Keep reading from the console until the user types CTRL+Z and Enter
            while ((line = Console.ReadLine()) != null) 
            {
                // Store counts
                int wordCount = CountWords(line);
                int numericLiteralCount = CountNumericLiterals(line);
                int braceParenthesesCount = CountBraceParenthesesPairs(line);

                // Print counts
                Console.WriteLine($"a. Number of words: {wordCount}");
                Console.WriteLine($"b. Number of numeric literals: {numericLiteralCount}");
                Console.WriteLine($"c. Number of brace and parentheses pairs: {braceParenthesesCount}");
            }
        }

        // Input: string line = C/C++ code
        // Output: int = The number of words in the line of C/C++ code (only counting user-defined names and language keywords)
        static int CountWords(string line)
        {
            // Creates a regular expression to match the C/C++ language keywords and any user-defined names
            // \b = On word boundary
            // ?: = Non-capturing group
            // int|char|float|... = OR statement of C/C++ language keywords
            // [a-zA - Z_]\w* = User-defined names that start with a letter or underscore followed by 0 or more letters, underscores, or numbers
            Regex wordRegex = new Regex(@"\b(?:int|char|float|double|void|auto|break|case|const|continue|default|do|else|enum|extern|for|goto|if|long|register|return|short|signed|sizeof|public|struct|switch|typedef|union|unsigned|volatile|while|bool|true|false)\b|\b[a-zA-Z_]\w*\b");

            // Return the number of times the line of C/C++ code matches a term in the regex
            return wordRegex.Matches(line).Count;
        }

        // Input: string line = C/C++ code
        // Output: int = The number of numeric literals in the line of C/C++ code
        static int CountNumericLiterals(string line)
        {
            // Creates a regular expression to match numeric literals
            // \b = On word boundary
            // \d+ = One or more digits
            // (\.\d+)? = Optional dot followed by one or more digits (i.e floats/doubles)
            Regex numericLiteralRegex = new Regex(@"\b\d+(\.\d+)?\b");

            // Return the number of times the line of C/C++ code matches a term in the regex
            return numericLiteralRegex.Matches(line).Count;
        }

        // Input: string line = C/C++ code
        // Output: int = The number of pairs of closed braces and parentheses in the line of C/C++ code
        static int CountBraceParenthesesPairs(string input)
        {
            // Store counts
            int curlyBrace = 0;
            int parentheses = 0;
            int pairs = 0;

            // Iterate through C/C++ code character by character
            foreach (char c in input)
            {
                // If the current character is an open brace, increment curly brace count
                if (c == '{')
                {
                    curlyBrace++;
                }

                // Else if the current character is a closed brace, decrement curly brace count
                else if (c == '}')
                {
                    // If the curly brace count is greater than 0
                    if (curlyBrace > 0)
                    {
                        curlyBrace--; // decrement the curly brace count
                        pairs++; // increment the number of pairs
                    }
                }

                // Else if the current character is an open parentheses, increment parentheses count
                else if (c == '(')
                {
                    parentheses++;
                }

                // Else if the current character is a closed parentheses, decrement parentheses count
                else if (c == ')')
                {
                    // If the parentheses count is greater than 0
                    if (parentheses > 0)
                    {
                        parentheses--; // decrement the parentheses count
                        pairs++; // increment the number of pairs
                    }
                }
            }

            // Return the number of pairs
            return pairs;
        }
    }
}
