public enum Color : byte {Blue, Red}
public class ColorPoint: Point{
  protected Color color;

  public ColorPoint(double x, double y, Color c):
      base(x,y){
    this.color = c;
  }

  // Copy constructor
  public ColorPoint(ColorPoint cp):
      base(cp.x,cp.y){
    this.color = cp.color;
  }

  // Clone method is inherited

  public override string ToString(){
    return "ColorPoint: " + "(" + x + "," + y + ")" + ":" + color;
  }
}
  