using System;

class Client{

  public static void Main(){
    Card cs = 
       new Card(Card.CardSuite.spades, Card.CardValue.queen);

    // Use of Value from Card
    Console.WriteLine(cs.Value);
    
  }
}
