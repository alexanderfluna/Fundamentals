using System;
using System.Text.RegularExpressions;

namespace Test {
    public class Solution
    {
        static void Main()
        {
            // Ignore case of the pattern
            Match m = Regex.Match("ABRAcadABRA", "abra", RegexOptions.IgnoreCase);
            if (m.Success)
                Console.WriteLine("Input1: "+ m.Value);

            // Ignore white spaces in the pattern
            m = Regex.Match("abra", "ab ra", RegexOptions.IgnorePatternWhitespace);
            if (m.Success)
                Console.WriteLine("Input2: " + m.Value);

            // Does not work because it is not at the end of the line
            m = Regex.Match("ABRACADABRA1\nabracadabra2\nabracadabra3", @"A1$");
            if (m.Success)
                Console.WriteLine("Input3: " + m.Value);

            // This does work because of the multiline option
            Regex r = new Regex(@"A1$",
                RegexOptions.Multiline);
            m = r.Match("ABRACADABRA1\nabracadabra2\nabracadabra3");
            if (m.Success)
                Console.WriteLine("Input4: " + m.Value);
        }
    }
}