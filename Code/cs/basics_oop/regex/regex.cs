using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Define a sample text
        string text = "Hello, my email is john@example.com and my phone number is 123-456-7890.";

        // Define regular expressions
        string emailPattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
        string phonePattern = @"\b\d{3}-\d{3}-\d{4}\b";

        // Match email using regular expression
        Match emailMatch = Regex.Match(text, emailPattern);
        if (emailMatch.Success)
        {
            Console.WriteLine("Email found: " + emailMatch.Value);
        }
        else
        {
            Console.WriteLine("Email not found.");
        }

        // Match phone number using regular expression
        Match phoneMatch = Regex.Match(text, phonePattern);
        if (phoneMatch.Success)
        {
            Console.WriteLine("Phone number found: " + phoneMatch.Value);
        }
        else
        {
            Console.WriteLine("Phone number not found.");
        }

        // Replace email addresses with [EMAIL]
        string sanitizedText = Regex.Replace(text, emailPattern, "[EMAIL]");
        Console.WriteLine("Sanitized text: " + sanitizedText);

        // Split text using regular expression
        string[] words = Regex.Split(text, @"\W+");
        Console.WriteLine("Words in text:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // Check if text matches a pattern
        bool isMatch = Regex.IsMatch(text, @"\b[A-Za-z]+\b");
        Console.WriteLine("Text contains only letters: " + isMatch);
    }
}
