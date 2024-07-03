using System;
using System.Text.RegularExpressions;

namespace Test {

    public class Solution
    {
        static void Main()
        {
            // Sample text
            string text = "Hello, my email is email@gmail.com and my phone number is 123-456-7890.";
            Console.WriteLine(text);

            // \b: On boundary
            // One or more letters and/or numbers followed by @
            // One or more letters and/or numbers followed by .
            // Two or more uppercase or lowercase letters
            string emailPattern = @"\b[A-Za-z0-9]+@[A-Za-z0-9]+\.[A-Z|a-z]{2,}\b";

            // \b: On boundary
            // 3 digits - 3 digits - 4 digits
            string phonePattern = @"\b\d{3}-\d{3}-\d{4}\b";

            // Test email pattern
            Match m = Regex.Match(text, emailPattern);
            if (m.Success)
            {
                Console.WriteLine("Email: " + m.Value);
            }

            // Test phone pattern
            m = Regex.Match(text, phonePattern);
            if (m.Success)
            {
                Console.WriteLine("Phone: " + m.Value);
            }
        }
    }

}