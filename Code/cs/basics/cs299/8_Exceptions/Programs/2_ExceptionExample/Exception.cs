//Exception.cs - A C# program with an exception. 


using System;

class ExceptionDemo{

  public static void Main(){
    int[] table = new int[6]{10,11,12,13,14,15};
    int idx = 6;

    M(table, idx);
  }

  public static void M(int[] table, int idx){
    Console.WriteLine("Accessing element {0}: {1}", 
                       idx, table[idx]);
  }

}

