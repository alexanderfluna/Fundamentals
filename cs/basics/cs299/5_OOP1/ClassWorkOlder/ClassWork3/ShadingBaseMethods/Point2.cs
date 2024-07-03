// Fig. 10.5: Point2.cs
// Point2 inherits from abstract class Shape and represents
// an x-y coordinate pair.
using System;

namespace AbstractShapes
{
   // Point2 inherits from abstract class Shape
   public class Point2 : Shape
   {
      private int x, y; // Point2 coordinates

      // default constructor
      public Point2()
      {
         // implicit call to Object constructor occurs here
      }

      // constructor
      public Point2( int xValue, int yValue )
      {
         X = xValue;
         Y = yValue;
      }

      // propertyX
      public int X
      {
         get
         {
            return x;
         }

         set
         {
            x = value; // no validation needed
         }
      }
      
      // property Y
      public int Y
      {
         get
         {
            return y;
         }

         set
         {
            y = value; // no validation needed
         }
      }

      // return string representation of Point2 object
      public override string ToString()
      {
         return "[" + X + ", " + Y + "]";
      }

      // implement abstract property Name of class Shape
      public override string Name
      {
         get
         {
            return "Point2";
         }
      }

   } // end class Point2
}
