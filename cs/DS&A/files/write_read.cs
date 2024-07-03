using System;
using System.IO;

class FileInputExample
{
    static void Main()
    {
        Console.Write("Enter the name of the file: ");
        string fileName = Console.ReadLine();

        // Open the file or create it if it doesn't exist
        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            Console.Write("Enter the message to input into the file: ");
            string userInput = Console.ReadLine();

            // Write the user input into the file
            writer.WriteLine(userInput);

            Console.WriteLine("Message successfully written to the file.");
        }

        Console.WriteLine($"Contents of the file '{fileName}':");
        
        // Read and display the contents of the file
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
