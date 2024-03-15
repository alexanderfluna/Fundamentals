using System;
using System.Text.RegularExpressions;

namespace RegexpTest
{  

    class Program
    {
        static void Main(string[] args)
        {
            Match m = Regex.Match("abracadabra", "(a|b|r)+");
            if (m.Success)
                Console.WriteLine("Success");
            Console.WriteLine("Match=" + m.ToString());

            m = Regex.Match("abracadabra", "[abr]");
            Console.WriteLine("Match=" + m.ToString());

            m = Regex.Match("abracadabra", "[c-e]");
            Console.WriteLine("Match=" + m.ToString());

            m = Regex.Match("abracadabra", @"\D");
            Console.WriteLine("Match=" + m.ToString());

            m = Regex.Match("abracadabra", @"\w");
            Console.WriteLine("Match=" + m.ToString());

            m = Regex.Match("abraca.dabra", @"\W");
            Console.WriteLine("Match=" + m.ToString());

            m = Regex.Match("abraca dabra", @"\s");
            Console.WriteLine("Match=" + m.ToString());

            m = Regex.Match("ab rac  a   dabra", @"\w\b\sr");
            Console.WriteLine("Match=" + m.ToString());

            m = Regex.Match("ab rac  a   dabra", @"b\Br");
            Console.WriteLine("Match=" + m.ToString());

            m = Regex.Match("ab rac  a   dabra", "br");
            Console.WriteLine("Match=" + m.ToString());

            string text = "ABRACADABRA1abracadabra2abracadabra3";
            string pat = @"abra";
            Regex r = new Regex(pat, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            m = r.Match(text);
            Console.WriteLine("Match=" + m.ToString());

            string s = Regex.Replace("  abra  ", @"^\s*(.*?)\s*$", "$1");
            Console.WriteLine(s);

            text = "John Fitzgerald Kennedy";
	        m = Regex.Match(text, @"(\w+) (\w+) (\w+)");
            foreach (Group g in m.Groups)
                Console.WriteLine(g);

            foreach (Capture g in m.Captures)
                Console.WriteLine(g);

            text = "Hello Hello World";            
            m = Regex.Match(text, @"(\w+)\s\1");
            if (!m.Success)
                Console.WriteLine("No match");
            else                
                Console.WriteLine("|" + m + "|");

            
            




            

            Console.ReadKey();
        }
    }


}
