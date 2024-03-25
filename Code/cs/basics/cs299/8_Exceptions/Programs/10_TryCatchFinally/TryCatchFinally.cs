// TryCatchFinally.cs - Illustration of try-catch-finally. 

using System;


class FinallyDemo{

  internal enum Control {Returning, Jumping, Continuing, Breaking, Throwing}

  public static void M(Control reason){
    for(int i = 1; i <= 1; i++)  // a single iteration
      try{
        Console.WriteLine("\nEnter try: {0}", reason);
        if (reason == Control.Returning) return;
        else if (reason == Control.Jumping) goto finish;
        else if (reason == Control.Continuing) continue;
        else if (reason == Control.Breaking) break;
        else if (reason == Control.Throwing) throw new Exception();
        Console.WriteLine("Inside try");        
      }
      catch(Exception){
        Console.WriteLine("Inside catch");
      }  
      finally{
        Console.WriteLine("Inside finally");
      }
    finish: return;
  }

  public static void Main(){
    for(int i = 0; i <= 5; i++)
      M((Control)i); 
  }
}
      
