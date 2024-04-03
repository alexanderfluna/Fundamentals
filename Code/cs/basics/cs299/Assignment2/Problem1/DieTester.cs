// Alexander Luna | Assignment 2 | Problem 1
using System;

namespace C_SharpConsoleProject
{
    class Program
    {
        static void Main()
        {
            // Print the purpose of the program
            Console.WriteLine("This program will make an array of dice and sort them " +
                "using the static System.Array.Sort method\n");

            // Create an array of 6 Die objects
            Die[] dice = new Die[6];
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }

            // Sort the array using System.Array.Sort
            Array.Sort(dice);

            // Print the sorted array
            Console.Write("Sorted Dice: ");
            foreach (Die die in dice)
            {
                Console.Write(die + " ");
            }
            Console.WriteLine();
        }
    }
}
