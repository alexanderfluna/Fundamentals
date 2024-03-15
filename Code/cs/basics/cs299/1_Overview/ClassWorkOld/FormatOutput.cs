using System;

namespace ConsoleApplication1
{
    public class Mortgage    {
        public static void Main()  {
            int hours = 6;
            int week_number = 2;
            Console.WriteLine("He worked {0} hours in week number {1}.", 
                    hours, week_number);            
            double payment = 0.94;            
            Console.WriteLine("Your monthly payment is {0:c}", payment);     
            String output = String.Format("{0:c3}", payment);
            Console.WriteLine(output);
            output = String.Format("{0:f4}", payment);
            output = String.Format("{0:00.0000}", payment);
            Console.WriteLine(output);

            String path2 = @"\\FileShare\Directory\file.txt";
            Console.WriteLine(path2);


        }
    }
}
