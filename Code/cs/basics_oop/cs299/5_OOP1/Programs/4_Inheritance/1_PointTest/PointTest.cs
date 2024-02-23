// Fig. 9.5: PointTest.cs
// Testing class Point.

using System;
using System.Windows.Forms;

namespace PointTest
{
   // PointTest class definition
   class PointTest
   {
      // main entry point for application
      static void Main( string[] args )
      {
         // instantiate Point object
         Point point = new Point( 72, 115 );

         // display point coordinates via X and Y properties
         string output = "X coordinate is " + point.X +
            "\n" + "Y coordinate is " + point.Y;

         point.X = 10; // set x-coordinate via X property
         point.Y = 10; // set y-coordinate via Y property

         // display new point value
         output += "\n\nThe new location of point is " + point;

         MessageBox.Show( output, "Demonstrating Class Point" );

      } // end method Main

   } // end class PointTest
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