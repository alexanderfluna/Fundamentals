// Alexander Luna | Test 2 | Test.cs
using System;

namespace ConsoleApplication1
{
    public class Test
    {
        public static void Main()
        {
            // Make an array of Point objects using the supplied class Point
            Point[] points = {
                new Point(0, 0),
                new Point(1, 2),
                new Point(2, -2),
                new Point(-3, 1),
                new Point(4, -4)
            };

            // Define a delegate predicate to check if the sum of x and y is zero using lambda expression
            Predicate<Point> sumIsZero = point => point.X + point.Y == 0;

            // Find the first point where the sum of x and y is zero
            Point firstPoint = Array.Find(points, sumIsZero);
            if (firstPoint != null)
            {
                Console.WriteLine($"The first point where the sum of x and y is zero: \n{firstPoint}");
            }
            else
            {
                Console.WriteLine("No point found where the sum of x and y is zero.");
            }

            // Find all points where the sum of x and y is zero
            Point[] pointsWithSumZero = Array.FindAll(points, sumIsZero);
            if (pointsWithSumZero.Length > 0)
            {
                Console.WriteLine("\nAll points where the sum of x and y is zero:");
                foreach (Point point in pointsWithSumZero)
                {
                    Console.WriteLine(point);
                }
            }
            else
            {
                Console.WriteLine("No points found where the sum of x and y is zero.");
            }
        }
    }
}
