//BinarySearchNotFound.cs - Searching for a non-existing Point.

using System;
using System.Collections.Generic;

class BinarySearchDemo{

  public static void Main(){

     System.Threading.Thread.CurrentThread.CurrentCulture = 
        new System.Globalization.CultureInfo("en-US");

     List<Point> pointLst = new List<Point>();

     // Construct points and point list:
     pointLst.Add(new Point(0,0)); pointLst.Add(new Point(5, 9)); 
     pointLst.Add(new Point(5,4)); pointLst.Add(new Point(7.1,-13)); 
     pointLst.Add(new Point(5,-2)); pointLst.Add(new Point(14,-3.4)); 
     ReportList("Initial point list", pointLst);

     // Sort point list, using a specific point Comparer:
     IComparer<Point> pointComparer = new PointComparer();
     pointLst.Sort(pointComparer);
     ReportList("Sorted point list", pointLst);

     int res;
     Point searchPoint;

     searchPoint = new Point(1,1);
     res = pointLst.BinarySearch(searchPoint, pointComparer);
     Console.WriteLine("BinarySearch for {0}: {1}\n", searchPoint, res);

     if (res < 0){    // search point not found
       pointLst.Insert(~res, searchPoint);  // Insert searchPoint such
                                            // that pointLst remains sorted
       Console.WriteLine("Inserting {0} at index {1}", searchPoint, ~res);
       ReportList("Point list after insertion", pointLst);
     }
  }

  public static void ReportList<T>(string explanation,List<T> list){
    Console.WriteLine(explanation);
    int cnt = 0;
    foreach(T el in list){
      Console.Write("{0, 3}", el);
      cnt++;
      if (cnt%4 == 0) Console.WriteLine();
    }
    if (cnt%4 != 0) Console.WriteLine();
    Console.WriteLine();
  }


}

// Compare the sum of the x and y coordinates.
// Somewhat non-traditional!
public class PointComparer: Comparer<Point>{
  public override int Compare(Point p1, Point p2){
    double p1Sum = p1.Getx() + p1.Gety();
    double p2Sum = p2.Getx() + p2.Gety();
    if (p1Sum < p2Sum)
      return -1;
    else if (p1Sum == p2Sum)
      return 0;
    else return 1;
  }
}
