using System;
using System.Drawing;
using System.Collections;

public class Application{

  public static void Main(){
    Point p1 =       new Point(1.1, 2.2),
          p2 =       new Point(3.3, 4.4);

    ColorPoint cp1 = new ColorPoint(5.5, 6.6, Color.Red),
               cp2 = new ColorPoint(7.7, 8.8, Color.Blue);

    ArrayList pointList = new ArrayList(),
                clonedPointList = new ArrayList();

    pointList.Add(p1);
    pointList.Add(cp1);
    pointList.Add(p2);
    pointList.Add(cp2);

//  Cannot copy ColorPoint objects with copy constructor of Point.
//  foreach(Point p in pointList){
//    clonedPointList.Add(new Point(p));
//  }

    // Explicit type dispatch:
    foreach(Point p in pointList){
      if (p is ColorPoint)
        clonedPointList.Add(new ColorPoint((ColorPoint)p));  
      else if (p is Point)
        clonedPointList.Add(new Point(p));
    }

    foreach(Point p in clonedPointList)
      Console.WriteLine("{0}", p);

  }
}