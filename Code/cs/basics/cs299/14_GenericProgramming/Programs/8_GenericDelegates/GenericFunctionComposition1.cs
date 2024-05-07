// GenericFunctionComposition1.cs - Generic reprogramming of 
// the program that composes functions.

using System;

namespace ConsoleApplication1
{
	public class CompositionDemo {

  // A function from S to T
  public delegate T Function <S,T>(S d);

  // The generic function for function composition
  // g: T -> U
  // f: U -> S
  // f o g: T -> S
  public static Function<T,S> Compose<S,T,U>
                   (Function<U,S> f, Function<T,U> g){
    return delegate(T d){return f(g(d));};
  }   

  // A generic PrintTable function
  // f: S -> T
  public static void PrintTableOfFunction<S,T>
                   (Function<S,T> f, string fname, 
                    S[] inputValues){
    foreach(S s in inputValues)
      Console.WriteLine("{0,35}({1,-4:F3}) = {2}", fname, s, f(s));

    Console.WriteLine();
  }   

  public static double Square(double d){
    return d*d;
  }

  public static double Cubic(double d){
    return d*d*d;
  }

  public static double Minus3(double d){
    return d-3;
  }

  public static void Main(){
    PrintTableOfFunction(Compose<double,double,double>(Cubic, Minus3) , 
                         "Cubic of Minus3", 
                         new double[]{0.0, 0.5, 1.0, 1.5, 2.0});

    PrintTableOfFunction(
      Compose<double,double,double>(
            Square, 
            delegate(double d){
              return d > 2 ? -d : 0;}) ,
            "Square of if d>2 then -d else 0", 
            new double[]{0.0, 0.5, 1.0, 1.5, 2.0, 2.5, 3.0});
   }

}

}
