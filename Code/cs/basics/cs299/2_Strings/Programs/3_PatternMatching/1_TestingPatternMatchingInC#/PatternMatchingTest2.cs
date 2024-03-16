using System;
using System.Text.RegularExpressions;

namespace Test
{
    public class Solution
    {
        static void Main()
        {
            // Replace all digits in the string with 1
            string input = "I am 23 years old.";
            input = Regex.Replace(input, @"\d", "1");
            Console.WriteLine("Input1: " + input);

            // Replace all spaces with questions marks
            input = Regex.Replace(input, @"\s", "?");
            Console.WriteLine("Input2: " + input);

            // Ignore the case of the pattern
            input = "ABRACADABRA1abracadabra2abracadabra3";
            string pattern = @"abra";
            Regex r = new Regex(pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            Match m = r.Match(input);
            if (m.Success)
            {
                Console.WriteLine("Input3: " + m.Value);
            }

            // $2 refers to the match for the second parentheseized expression
            input = "***Hello There World***";
            string s = Regex.Replace(input, @"(\w+) (\w+) (\w+)", "$2");
            Console.WriteLine("Input4: " + s);

            // Remove all spaces from start and end of the string
            s = Regex.Replace("  abra ", @"^\s*(.*)\s*", "$1");
            Console.WriteLine("Input5: " + s);

            // Replace the word in the middle with what came before it
            input = "---hello***";
            s = Regex.Replace(input, @"(\b\w+\b)", "$`");
            Console.WriteLine("Input6: " + s);

            // Replace the word in the middle with what comes after it
            s = Regex.Replace(input, @"(\b\w+\b)", "$'");
            Console.WriteLine("Input7: " + s);

            // Replace the word in the middle with what comes after it
            // and adds spaces before and after the middle
            s = Regex.Replace(input, @"(\b\w+\b)", "  $'  ");
            Console.WriteLine("Input8: " + s);

            // Only add spaces before and after the middle
            s = Regex.Replace(input, @"(\b\w+\b)", "  $&  ");
            Console.WriteLine("Input9: " + s);

            // Matches first repeated character sequence
            input = "This is Hello Hello Hello World Example";
            m = Regex.Match(input, @"(\w+)\s\1");
            if (m.Success)
                Console.WriteLine("Input10: " + m.Value);

            // Matches all repeated character sequences
            Regex ex = new Regex(@"(\w+)\s\1");
            Console.WriteLine("\nInput11: ");
            foreach (Match match in ex.Matches(input))
                Console.WriteLine(match);

            // Matches the first repeated whole word
            m = Regex.Match(input, @"(\b\w+\b)\s+\1");
            if (m.Success)
                Console.WriteLine("\nInput12: " + m.Value);
        }
    }
}