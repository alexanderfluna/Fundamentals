// Rethrow.cs - Rethrowing an exception. 


using System;

class ExceptionDemo{

  public static void Main(){
    Console.WriteLine("Main");
    int[] table = new int[6]{10,11,12,13,14,15};
    int index = 6;
    M(table, index);
  }

  public static void M(int[] table, int index){
    Console.WriteLine("M(table,{0})", index);
    N(table,index);
  }

  public static void N(int[] table, int index){
    Console.WriteLine("N(table,{0})", index);
    try{
      P(table,index);
    }
    catch (IndexOutOfRangeException e){
      // Will not/cannot handle exception here. 
      // Rethrow original exception.
      throw;
    }
  }

  public static void P(int[] table, int index){
    Console.WriteLine("P(table,{0})", index);
    Console.WriteLine("Accessing element {0}: {1}", 
                       index, table[index]);
  }
}
