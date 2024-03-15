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
            Console.WriteLine("1 Match=" + m.ToString());

            pat = @"ab ra";
            r = new Regex(pat,
                System.Text.RegularExpressions.RegexOptions.IgnorePatternWhitespace);            
            m = r.Match(text);
            Console.WriteLine("2 Match=" + m.ToString());
           
            
            text = "ABRACADABRA1\nabracadabra2\nabracadabra3";
            pat = @"A1$";
            m = r.Match(text);
            Console.WriteLine("3 Match=" + m.ToString());

            r = new Regex(pat,
                System.Text.RegularExpressions.RegexOptions.Multiline);
            m = r.Match(text);
            Console.WriteLine("4 Match=" + m.ToString());

            Console.ReadKey();
        }
    }


}
