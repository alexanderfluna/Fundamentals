using System;

namespace ConsoleApplication1
{
    public class Mortgage    {
        public static void Main()  {  
            double principal;
            double yearlyInterest;
            int years;

            Console.Write ("Loan amount (no commas): ");
            string temp = Console.ReadLine();
            principal = double.Parse(temp);

            Console.Write("Interest rate in % (e.g., use 7.5 for 7.5%): ");
            temp = Console.ReadLine();
            yearlyInterest = double.Parse(temp)/100;
            
            Console.Write ("The number of years: ");
            temp = Console.ReadLine();            
            years = int.Parse(temp);           

            double monthlyInterest = yearlyInterest / 12;
            double payment = principal * monthlyInterest /
                            (1 - (Math.Pow(1/(1 + monthlyInterest),
                                           years * 12)));
            Console.WriteLine("Your monthly payment is {0:c}", payment);            
        }
    }
}
