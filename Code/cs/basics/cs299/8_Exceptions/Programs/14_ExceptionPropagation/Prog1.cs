// Prog1.cs - A C# program with simple propagation of exception handling.


using System;

class ExceptionDemo{

  public static void Main(){
    int[] table = new int[6]{10,11,12,13,14,15};
    int idx = 6;

    try{
      M(table, idx);
    }   
    catch (IndexOutOfRangeException e){
      int newIdx = AdjustIndex(idx,0,5);
      Console.WriteLine("We get element number {0}: {1}", 
                         newIdx, table[newIdx]);            
    }
    Console.WriteLine("End of Main"); 
  }

  public static void M(int[] table, int idx){
    try{
      Console.WriteLine("Accessing element {0}: {1}", 
                         idx, table[idx]);
    }   
    catch (NullReferenceException e){
      Console.WriteLine("A null reference exception");
      throw;      // rethrowing the exception
    }   
    catch (DivideByZeroException e){
      Console.WriteLine("Dividing by zero");
      throw;     // rethrowing the exception
    }

    Console.WriteLine("End of M"); 
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

