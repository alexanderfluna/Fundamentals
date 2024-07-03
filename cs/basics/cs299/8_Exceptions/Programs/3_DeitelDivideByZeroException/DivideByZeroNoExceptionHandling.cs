// Fig. 12.1: DivideByZeroNoExceptionHandling.cs
// An application that attempts to divide by zero.
using System;

class DivideByZeroNoExceptionHandling
{
   static void Main()
   {
      // get numerator and denominator
      Console.Write( "Please enter an integer numerator: " );
      int numerator = Convert.ToInt32( Console.ReadLine() );
      Console.Write( "Please enter an integer denominator: " );
      int denominator = Convert.ToInt32( Console.ReadLine() );

      // divide the two integers, then display the result
      int result = numerator / denominator;
      Console.WriteLine( "\nResult: {0:D} / {1:D} = {2:D}",
         numerator, denominator, result );
   } // end Main
} // end class DivideByZeroNoExceptionHandling

/**************************************************************************
 * (C) Copyright 1992-2006 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/