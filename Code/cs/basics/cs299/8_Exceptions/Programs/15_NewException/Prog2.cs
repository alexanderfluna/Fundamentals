//Prog2.cs - Raising and throwing a new exception, propagating original inner exception. 


using System;

class ExceptionDemo{

  public static void Main(){
    int[] table = new int[6]{10,11,12,13,14,15};
    int idx = 6;
    M(table, idx);
  }

  public static void M(int[] table, int idx){
    Console.WriteLine("M(table,{0})", idx);
    N(table,idx);
  }

  public static void N(int[] table, int idx){
    Console.WriteLine("N(table,{0})", idx);
    try{
      P(table,idx);
    }
    catch (IndexOutOfRangeException e){
      // Will not/cannot handle exception here. 
      // Raise new exception with propagation of inner exception.
      throw new IndexOutOfRangeException("Index out of range",  e);
    }
  }

  public static void P(int[] table, int idx){
    Console.WriteLine("P(table,{0})", idx);
    Console.WriteLine("Accessing element {0}: {1}", 
                       idx, table[idx]);
  }
}

