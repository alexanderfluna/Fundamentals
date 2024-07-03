using System;
using System.Text.RegularExpressions;

namespace RegexpTest
{  

    class Program
    {
        static void Main(string[] args)
        {
            // matching a.b
            Match m = Regex.Match("abra.bcadabra", @"a\.b");
            if (m.Success)
                Console.WriteLine("Success");
            Console.WriteLine("Match=" + m.ToString());

            // matching exactly dab
            m = Regex.Match("abracadabra", "dab");
            if (m.Success)
                Console.WriteLine("Success");
            Console.WriteLine("Match=" + m.ToString());

            // matching any of a or b or r; finds the first a
            m = Regex.Match("abracadabra", "(a|b|r)");
            if (m.Success)
                Console.WriteLine("Success");
            Console.WriteLine("Match=" + m.ToString());
            
            // a sequence of one or more a or b or r
            m = Regex.Match("abracadabra", "(a|b|r)+");
            if (m.Success)
                Console.WriteLine("Success");
            Console.WriteLine("Match=" + m.ToString());

            // a sequence of digits; finds 123
            m = Regex.Match("abr123aca3454dabra", @"\d+");
            if (m.Success)
                Console.WriteLine("Success");
            Console.WriteLine("Match=" + m.ToString());
            
            // finds abra
            m = Regex.Match("abracadabra", "a..a");
            if (m.Success)
                Console.WriteLine("Success");
            Console.WriteLine("Match=" + m.ToString());

            // finds a
            m = Regex.Match("abracadabra", "[abr]");
            Console.WriteLine("Match=" + m.ToString());

            // finds c
            m = Regex.Match("abracadabra", "[c-e]");
            Console.WriteLine("Match=" + m.ToString());

            // the first non-digit
            m = Regex.Match("abracadabra", @"\D");
            Console.WriteLine("Match=" + m.ToString());
            
            // the first word character
            m = Regex.Match("abracadabra", @"\w");
            Console.WriteLine("Match=" + m.ToString());

            // a sequence of word charaters
            m = Regex.Match("abracadabra", @"\w+");
            Console.WriteLine("Match=" + m.ToString());

            // the first non-word character
            m = Regex.Match("abraca.dabra", @"\W");
            Console.WriteLine("Match=" + m.ToString());

            // word character, then white space, then word character: a d
            m = Regex.Match("abraca dabra", @"\w\s\w");
            Console.WriteLine("Match=" + m.ToString());

            // word character at the word boundary - the last character of a word
            m = Regex.Match("abrac adabra", @"\w\b");
            Console.WriteLine("Match=" + m.ToString());

            //word character, word boundary, space , d: a d 
            m = Regex.Match("a b ra c   a c a dabra", @"\w\b\sd");
            Console.WriteLine("Match=" + m.ToString());

            // word character, one or more spaces, , then a: c   a
            m = Regex.Match("a b ra c   a c a dabra", @"\w\s+a");
            Console.WriteLine("Match=" + m.ToString());

            // b not at the end of word, and the next character
            m = Regex.Match("ab rac  a   dabra", @"b\B.");
            Console.WriteLine("Match=" + m.ToString());

            // three word characters: rac
            m = Regex.Match("ab raca   dabra", @"\w{3}");
            Console.WriteLine("Match=" + m.ToString());

            // zero or more times a word character followed by a: the first a
            m = Regex.Match("ab raca   dabra", @"\w*a");
            Console.WriteLine("Match=" + m.ToString());

            // zero or more word characters followed by c: rac
            m = Regex.Match("ab raca   dabra", @"\w*c");
            Console.WriteLine("Match=" + m.ToString());

            // show all matches
            foreach (Match match in Regex.Matches("abracadabra", @"a."))
                Console.Write(match.ToString() + " ");
            Console.WriteLine();

            // search for perl in the beginning of the string
            m = Regex.Match("perls are pretty", "^perl");
            Console.WriteLine("Match=" + m.ToString());

            // should not find perl
            m = Regex.Match("My perls are pretty", "^perl");
            Console.WriteLine("Match=" + m.ToString());
           
            // Looking at the end of the string: ty, not tt
            m = Regex.Match("My perls are pretty", "t.$");
            Console.WriteLine("Match=" + m.ToString());
            
            
            string text = "ABRACADABRA1abracadabra2abracadabra3";
            string pat = @"abra";
            Regex r = new Regex(pat, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            m = r.Match(text);
            Console.WriteLine("Match=" + m.ToString());

            text = "John Fitzgerald Kennedy";
            m = Regex.Match(text, @"(\w+) (\w+) (\w+)");
            foreach (Group g in m.Groups)
                Console.WriteLine(g);
            
            
            
            string s = Regex.Replace("  abra  ", @"^\s*(.*)\s*$", "$1");
            Console.WriteLine(s);
            /*
           

            foreach (Capture g in m.Captures)
                Console.WriteLine(g);

            text = "Hello Hello World";            
            m = Regex.Match(text, @"(\w+)\s\1");
            if (!m.Success)
                Console.WriteLine("No match");
            else                
                Console.WriteLine("|" + m + "|");

            
            

*/


            

            Console.ReadKey();
        }
    }


}
