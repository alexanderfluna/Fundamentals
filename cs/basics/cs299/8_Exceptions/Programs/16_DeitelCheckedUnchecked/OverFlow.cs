// Fig 11.6: Overflow.cs
// Demonstrating operators checked and unchecked.

using System;

// demonstrates using the checked and unchecked operators
class Overflow
{
   static void Main( string[] args )
   {
      int number1 = Int32.MaxValue;  // 2,147,483,647
      int number2 = Int32.MaxValue;  // 2,147,483,647
      int sum = 0; 

      Console.WriteLine( 
         "number1: {0}\nnumber2: {1}", number1, number2 );

      // calculate sum of number1 and number2
      try
      {
         Console.WriteLine( 
            "\nSum integers in checked context:" );

         sum = checked( number1 + number2 );
      }

         // catch overflow exception
      catch ( OverflowException overflowException )
      {
         Console.WriteLine( overflowException.ToString() );
      }

      Console.WriteLine( 
         "\nsum after checked operation: {0}", sum );

      Console.WriteLine( 
         "\nSum integers in unchecked context:" );

      sum = unchecked( number1 + number2 );

      Console.WriteLine( 
         "sum after unchecked operation: {0}", sum );

   } // end method Main

} // end class Overflow

/*
 ************************************************************************** 
 * (C) Copyright 2002 by Deitel & Associates, Inc. and Prentice Hall.     *
 * All Rights Reserved.                                                   *
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
 **************************************************************************
*/
