// Alexander Luna | Assignment 2 | Problem 2
using System;

namespace Menu
{
    class Program
    {
        delegate double PowerDelegate(double num);

        static void Main(string[] args)
        {
            char choice = ' ';

            do
            {
                try
                {
                    choice = DisplayMenu();

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
                            Console.WriteLine("Exiting program...");
                            break;
                        default:
                            throw new InvalidOperationException("Invalid option. Please enter S, C, F, or Q.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nError: {ex.Message}");
                }

                Console.WriteLine();
            } while (choice != 'Q');
        }

        static char DisplayMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("S - Square");
            Console.WriteLine("C - Cube");
            Console.WriteLine("F - Fourth Power");
            Console.WriteLine("Q - Quit");

            Console.Write("Enter your choice: ");
            return char.ToUpper(Console.ReadKey().KeyChar);
        }

        static void ProcessOption(string optionName, PowerDelegate powerFunction)
        {
            double num = 0;
            do
            {
                try
                {
                    Console.WriteLine();
                    Console.Write($"Enter a number (0 to 100) to calculate the {optionName} (enter 0 to go back to the menu): ");
                    if (!double.TryParse(Console.ReadLine(), out num))
                    {
                        throw new FormatException("Invalid input. Please enter a valid number.");
                    }

                    if (num < 0 || num > 100)
                    {
                        throw new ArgumentOutOfRangeException("Number must be in the range 0 to 100.");
                    }

                    if (num == 0)
                        return;

                    double result = powerFunction(num);
                    Console.WriteLine($"{optionName} of {num} is {result}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            } while (num != 0);
        }

        static double Square(double num)
        {
            return Math.Pow(num, 2);
        }

        static double Cube(double num)
        {
            return Math.Pow(num, 3);
        }

        static double FourthPower(double num)
        {
            return Math.Pow(num, 4);
        }
    }
}
