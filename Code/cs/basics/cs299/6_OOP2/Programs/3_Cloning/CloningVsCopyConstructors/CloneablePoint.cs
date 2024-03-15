using System;
using System.Drawing;

public class Point: ICloneable {
  protected double x, y;

  public Point(double x, double y){
   this.x = x; this.y = y;
  }

  // Copy constructor
  public Point(Point p){
   this.x = p.x; this.y = p.y;
  }

  public virtual double X {
    get {return x;}
    set {x = value;}
  }

  public virtual double Y {
    get {return y;}
    set {y = value;}
  }

  public virtual Point move(double dx, double dy){
    Point result = (Point)MemberwiseClone();  // cloning from within Point is OK.
    result.x = x + dx;
    result.y = y + dy;   
    return result;
  }

  // public Clone method that delegates the work of
  // the protected method MemberwiseClone();       
  public Object Clone(){
    return MemberwiseClone();
  }

  public override string ToString(){
    return "Point: " + "(" + x + "," + y + ")" + ".";
  }
}   