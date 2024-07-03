// Inline Functions and Macros
#include <iostream>
using namespace std;

#define SQUARE(x) x*x              // C style macro

inline int Squaref(int x) {return x*x;} // C++ inline function

int main()
{
    int n;

    cout << "\nProblems with using a macro without enough parentheses";
    cout << "\n SQUARE of 3:   should be 9   gave " 
		<< SQUARE(3);
    cout << "\n SQUARE of 3+4: should be 49  gave " 
		<< SQUARE(3+4);
    cout << "\n SQUARE of 3-4: should be 1   gave " 
		<< SQUARE(3-4);
    cout << "\n SQUARE of 3/4: should be 0   gave " 
		<< SQUARE(3/4);
    n = 3;
    cout << "\n When n is set to 3";
    cout << "\n SQUARE of n++: should be 9   gave " 
		<< SQUARE(n++);
    n = 3;
    cout << "\n SQUARE of ++n: should be 16  gave " 
		<< SQUARE(++n);

    cout << "\n\n\nImprovements using an inline function";
    cout << "\n Square of 3:   should be 9   gave " 
		<< Squaref(3);
    cout << "\n Square of 3+4: should be 49  gave " 
		<< Squaref(3+4);
    cout << "\n Square of 3-4: should be 1   gave " 
		<< Squaref(3-4);
    cout << "\n Square of 3/4: should be 0   gave " 
		<< Squaref(3/4);
    n = 3;
    cout << "\n When n is set to 3";
    cout << "\n Square of n++: should be 9   gave " 
		<< Squaref(n++);
    n = 3;
    cout << "\n Square of ++n: should be 16  gave " << Squaref(++n);

    cout << "\n\n";
    
}
