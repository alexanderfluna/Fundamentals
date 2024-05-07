using System;

public class Card
{
	public enum CardSuite { Spade, Heart, Club, Diamond};
	public enum CardValue 
	{
		Ace = 1, Two = 2, Three = 3, Four = 4, Five = 5, 
		Six = 6, Seven = 7, Eight = 8, Nine = 9,
		Ten = 10, Jack = 11, Queen = 12, King = 13,
	};

	private CardSuite suite;
	private CardValue value;

	public static Card[] allSpades = new Card[14];
	public static Card[] allHearts = new Card[14];
	public static Card[] allClubs = new Card[14];
	public static Card[] allDiamonds = new Card[14];

	static Card()
	{
		foreach(CardValue cv in Enum.GetValues(typeof(CardValue)))
		{
			allSpades[(int)cv] = new Card(CardSuite.Spade, cv);
			allHearts[(int)cv] = new Card(CardSuite.Heart, cv);
			allClubs[(int)cv] = new Card(CardSuite.Club, cv);
			allDiamonds[(int)cv] = new Card(CardSuite.Diamond, cv);
		}
	}   

	public Card(CardSuite suite, CardValue value)
	{
		this.suite = suite;
		this.value = value;
	}

	public CardSuite Suite
	{
		get { return this.suite; }
	}

	public CardValue Value
	{
		get { return this.value; }
	}

	public override String ToString()
	{
		return String.Format("Suite:{0}, Value:{1}", suite, value);
	}
}



