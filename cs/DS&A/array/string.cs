using System;

class StringMethodsExample
{
    static void Main()
    {
        // String creation
        string str1 = "Hello, ";
        string str2 = "World!";
        string combinedString;

        // Concatenation
        combinedString = str1 + str2;
        Console.WriteLine("Concatenated String: " + combinedString);

        // Length
        int length = combinedString.Length;
        Console.WriteLine("Length of String: " + combinedString);

        // Substring
        string substring = combinedString.Substring(7, 5);
        Console.WriteLine("Substring: " + substring);

        // ToUpper
        string upperCase = combinedString.ToUpper();
        Console.WriteLine("Uppercase: " + upperCase);

        // ToLower
        string lowerCase = combinedString.ToLower();
        Console.WriteLine("Lowercase: " + lowerCase);

        // IndexOf
        int indexOfWorld = combinedString.IndexOf("World");
        Console.WriteLine("Index of 'World': " + indexOfWorld);

        // Contains
        bool containsHello = combinedString.Contains("Hello");
        Console.WriteLine("Contains 'Hello': " + containsHello);

        // StartsWith
        bool startsWithHello = combinedString.StartsWith("Hello");
        Console.WriteLine("Starts with 'Hello': " + startsWithHello);

        // EndsWith
        bool endsWithWorld = combinedString.EndsWith("World!");
        Console.WriteLine("Ends with 'World!': " + endsWithWorld);

        // Replace
        string replacedString = combinedString.Replace("World", "Universe");
        Console.WriteLine("Replaced String: " + replacedString);

        // Trim
        string spacedString = "   Trim me!   ";
        string trimmedString = spacedString.Trim();
        Console.WriteLine("Trimmed String: " + trimmedString);

        // Split
        string sentence = "This is a sample sentence.";
        string[] words = sentence.Split();
        Console.WriteLine("Words in the sentence:");
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }

        // Join
        string[] colors = { "Red", "Green", "Blue" };
        string joinedColors = string.Join(" + ", colors);
        Console.WriteLine("Joined Colors: " + joinedColors);
    }
}
