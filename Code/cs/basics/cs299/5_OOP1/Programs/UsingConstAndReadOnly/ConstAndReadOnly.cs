// Fig. 8.15: UsingConstAndReadOnly.cs
// Demonstrating constant values with const and readonly.

using System;


namespace UsingConstAndReadonly
{
   // Constants class definition
   public class Constants : Object
   {
      // create constant PI 
      public const double PI = 3.14159;

      // radius is a constant
      // that is uninitialized
      public readonly int radius;

      public Constants( int radiusValue )
      {
         radius = radiusValue;
      }

   } // end class Constants

   
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
