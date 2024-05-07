// ListSortTester.cs - Four different activations of the List.Sort method.

using System;
using System.Collections.Generic;

class ListSortTester{

  public static void Main(){

     List<int> listOriginal = new List<int>(new int[]{5, 3, 2, 7, -4, 0}),
               list;

     // Sorting by means of the default comparer of int:
     list = new List<int>(listOriginal);
     ReportList(list);
     list.Sort();
     ReportList(list);
     Console.WriteLine();

     // Equivalent - explicit notatation of the Comparer:
     list = new List<int>(listOriginal);
     ReportList(list);
     list.Sort(Comparer<int>.Default);
     ReportList(list);
     Console.WriteLine();

     // Equivalent - explicit instantiation of an IntComparer:
     list = new List<int>(listOriginal);
     ReportList(list);
     list.Sort(new IntComparer());
     ReportList(list);
     Console.WriteLine();

     // Similar - use of a delegate value for comparison:
     list = new List<int>(listOriginal);
     ReportList(list);
     list.Sort(delegate(int x, int y){
                 if (x < y)
                    return -1;
                 else if (x == y)
                    return 0;
                 else return 1;});
     ReportList(list);
     Console.WriteLine();
  }

  public static void ReportList<T>(List<T> list){
    foreach(T el in list)
      Console.Write("{0, 3}", el);
    Console.WriteLine();
  }

}

public class IntComparer: Comparer<int>{
  public override int Compare(int x, int y){
    if (x < y)
      return -1;
    else if (x == y)
      return 0;
    else return 1;
  }
}
