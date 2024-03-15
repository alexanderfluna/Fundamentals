using System;
using System.Text.RegularExpressions;

namespace Test
{
    public class Solution
    {
        static void Main()
        {
            // Matches the first string found of one or more a's, b's, or r's
            Match m = Regex.Match("abracabrabra", @"(a|b|r)+");
            if (m.Success)
                Console.WriteLine("Match1: " + m.Value);

            // Matches the first letter found a, b, or r
            m = Regex.Match("abracadabra", @"[abr]");
            if (m.Success)
                Console.WriteLine("Match2: " + m.Value);

            // Matches the first letter found in the range c - e
            // c, d, e
            m = Regex.Match("abracadabra", "[c-e]");
            if (m.Success)
                Console.WriteLine("Match3: " + m.Value);

            // Matches the first non-digit character
            m = Regex.Match("?abracadabra", @"\D");
            if (m.Success)
                Console.WriteLine("Match4: " + m.Value);

            // Matches the first letter, digit, underscore
            m = Regex.Match("_1a.bracadabra", @"\w");
            if (m.Success)
                Console.WriteLine("Match5: " + m.Value);

            // Matches the first NON letter, digit, underscore
            m = Regex.Match("_1a.bracadabra", @"\W");
            if (m.Success)
                Console.WriteLine("Match5: " + m.Value);

            // Matches the first white space character
            m = Regex.Match("abrac adabra", @"\s");
            if (m.Success)
                Console.WriteLine("Match6: " + m.Value);

            // Matches the first NON white space character
            m = Regex.Match("abrac adabra", @"\S");
            if (m.Success)
                Console.WriteLine("Match7: " + m.Value);

            // Matches the first letter, digit, underscore
            // followed by space followed by the letter r
            m = Regex.Match("abracadab1_ ra", @"\w\b\sr");
            if (m.Success)
                Console.WriteLine("Match8: " + m.Value);

            // Matches the first letter b followed by 
            // NON boundary followed by the letter r
            m = Regex.Match("ab racadabra", @"b\Br");
            if (m.Success)
                Console.WriteLine("Match9: " + m.Value);

            // Matches the first letter b followed by the letter r
            // Does the same thing as the previous match
            m = Regex.Match("ab racadabra", @"br");
            if (m.Success)
                Console.WriteLine("Match10: " + m.Value);

            // Matches the first usage of the pattern
            // ignoring the pattern's case
            string input = "ABRACADABRA1abracadabra2abracadabra3";
            string pattern = @"abra";
            Regex regex = new Regex(pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            m = regex.Match(input);
            if (m.Success)
                Console.WriteLine("Match11: " + m.Value);

            // Matches the first 3 words 
            m = Regex.Match("John F Kennedy Jr.", @"(\w+) (\w+) (\w+)");
            if (m.Success)
                Console.WriteLine("\nMatch12: " + m.Value);

            foreach (Group g in m.Groups)
                Console.WriteLine(g);

            foreach (Capture c in m.Captures)
                Console.WriteLine(c);

            // Matches the first repeated word
            m = Regex.Match("Hello Hello World", @"(\w+)\s\1");
            if (m.Success)
                Console.WriteLine("\nMatch13: " + m.Value); ;

            // Replace the a's in the input with b's
            string s = Regex.Replace("abra", @"a", @"b");
            Console.WriteLine("Replace: " + s);

            
        }
    }
}