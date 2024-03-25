using System;

class diceApp {

  public static void Main(){

    Die d1 = new Die(),
        d2 = new Die();

    for(int i = 1; i < 10; i++){
      Console.WriteLine("Die 1: {0}", d1);  
      Console.WriteLine("Die 2: {0}", d2);  
      d1.Toss();  d2.Toss(); 
    }

 }
}