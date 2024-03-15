// Fig. 9.10: Circle3.cs
// Circle2 class that inherits from class Point2.

using System;

namespace CircleTest3
{
   // Circle3 class definition inherits from Point2
   public class Circle3 : Point2
   {
      private double radius;  // Circle's radius

      // default constructor
      public Circle3()
      {
         // implicit call to Point constructor occurs here
      }

      // constructor
      public Circle3( 
         int xValue, int yValue, double radiusValue )
      {
         // implicit call to Point constructor occurs here
         x = xValue;
         y = yValue;
         Radius = radiusValue;
      }

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

      // calculate circumference
      public double Circumference()
      {
         return Math.PI * Diameter();
      }

      // calculate Circle area
      public virtual double Area()
      {
         return Math.PI * Math.Pow( radius, 2 );
      }

      // return string representation of Circle3
      public override string ToString()
      {
         return "Center = [" + x + ", " + y + "]" +
            "; Radius = " + radius;
      }

   } // end class Circle3
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