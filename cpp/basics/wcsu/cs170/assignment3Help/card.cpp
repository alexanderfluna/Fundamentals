// This is the implementation file for a playing card data type and
// routines to work with that type.
//

#include "card.h"

// The overloaded << function for output.
ostream& operator<< (ostream& out, card name)
{
	switch (name)
	{
	case AceClubs:      out << "Ace of Clubs";      break;
	case TwoClubs:      out << "Two of Clubs";      break;
	case ThreeClubs:    out << "Three of Clubs";    break;
	case FourClubs:     out << "Four of Clubs";     break;
	case FiveClubs:     out << "Five of Clubs";     break;
	case SixClubs:      out << "Six of Clubs";      break;
	case SevenClubs:    out << "Seven of Clubs";    break;
	case EightClubs:    out << "Eight of Clubs";    break;
	case NineClubs:     out << "Nine of Clubs";     break;
	case TenClubs:      out << "Ten of Clubs";      break;
	case JackClubs:     out << "Jack of Clubs";     break;
	case QueenClubs:    out << "Queen of Clubs";    break;
	case KingClubs:     out << "King of Clubs";     break;
	case AceDiamonds:   out << "Ace of Diamonds";   break;
	case TwoDiamonds:   out << "Two of Diamonds";   break;
	case ThreeDiamonds: out << "Three of Diamonds"; break;
	case FourDiamonds:  out << "Four of Diamonds";  break;
	case FiveDiamonds:  out << "Five of Diamonds";  break;
	case SixDiamonds:   out << "Six of Diamonds";   break;
	case SevenDiamonds: out << "Seven of Diamonds"; break;
	case EightDiamonds: out << "Eight of Diamonds"; break;
	case NineDiamonds:  out << "Nine of Diamonds";  break;
	case TenDiamonds:   out << "Ten of Diamonds";   break;
	case JackDiamonds:  out << "Jack of Diamonds";  break;
	case QueenDiamonds: out << "Queen of Diamonds"; break;
	case KingDiamonds:  out << "King of Diamonds";  break;
	case AceHearts:     out << "Ace of Hearts";     break;
	case TwoHearts:     out << "Two of Hearts";     break;
	case ThreeHearts:   out << "Three of Hearts";   break;
	case FourHearts:    out << "Four of Hearts";    break;
	case FiveHearts:    out << "Five of Hearts";    break;
	case SixHearts:     out << "Six of Hearts";     break;
	case SevenHearts:   out << "Seven of Hearts";   break;
	case EightHearts:   out << "Eight of Hearts";   break;
	case NineHearts:    out << "Nine of Hearts";    break;
	case TenHearts:     out << "Ten of Hearts";     break;
	case JackHearts:    out << "Jack of Hearts";    break;
	case QueenHearts:   out << "Queen of Hearts";   break;
	case KingHearts:    out << "King of Hearts";    break;
	case AceSpades:     out << "Ace of Spades";     break;
	case TwoSpades:     out << "Two of Spades";     break;
	case ThreeSpades:   out << "Three of Spades";   break;
	case FourSpades:    out << "Four of Spades";    break;
	case FiveSpades:    out << "Five of Spades";    break;
	case SixSpades:     out << "Six of Spades";     break;
	case SevenSpades:   out << "Seven of Spades";   break;
	case EightSpades:   out << "Eight of Spades";   break;
	case NineSpades:    out << "Nine of Spades";    break;
	case TenSpades:     out << "Ten of Spades";     break;
	case JackSpades:    out << "Jack of Spades";    break;
	case QueenSpades:   out << "Queen of Spades";   break;
	case KingSpades:    out << "King of Spades";    break;
	}
	return out;
}

// The overloaded prefix increment operation.
card operator++ (card& name)
{
	name = (card) ((int) name + 1);
	return name;
}

// The overloaded postfix increment operation.
card operator++ (card& name, int)
{
	card temp = name;

	name = (card) ((int) name + 1);
	return temp;
}
