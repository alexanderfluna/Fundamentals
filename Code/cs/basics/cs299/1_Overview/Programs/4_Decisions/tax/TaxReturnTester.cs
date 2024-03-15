using System;

namespace ConsoleApplication1
{
   ///<summary>
   /// A class to test the TaxReturn class.
   ///</summary>
    public class TaxReturnTester    {
        public static void Main()   {      

          Console.Write("Please enter your income: ");
          string temp = Console.ReadLine();
          double income = double.Parse(temp);

          Console.Write("Please enter S (single) or M (married): ");
          string input = Console.ReadLine();
          int status = 0;

          if (input.ToUpper()=="S") 
             status = TaxReturn.SINGLE;
          else if (input.ToUpper() == "M") 
             status = TaxReturn.MARRIED;
          else 
          {
              Console.WriteLine("Bad input.");
             return;
          }      

          TaxReturn aTaxReturn = new TaxReturn(income, status);
          Console.WriteLine("The tax is {0:c}", aTaxReturn.GetTax());
       }
        }

}
