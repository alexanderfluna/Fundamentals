// Alexander Luna | Assignment 2 | Problem 2
using System;

namespace Menu
{
    class Program
    {

        // This program uses the delegate to reference
        // either the Square, Cube, or FourthPower function
        delegate double PowerDelegate(double num);

        static void Main()
        {
            // Print the purpose of the program
            Console.WriteLine("This program will display a menu with the options Square, Cube, \nFourth" +
                " Power and Quit. After selecting an option, the program will ask for a \nnumber in the " +
                " range 0 - 100 and print the result of the selected power function.\n");

            char choice = ' '; // store user input

            do
            {
                choice = DisplayMenu(); // display menu and ask user for input

                // Pass the function corresponding to the user's input
                switch (choice)
                {
                    case 'S':
                        ProcessOption("square", Square);
                        break;
                    case 'C':
                        ProcessOption("cube", Cube);
                        break;
                    case 'F':
                        ProcessOption("fourth power", FourthPower);
                        break;
                    case 'Q':
                        Console.WriteLine("\nExiting program...");
                        break;
                    default:
                        Console.WriteLine("\nERROR: Invalid option. Please enter S, C, F, or Q.");
                        break;
                }
                Console.WriteLine();

            } while (choice != 'Q'); // halt the do - while loop when user enters Q
        }

        // The first function will display a menu with the options Square, Cube, Fourth Power and Quit
        // It will Accept S, C, F or Q from the user. If anything else is entered,
        // the function will display an error message and ask for a correct input.
        // Output: a char representing the user's selected option
        static char DisplayMenu()
        {
            // Display the menu
            Console.WriteLine("Select an option:");
            Console.WriteLine("S - Square");
            Console.WriteLine("C - Cube");
            Console.WriteLine("F - Fourth Power");
            Console.WriteLine("Q - Quit");

            // Prompt the user to enter a choice
            Console.Write("Enter your choice: ");

            // Return the entered character set to uppercase
            return char.ToUpper(Console.ReadKey().KeyChar);
        }

        // When a valid option is selected, the second function will ask for a number in the range 0 to 100
        // It will calculate (using a delegate argument) and display the appropriate answer and will keep  
        // repeating the same option until 0 is entered. After 0 is entered re-display the menu.
        // Input: string option - used to print the user's selected option to the console
        // Input: PowerDelegate powerFunction - this delegate references the function that was passed in Main
        static void ProcessOption(string option, PowerDelegate powerFunction)
        {
            double num = -1; // store user input

            do
            {
                // Asks the user to input a number in the range 0-100
                Console.Write($"\n\nEnter a number (0 to 100) to calculate the {option} \n(enter 0 to go back to the menu): ");

                // Verifiies the input is a number and stores the number in num
                if (!double.TryParse(Console.ReadLine(), out num))
                {
                    // Print error if the user did not enter a valid number
                    Console.Write("ERROR: Invalid input. Please enter a valid number.");
                    num = -1; // reset num
                    continue;
                }

                // Verifies the number is in the range 0-100
                if (num < 0 || num > 100)
                {
                    // Print error if the number is not in the range 0-100
                    Console.Write("ERROR: The number must be in the range 0 to 100.");
                    continue;
                }

                if (num == 0)
                    return;

                // Call the power function that was passed and print the result
                double result = powerFunction(num);
                Console.Write($"The {option} of {num} is {result}.");

            } while (num != 0); // re-display the menu after 0 is entered
        }

        // Input: number to be squared
        // Output: the number after being squared
        static double Square(double num)
        {
            return Math.Pow(num, 2);
        }

        // Input: number to be cubed
        // Output: the number after being cubed
        static double Cube(double num)
        {
            return Math.Pow(num, 3);
        }

        // Input: number to be raised to the 4th power
        // Output: the number after being raised to the 4th power
        static double FourthPower(double num)
        {
            return Math.Pow(num, 4);
        }
    }
}