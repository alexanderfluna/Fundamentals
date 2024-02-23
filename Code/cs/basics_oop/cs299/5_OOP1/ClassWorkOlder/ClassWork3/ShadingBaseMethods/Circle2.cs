// Fig. 10.6: Circle2.cs
// Circle2 inherits from class Point2 and overrides key members.
using System;

namespace AbstractShapes
{
   // Circle2 inherits from class Point2
   public class Circle2 : Point2
   {
      private double radius; // Circle2 radius

      // default constructor
      public Circle2()
      {
         // implicit call to Point2 constructor occurs here
      }

      // constructor
      public Circle2( int xValue, int yValue, double radiusValue )
         : base( xValue, yValue )
      {
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
            // ensure non-negative radius value
            if ( value >= 0 )
               radius = value;
         }
      }

      // calculate Circle2 diameter
      public double Diameter()
      {
         return Radius * 2;
      }

      // calculate Circle2 circumference
      public double Circumference()
      {
         return Math.PI * Diameter();
      }

      // calculate Circle2 area
      public override double Area()
      {
         return Math.PI * Math.Pow( Radius, 2 );
      }

      // return string representation of Circle2 object
      public override string ToString()
      {
         return "Center = " + base.ToString() +
            "; Radius = " + Radius;
      }

      // override property Name from class Point2
      public override string Name
      {
         get
         {
            return "Circle2";
         }
      }

   } // end class Circle2
}
