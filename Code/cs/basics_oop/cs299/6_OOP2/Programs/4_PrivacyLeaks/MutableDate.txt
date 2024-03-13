// A mutable Date
public class Date{
  private ushort year;
  private byte month, day;

  public Date(ushort year, byte month, byte day){
    this.year = year; this.month = month; this.day = day;
  }

  public void SetYear(ushort year){
    this.year = year;
  }

  public ushort GetYear(){
    return year;
  }

  // Similar month and day setters and getter methods

  public override string ToString(){
    return string.Format("{0}.{1}.{2}",day, month, year);
  }
}

