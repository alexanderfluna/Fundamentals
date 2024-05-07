// ListFindTester.cs - Sample uses of List.Find

using System;
using System.Collections.Generic;

class ListFindTester{

  public static void Main(){

     System.Threading.Thread.CurrentThread.CurrentCulture = 
        new System.Globalization.CultureInfo("en-US");

     List<Point> pointLst = new List<Point>();

     // Construct points and point list:
     pointLst.Add(new Point(0,0)); pointLst.Add(new Point(5, 9)); 
     pointLst.Add(new Point(5,4)); pointLst.Add(new Point(7.1,-13)); 
     pointLst.Add(new Point(5,-2)); pointLst.Add(new Point(14,-3.4)); 
     ReportList("Initial point list", pointLst);

     // Find first point in list with x coordinate 5
     Point p = pointLst.Find(delegate(Point q){return (q.Getx() == 5);});
     Console.WriteLine("Found with delegate predicate: {0}\n", p);

     // Equivalent. Use predicate which is a static method 
     p = pointLst.Find(new Predicate<Point>(FindX5));
     Console.WriteLine("Found with static member predicate: {0}\n", p);

     // Find all points in list with x coordinate 5
     List<Point> resLst = new List<Point>();
     resLst = pointLst.FindAll(delegate(Point q){return (q.Getx() == 5);});
     ReportList("All points with x coordinate 5", resLst);

     // Find index of a given point in pointLst.
     // Notice that Point happens to be a struct - thus value comparison
     Point searchPoint = new Point(5,4);
     Console.WriteLine("Index of {0} {1}", searchPoint, 
                        pointLst.IndexOf(searchPoint));

  }

  public static bool FindX5(Point p){
    return p.Getx() == 5;
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

