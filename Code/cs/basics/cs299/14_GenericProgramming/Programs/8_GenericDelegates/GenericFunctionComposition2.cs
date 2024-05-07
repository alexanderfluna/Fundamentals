// GenericFunctionComposition2.cs - Generic function composition  
// program that involves other types than double..

using System;

namespace ConsoleApplication1
{
	public class CompositionDemo {

  // A function from S to T
  public delegate T Function <S,T>(S d);

  // The generic function for function composition
  // from T to S via U
  public static Function<T,S> Compose<T, U, S>
                   (Function<U,S> f, Function<T,U> g){
    return delegate(T d){return f(g(d));};
  }   

  // A generic PrintTable function
  public static void PrintTableOfFunction<S,T>
                   (Function<S,T> f, string fname, 
                    S[] inputValues){
    foreach(S s in inputValues)
      Console.WriteLine("{0,35}({1,-4:F3}) = {2}", fname, s, f(s));

    Console.WriteLine();
  }   

  // DieFromInt: int -> Die
  public static Die DieFromInt(int i){
    return new Die(i);
  }

  // Round: double -> int
  public static int Round(double d){
    return (int)(Math.Round(d));
  }

  public static void Main(){
    double[] input = new double[25];
    for(int i = 0; i < 25; i++)
      input[i] = (double) (i*2);

    // Compose(DieFromInt, Round): double -> Die 
    // (via int) 

    PrintTableOfFunction(Compose<double,int,Die>(DieFromInt, Round), 
                         "Die of double", 
                         input);
  }

}

}
