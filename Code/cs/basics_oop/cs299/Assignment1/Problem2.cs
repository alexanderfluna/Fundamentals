// Alexander Luna | Problem 2
using System;
using System.Text.RegularExpressions;

namespace Assignment1
{
    public class Problem2
    {
        static readonly string vowels = "aeiouy"; // store the vowels
        static int firstVowelPointer = 0; // points to the first vowel
        static int secondVowelPointer = 0; // points to the second vowel

        static void Main()
        {
            // Print the purpose of the program
            Console.WriteLine("This program will read from the keyboard an " +
                "English phrase and encode the words in the phrase into Pig Latin.\n" +
                "Enter an English phrase (type CTRL+Z and Enter to finish):");

            string phrase; // store the English phrase

            // Keep reading from the console until the user types CTRL+Z and Enter
            while ((phrase = Console.ReadLine()) != null)
            {
                string result = EncodeToPigLatin(phrase); // encode the phrase to Pig Latin
                Console.WriteLine($"The phrase encoded into Pig Latin is: {result}"); // print the encoded phrase
            }
        }

        // Input: string phrase = the English phrase to be encoded into Pig Latin
        // Output: string = the encoded phrase in Pig Latin
        static string EncodeToPigLatin(string phrase)
        {
            string[] words = phrase.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // split the words in the phrase
            string result = ""; // accumulates the encoded words

            // Iterate through each word of the phrase
            foreach (string word in words)
            {
                char firstLetter = word[0]; // get the first letter of the word

                string remainingLetters = word.Substring(1); // get the remaining letters of the word

                string twoVowelString = GetNextTwoVowelString(); // get the next two-vowel string

                result += remainingLetters + firstLetter + twoVowelString + " "; // encode the word into Pig Latin
            }

            return result;
        }

        // Output: the next two-vowel string in the sequence
        static string GetNextTwoVowelString()
        {
            // Iterate the firstVowelPointer through the vowels string
            if (firstVowelPointer < vowels.Length)
            {
                // Iterate the secondVowelPointer through the vowels string
                if (secondVowelPointer < vowels.Length - 1)
                {
                    secondVowelPointer++; // increment the secondVowelPointer

                    // If the secondVowelPointer is pointing to the same vowel as the firstVowelPointer
                    if (secondVowelPointer == firstVowelPointer)
                    {

                        // If the firstVowellPointer is pointing to the last vowel
                        if (firstVowelPointer == vowels.Length - 1)
                        {
                            // Reset the pointers
                            firstVowelPointer = 0;
                            secondVowelPointer = 0;
                        }

                        secondVowelPointer++; // increment the secondVowelPointer again
                    }

                }
                // When the secondVowelPointer reaches the last vowel
                else
                {
                    secondVowelPointer = 0; // set secondVowelPointer back to 0
                    firstVowelPointer++; // increment the firstVowelPointer
                }
            }

            // Return the two vowel string
            return $"{vowels[firstVowelPointer]}{vowels[secondVowelPointer]}";
        }
    }
}
