//TryCatch.cs 

using System;

class ExceptionDemo{

  public static void Main(){
    int[] table = new int[6]{10,11,12,13,14,15};
    int idx = 6;

    M(table, idx);
  }

  public static void M(int[] table, int idx){
    try{
      Console.WriteLine("Accessing element {0}: {1}", 
                         idx, table[idx]);
    } 
    catch (IndexOutOfRangeException e){
      int newIdx = AdjustIndex(idx,0,5);
      Console.WriteLine("We get element number {0}: {1}", 
                         newIdx, table[newIdx]);            
    }   
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

