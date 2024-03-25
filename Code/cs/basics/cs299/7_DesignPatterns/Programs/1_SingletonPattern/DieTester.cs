using System;

class diceApp {

  public static void Main(){

//  Die d1 = new Die();   //  Compile-time error:
                          //  The type 'Die' has no constructors defined

    Die d2 = Die.Instance(6),
        d3 = Die.Instance(6);

    for(int i = 1; i < 5; i++){
      Console.WriteLine(d2); 
      d2.Toss(); 
    }

    for(int i = 5; i < 10; i++){
      Console.WriteLine(d2); 
      d3.Toss(); 
    }

    // Test for singleton:
    if (d2 == d3)
      Console.WriteLine("d2 and d3 refer to same die instance");
    else
      Console.WriteLine("d2 and d3 do NOT refer to same die instance");
 }

}

         