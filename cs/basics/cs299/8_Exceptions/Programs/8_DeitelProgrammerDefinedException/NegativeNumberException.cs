// Fig 11.4: NegativeNumberException.cs
// NegativeNumberException represents exceptions caused by
// illegal operations performed on negative numbers.
using System;

namespace NegativeNumberSquareRoot
{
   /// <summary>
   /// NegativeNumberException represents exceptions caused by
   /// illegal operations performed on negative numbers
   /// </summary>
   class NegativeNumberException : ApplicationException
   {
      // default constructor
      public NegativeNumberException()
         : base( "Illegal operation for a negative number" )
      {
      }

      // constructor for customizing error message
      public NegativeNumberException( string message )
         : base( message )
      {
      }

      // constructor for customizing error message and 
      // specifying inner exception object
      public NegativeNumberException( 
         string message, Exception inner ) 
         : base( message, inner )
      {
      }

   } // end class NegativeNumberException
}

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
