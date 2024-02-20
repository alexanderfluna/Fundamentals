using System;
using ElapsedTime;

namespace StructApp1 {

	public class PointTester {
	   
	   public static void Main() {
		  //PointApplication app = new PointApplication();
		  Point pt1 = new Point(4, 5);
		  PointClass pt2 = new PointClass(4, 5);
		  Timing timer = new Timing();
		  timer.StartTiming();
		  for (int i = 0; i < 100000000; i++) 
		  {
			  Point result = PointApplication.Twice(pt1);
		  }
		  timer.EndTiming();
		  Console.WriteLine("Time for value type point: " + timer.ElapsedTime());

		  timer = new Timing();
		  timer.StartTiming();
		  for (int i = 0; i < 100000000; i++) 
		  {
			  PointClass result = PointApplication.Twice(pt2);
		  }
		  timer.EndTiming();
		  Console.WriteLine("Time for reference type point: " + timer.ElapsedTime());


		  Point pt1Copy = pt1;
		  PointClass pt2Copy = pt2;
		  Console.WriteLine("Before copying - pt1Copy: " + pt1Copy.ToString());
		  Console.WriteLine("Before copying - pt2Copy: " + pt2Copy.ToString());

		  // Change pt1
		  pt1.X = 50;
		  pt1.Y = 60;
		  // Change pt2
		  pt2.X = 50;
		  pt2.Y = 60;
		  // Output the two point copies again
		  Console.WriteLine("After copying - pt1Copy: " + pt1Copy.ToString());
		  Console.WriteLine("After copying - pt2Copy: " + pt2Copy.ToString());
	  }
	}
}
/* Program output
Time for value type point: 4.953125
Time for reference type point: 3.484375
*/
