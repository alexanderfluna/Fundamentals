// Prog2.cs - A C# program with deeper exception propagation chain. 

using System;

class ExceptionDemo{

  public static void Main(){
    int[] table = new int[6]{10,11,12,13,14,15};
    int idx = 6;

    Console.WriteLine("Main, will call M");
    try{
      M(table, idx);
    }   
    catch (IndexOutOfRangeException e){
	  Console.WriteLine("Exception was thrown - catch calls M");
      M(table, AdjustIndex(idx,0,5));
    }
  }

  public static void M(int[] table, int idx){
    Console.WriteLine("M(table,{0}, will call N)", idx);
    N(table,idx);
  }

  public static void N(int[] table, int idx){
    Console.WriteLine("N(table,{0}, will call P)", idx);
    P(table,idx);
  }

  public static void P(int[] table, int idx){
    Console.WriteLine("P(table,{0} - throws exception for index 6 but not for index 5)", idx);
    Console.WriteLine("Accessing element {0}: {1}", 
                       idx, table[idx]);
  }



  public static int AdjustIndex(int i, int low, int high){
    int res;
    if (i < low)
      res = low;
    else if (i > high)
      res = high;
    else res = i;

    return res;
  }
}

