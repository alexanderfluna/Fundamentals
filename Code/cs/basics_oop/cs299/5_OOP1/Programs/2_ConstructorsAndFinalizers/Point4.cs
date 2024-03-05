// Fig. 9.17: Point4.cs
// Point4 class represents an x-y coordinate pair.

using System;

namespace ConstructorsAndDestructor
{
   // Point4 class definition
   public class Point4
   {
      // point coordinate
      private int x, y;

      // default constructor
      public Point4()
      {
         // implicit call to Object constructor occurs here
         Console.WriteLine( "Point4 constructor: {0}", this );
      }

      // constructor
      public Point4( int xValue, int yValue )
      {
         // implicit call to Object constructor occurs here
         X = xValue;
         Y = yValue;
         Console.WriteLine( "Point4 constructor: {0}", this );
      }

      // destructor
      ~Point4()
      {
         Console.WriteLine( "Point4 Destructor: {0}", this );
      }

      // property X
      public int X
      {
         get // getter 
         {
            return x;
         }

         set // setter
         {
            x = value; // no need for validation
         }

      } // end property X

      // property Y 
      public int Y
      {
         get // getter
         {
            return y;
         }

         set // setter
         {
            y = value; // no need for validation
         }

      } // end property Y

      // return string representation of Point4
      public override string ToString()
      {
         return "[" + X + ", " + Y + "]";
      }

   } // end class Point4
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
