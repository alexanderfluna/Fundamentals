using System;

public class Application{

  public static void Main(){
    Point p1 = new Point(1.1, 2.2),
          p2, p3;

    p2 = (Point)p1.Clone();  // First p1.Clone(), then cast to Point.
    p3 = p1.move(3.3, 4.4);
    Console.WriteLine("{0} {1} {2}", p1, p2, p3);
  }

}
