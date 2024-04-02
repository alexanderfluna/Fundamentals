using System;

namespace Menu
{
    class Program
    {

        // Delegate used to point to Square, Cube, or FourthPower
        delegate double PowerDelegate(double num);

        static void Main()
        {
<<<<<<< HEAD
            char choice;

            do
            {
                choice = DisplayMenu();

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
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("\nERROR: Invalid option. Please enter S, C, F, or Q.");
=======
            char choice; // store user input

            do
            {
                choice = DisplayMenu(); // display menu

                // Pass the function corresponding to the user's input
                switch (choice)
                {
                    case 'S':
                        ProcessOption("Square", Square);
                        break;
                    case 'C':
                        ProcessOption("Cube", Cube);
                        break;
                    case 'F':
                        ProcessOption("Fourth Power", FourthPower);
                        break;
                    case 'Q':
                        Console.WriteLine("\nExiting program...");
                        break;
                    default:
                        Console.WriteLine("\nInvalid option. Please enter S, C, F, or Q.");
>>>>>>> 11b97918d7b3f592b68408c566ac10d834167a86
                        break;
                }

                Console.WriteLine();
            } while (choice != 'Q');
        }

        // The first function will display a menu with the options Square, Cube, Fourth Power and Quit
        // It will Accept S, C, F or Q from the user. If anything else is entered,
        // the function will display  an error message and ask for a correct input.
        static char DisplayMenu()
        {
<<<<<<< HEAD
            Console.WriteLine("Select one of the following options:");
=======
            Console.WriteLine("Select an option:");
>>>>>>> 11b97918d7b3f592b68408c566ac10d834167a86
            Console.WriteLine("S - Square");
            Console.WriteLine("C - Cube");
            Console.WriteLine("F - Fourth Power");
            Console.WriteLine("Q - Quit");

            Console.Write("Enter your choice: ");
            return char.ToUpper(Console.ReadKey().KeyChar);
        }

<<<<<<< HEAD
        static void ProcessOption(string option, PowerDelegate powerFunction)
        {
            double num;
            do
            {
                Console.WriteLine();
                Console.Write($"Enter a number (0 to 100) to calculate the {option} (enter 0 to go back to the menu): ");
                if (!double.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("ERROR: Invalid input. Please enter a valid number.");
                    continue;
                }

                if (num < 0 || num > 100)
                {
                    Console.WriteLine("ERROR: Number must be in the range 0 to 100.");
                    continue;
                }

                if (num == 0)
                    return;

                double result = powerFunction(num);
                Console.WriteLine($"The {option} of {num} is {result}");
=======
        // When a valid option is selected, the second function will ask for a number in the range 0 to 100
        // It will calculate (using a delegate argument) and display the appropriate answer and will keep  
        // repeating the same option until 0 is entered. After 0 is entered re-display the menu.
        static void ProcessOption(string option, PowerDelegate powerFunction)
        {
            double num; // store the user's input
            do
            {
                // Ask the user to input a number in the range 0-100
                Console.Write($"\nEnter a number (0 to 100) to calculate the {option} (enter 0 to go back to the menu): ");

                // Verify the input is a number
                if (!double.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                // Verify the number is in the range 0-100
                if (num < 0 || num > 100)
                {
                    Console.WriteLine("Number must be in the range 0 to 100.");
                }

                if (num == 0)
                    return;

                double result = powerFunction(num);
                Console.WriteLine($"{option} of {num} is {result}");

>>>>>>> 11b97918d7b3f592b68408c566ac10d834167a86
            } while (num != 0);
        }

        // Input: number to be squared
        // Output: the number after being raised to the 4th power
        static double Square(double num)
        {
            return Math.Pow(num, 2);
        }

        // Input: number to be cubed
        // Output: the number after being raised to the 4th power
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
