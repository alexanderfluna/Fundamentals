// GenericBubbleSort.cs - A generic bubble sort program

using System;

namespace ConsoleApplication1
{
	class SortDemo{

  static void BubbleSort<T>(T[] a) where T: IComparable<T>{
   int n = a.Length;
   for (int i = 0; i < n - 1; ++i)
     for (int j = n - 1; j > i; --j)
       if (a[j-1].CompareTo(a[j]) > 0)
          Swap(ref a[j-1], ref a[j]);
  }

  public static void Swap<T>(ref T a, ref T b){
    T temp;
    temp = a; a = b; b = temp;
  }

  public static void ReportArray<T>(T[] a){
    foreach(T t in a) Console.Write("{0,4}", t);
    Console.WriteLine();  
  }

  public static void Main(){
    double[] da = new double[]{5.7, 3.0, 6.9, -5,3, 0.3};

    Die[] dia = new Die[]{new Die(), new Die(),  new Die(), 
                          new Die(),  new Die(),  new Die()};

    ReportArray(da); BubbleSort(da); ReportArray(da);
    Console.WriteLine();
    ReportArray(dia); BubbleSort(dia); ReportArray(dia);
    Console.WriteLine();

    // Equivalent:
    ReportArray(da); BubbleSort<double>(da); ReportArray(da);
    Console.WriteLine();
    ReportArray(dia); BubbleSort<Die>(dia); ReportArray(dia);
  }

}

}
