// Fig. 9.6: Circle.cs
// Circle class contains x-y coordinate pair and radius.

using System;

namespace CircleTest
{
   // Circle class definition implicitly inherits from Object
   public class Circle
   {
      private int x, y;      // coordinate of Circle's center
      private double radius; // circle's radius

      // default constructor
      public Circle()
      {
         // implicit call to Object constructor occurs here
      }

      // constructor
      public Circle( int xValue, int yValue, double radiusValue )
      {
         // implicit call to Object constructor occurs here
         x = xValue;
         y = yValue;
         Radius = radiusValue;
      }

      // property X
      public int X
      {
         get
         {
            return x;
         }

         set
         {
            x = value;  // no need for validation
         }

      } // end property X

      // property Y
      public int Y
      {
         get
         {
            return y;
         }

         set
         {
            y = value;  // no need for validation
         }

      } // end property Y

      // property Radius
      public double Radius
      {
         get
         {
            return radius;
         }

         set
         {
            if ( value >= 0 )   // needs validation
               radius = value;
         }

      } // end property Radius

      // calculate Circle diameter
      public double Diameter()
      {
         return radius * 2;
      }

      // calculate Circle circumference
      public double Circumference()
      {
         return Math.PI * Diameter();
      }

      // calculate Circle area
      public double Area()
      {
         return Math.PI * Math.Pow( radius, 2 );
      }

      // return string representation of Circle
      public override string ToString()
      {
         return "Center = [" + x + ", " + y + "]" +
            "; Radius = " + radius;
      }

   } // end class Circle
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