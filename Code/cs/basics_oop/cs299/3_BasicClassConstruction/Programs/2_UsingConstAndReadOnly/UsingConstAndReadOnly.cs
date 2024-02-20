// Fig. 8.15: UsingConstAndReadOnly.cs
// Demonstrating constant values with const and readonly.

using System;
using System.Windows.Forms;

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

   // UsingConstAndReadOnly class definition
   public class UsingConstAndReadonly
   {
      // method Main creates Constants 
      // object and displays its values
      static void Main( string[] args )
      {		   
         Random random = new Random();

         Constants constantValues = 
            new Constants( random.Next( 1, 20 ) );

         MessageBox.Show( "Radius = " + constantValues.radius + 
            "\nCircumference = " +  
            2 * Constants.PI * constantValues.radius,
            "Circumference" );

      } // end method Main

   } // end class UsingConstAndReadOnly
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
