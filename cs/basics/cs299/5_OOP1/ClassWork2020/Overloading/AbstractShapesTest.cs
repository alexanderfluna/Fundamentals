// Fig. 10.8: AbstractShapesTest.cs
// Demonstrates polymorphism in Point-Circle-Cylinder hierarchy.
using System;
//using System.Windows.Forms;

namespace AbstractShapes
{
   public class AbstractShapesTest
   {
        public static void Main(string[] args)
        {
            // instantiate Point2, Circle2 and Cylinder2 objects
            Point2 point = new Point2(7, 11);
            Circle2 circle = new Circle2(22, 8, 3.5);
            Cylinder2 cylinder = new Cylinder2(10, 10, 3.3, 10);

            // create empty array of Shape base-class references
            Shape[] arrayOfShapes = new Shape[3];

            // arrayOfShapes[ 0 ] refers to Point2 object
            arrayOfShapes[0] = point;

            // arrayOfShapes[ 1 ] refers to Circle2 object
            arrayOfShapes[1] = circle;

            // arrayOfShapes[ 1 ] refers to Cylinder2 object
            arrayOfShapes[2] = cylinder;

            Console.WriteLine(point.Name + ": " + point + "\n" +
               circle.Name + ": " + circle + "\n" +
               cylinder.Name + ": " + cylinder);

         // display Name, Area and Volume for each object
         // in arrayOfShapes polymorphically
         foreach( Shape shape in arrayOfShapes )
         {
                Console.WriteLine(shape.Name + ": " + shape +
               "\nArea = " + shape.Area().ToString( "F" ) + 
               "\nVolume = " + shape.Volume().ToString( "F" )+ "\n");
                if (shape is Circle2 || shape is Cylinder2)
                    Console.WriteLine("Circumference: " + 
                        ((Circle2)shape).Circumference()+ "\n");
         }
            Console.WriteLine("Using overloaded ToString ");
            Console.WriteLine(circle.ToString("0:f"));

        }
   }
}
