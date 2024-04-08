// This is the header file for a playing card data type and
// routines to work with that type.
//


#include <iostream>
using namespace std;

// The type identifies all 52 cards.
enum card {AceClubs, TwoClubs, ThreeClubs, FourClubs, FiveClubs,
             SixClubs, SevenClubs, EightClubs, NineClubs, TenClubs,
		     JackClubs, QueenClubs, KingClubs,
		   AceDiamonds, TwoDiamonds, ThreeDiamonds, FourDiamonds, FiveDiamonds,
             SixDiamonds, SevenDiamonds, EightDiamonds, NineDiamonds, TenDiamonds,
		     JackDiamonds, QueenDiamonds, KingDiamonds,
		   AceHearts, TwoHearts, ThreeHearts, FourHearts, FiveHearts,
             SixHearts, SevenHearts, EightHearts, NineHearts, TenHearts,
		     JackHearts, QueenHearts, KingHearts,
		   AceSpades, TwoSpades, ThreeSpades, FourSpades, FiveSpades,
             SixSpades, SevenSpades, EightSpades, NineSpades, TenSpades,
		     JackSpades, QueenSpades, KingSpades};

// The overloaded << function for output.
ostream& operator<< (ostream& out, card name);

// The overloaded prefix increment operation.
card operator++ (card& name);

// The overloaded postfix increment operation.
card operator++ (card& name, int);
