using System;

public class Die {
  private int numberOfEyes;
  private Random randomNumberSupplier; 
  private int maxNumberOfEyes;

  public Die(){
    maxNumberOfEyes = 6;
	randomNumberSupplier = Random.Instance();
    numberOfEyes = NewTossHowManyEyes();
  } 
  
  public Die(int maxEyes){
		maxNumberOfEyes = maxEyes;
		randomNumberSupplier = Random.Instance();
		numberOfEyes = NewTossHowManyEyes();
  } 
  
  public void Toss(){
    numberOfEyes = NewTossHowManyEyes();
  }

  private int NewTossHowManyEyes (){
    return randomNumberSupplier.Next(1,maxNumberOfEyes + 1);
  }

  public int NumberOfEyes() {
    return numberOfEyes;
  }

  public override String ToString(){
    return String.Format("[{0}]", numberOfEyes);
  }
}