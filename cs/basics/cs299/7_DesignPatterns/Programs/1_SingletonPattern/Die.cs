using System;

public class Die {
  private int numberOfEyes;
  private Random randomNumberSupplier; 
  private int maxNumberOfEyes;

  private static Die uniqueInstance = null;

  private Die (int maxNumberOfEyes){
    randomNumberSupplier = new Random(unchecked((int)DateTime.Now.Ticks));
    this.maxNumberOfEyes = maxNumberOfEyes;
    numberOfEyes = randomNumberSupplier.Next(1,maxNumberOfEyes + 1);
  }

  public static Die Instance(int maxNumberOfEyes){
    if (uniqueInstance == null)
      uniqueInstance = new Die(maxNumberOfEyes);

    return uniqueInstance;
  } 
    
  public void Toss (){
    numberOfEyes = randomNumberSupplier.Next(1,maxNumberOfEyes + 1);
  }

  public int NumberOfEyes() {
    return numberOfEyes;
  }

  public override String ToString(){
    return String.Format("Die[{0}]: {1}", maxNumberOfEyes, numberOfEyes);
  }
}