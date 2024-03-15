using System;

public class Card: IGameObject{
  public enum CardSuite { spades, hearts, clubs, diamonds };
  public enum CardValue { two = 2, three = 3, four = 4, five = 5, 
                          six = 6, seven = 7, eight = 8, nine = 9,
                          ten = 10, jack = 11, queen = 12, king = 13,
                          ace = 14 };

  private CardSuite suite;
  private CardValue value; 

  public Card(CardSuite suite, CardValue value){
    this.suite = suite;
    this.value = value;
  }

  public CardSuite Suite{
    get { return this.suite; }
  }

  //name conflicts with interface property
  public CardValue Value
  {  
    get { return this.value; }
  }

  public override String ToString(){
    return String.Format("Suite:{0}, Value:{1}", suite, value);
  }

  //defining the interface property - not own property
  int IGameObject.Value{
    get { return (int)(this.value); }
  }

  // Implementing the interface Medium property
  // GameObjectMedium is enumeration defined in 
  // ConflictingInterface.cs
  public GameObjectMedium Medium{
    get{
      return GameObjectMedium.Paper;
    }
  }
}

