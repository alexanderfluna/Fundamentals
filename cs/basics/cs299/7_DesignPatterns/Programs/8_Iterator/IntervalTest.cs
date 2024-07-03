using System;

public class app {

  public static void Main(){

    Interval iv1 = new Interval(17,14),
             iv2 = new Interval(2,5),
             iv3;

    foreach(int k in !(3 + iv1 - 2)){
      Console.Write("{0,4}", k);
    }
    Console.WriteLine();

    foreach(int k in !(3 + !iv2 * 2)){
      Console.Write("{0,4}", k);
    }
    Console.WriteLine();

    iv3 = !(3 + !iv2 * 3) >> 2 ;
    Console.WriteLine("First and last in iv3: {0}, {1}", 
                       iv3[0], iv3[iv3.Length-1]);
    Console.WriteLine();

    int[] arr = (int[])iv3;
    foreach(int j in arr){
      Console.Write("{0,4}", j);
    }
	Console.WriteLine();

  }

}