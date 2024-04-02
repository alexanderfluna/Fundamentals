// Alexander Luna | Assignment 2 | Problem 1
using System;

namespace C_SharpConsoleProject
{
    class Program
    {
        static void Main()
        {
            // Create an array of 6 Die objects
            Die[] dice = new Die[6];
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }

            // Sort the array using System.Array.Sort
            Array.Sort(dice);

            // Print the sorted array
            Console.WriteLine("Sorted Dice:");
            foreach (Die die in dice)
            {
                Console.WriteLine(die);
            }
        }
    }
}
