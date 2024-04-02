using System;

namespace Menu
{
    class Program
    {
        delegate double PowerDelegate(double num);

        static void Main()
        {
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
                        break;
                }

                Console.WriteLine();
            } while (choice != 'Q');
        }

        static char DisplayMenu()
        {
            Console.WriteLine("Select one of the following options:");
            Console.WriteLine("S - Square");
            Console.WriteLine("C - Cube");
            Console.WriteLine("F - Fourth Power");
            Console.WriteLine("Q - Quit");

            Console.Write("Enter your choice: ");
            return char.ToUpper(Console.ReadKey().KeyChar);
        }

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
