using System;

namespace ConsoleApplication1
{
   ///<summary>
   ///This class tests console input.
   ///</summary>
    public class InputTester
    {
        public static void Main()   {
          CashRegister register = new CashRegister();

          Console.Write("Enter price: $");
          string temp = Console.ReadLine();
          double price = double.Parse(temp);
          register.RecordPurchase(price);

          Console.Write("Enter dollars: $");      
          temp = Console.ReadLine();
          int dollars = int.Parse(temp);

          Console.Write("Enter quarters: ");
          temp = Console.ReadLine();
          int quarters = int.Parse(temp);

          Console.Write("Enter dimes: ");
          temp = Console.ReadLine();
          int dimes = int.Parse(temp);

          Console.Write("Enter nickels: ");
          temp = Console.ReadLine();
          int nickels = int.Parse(temp);
          
          Console.Write("Enter pennies: ");      
          temp = Console.ReadLine();
          int pennies = int.Parse(temp);
          register.EnterPayment(dollars, quarters, dimes, nickels, pennies);

          Console.WriteLine("Your change is: ");
          Console.WriteLine("\t{0:f0} dollars",register.GiveDollars());
          Console.WriteLine("\t{0:f0} quarters",register.GiveQuarters());
          Console.WriteLine("\t{0:f0} dimes",register.GiveDimes());
          Console.WriteLine("\t{0:f0} nickels",register.GiveNickels());
          Console.WriteLine("\t{0:f0} pennies", register.GivePennies());
       }
    }
}
