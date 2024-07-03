using System;
using System.Collections;

public struct Interval: IEnumerable{

  private readonly int from, to;

  public Interval(int from, int to){
    this.from = from;
    this.to = to;
  }

  public int From{
    get {return from;}
  }

  public int To{
    get {return to;}
  }

  public int Length{
    get {return Math.Abs(to - from) + 1;}
  }

  public int this[int i]{
    get {if (from <= to){
           if (i >= 0 && i <= Math.Abs(from-to))
               return from + i;
           else throw new Exception("Error"); }
         else if (from > to){
           if (i >= 0 && i <= Math.Abs(from-to))
               return from - i;
           else throw new Exception("Error"); }
         else throw new Exception("Should not happen"); }
  }


  public static Interval operator +(Interval i, int j){
    return new Interval(i.From + j, i.To + j);
  }

  public static Interval operator +(int j, Interval i){
    return new Interval(i.From + j, i.To + j);
  }

  public static Interval operator >>(Interval i, int j){
    return new Interval(i.From, i.To + j);
  }

  public static Interval operator <<(Interval i, int j){
    return new Interval(i.From + j, i.To);
  }

  public static Interval operator *(Interval i, int j){
    return new Interval(i.From * j, i.To * j);
  }

  public static Interval operator *(int j, Interval i){
    return new Interval(i.From * j, i.To * j);
  }

  public static Interval operator -(Interval i, int j){
    return new Interval(i.From - j, i.To - j);
  }

  public static Interval operator !(Interval i){
    return new Interval(i.To, i.From);
  }    

  public static explicit operator int[] (Interval i){
    int[] res = new int[i.Length];
    for (int j = 0; j < i.Length; j++) res[j] = i[j];
    return res; 
  }

  private class IntervalEnumerator: IEnumerator{
 
    private readonly Interval interval; 
    private int idx;

    public IntervalEnumerator (Interval i){
      this.interval = i;
      idx = -1;   // position enumerator outside range
    }
 
    public Object Current{ 
         get {return (interval.From < interval.To) ? 
                       interval.From + idx :
                       interval.From - idx;}
    }

    public bool MoveNext (){
      if ( idx < Math.Abs(interval.To - interval.From))
         {idx++; return true;}
      else
         {return false;}
    }

    public void Reset(){
      idx = -1;         
    }
  }    
    
  public IEnumerator GetEnumerator (){
    return new IntervalEnumerator(this);
  }

}