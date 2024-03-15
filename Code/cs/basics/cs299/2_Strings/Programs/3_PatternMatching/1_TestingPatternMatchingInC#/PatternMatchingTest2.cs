using System;
using System.Text.RegularExpressions;

namespace RegexpTest
{  

    class Program
    {
        static void Main(string[] args)
        {
            Match m;
            
            string text = "ABRACADABRA1abracadabra2abracadabra3";
            string pat = @"abra";
            Regex r = new Regex(pat, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            m = r.Match(text);
            Console.WriteLine("Match=" + m.ToString());
            
            // Substitutions
            text = "***Hello World***";
            //$2 refers to the match for the second parenthesized expression
            string s = Regex.Replace(text, @"(\w+) (\w+)", "$2");
            Console.WriteLine(s);

            // remove the beginning and ending spaces
            s = Regex.Replace("  abra  ", @"^\s*(.*)\s*$", "$1");
            Console.WriteLine(s);

            //$` refers to the part of the string before the match
            text = "---hello***";
            s = Regex.Replace(text, @"(\b\w+\b)", "$`");
            Console.WriteLine(s);

            //$' refers to the part of the string after the match
            text = "---hello***";
            s = Regex.Replace(text, @"(\b\w+\b)", "$'");
            Console.WriteLine(s);

            text = "---hello***";
            s = Regex.Replace(text, @"(\b\w+\b)", "  $'  ");
            Console.WriteLine(s);

            text = "***hello***";
            s = Regex.Replace(text, @"(\b\w+\b)", "  $&  ");
            Console.WriteLine(s);

            
            // Refering to the matches within the pattern
            // \1 refers to the match of the first parenthesized expression
            // find a repeated word character sequence
            text = "This is Hello Hello World Eexample";
            m = Regex.Match(text, @"(\w+)\s\1");
            if (!m.Success)
                Console.WriteLine("No match");
            else
                Console.WriteLine("|" + m + "|");

            // find all repeated word character sequences            
            Regex ex = new Regex(@"(\w+)\s\1");
            foreach (Match match in ex.Matches(text))
                Console.WriteLine(match);
           
            // find a repeated whole word
            text = "This is Hello Hello World Example";
            m = Regex.Match(text, @"(\b\w+\b)\s+\1");
            if (!m.Success)
                Console.WriteLine("No match");
            else
                Console.WriteLine("|" + m + "|");


        }
    }


}
