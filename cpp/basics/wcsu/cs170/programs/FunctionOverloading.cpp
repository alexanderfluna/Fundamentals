// Using overloaded functions
#include <iostream>

using std::cout;
using std::endl;

float square( float x ) {
	cout << "square of float" << endl;
	return x * x; 
}

double square( double y ) { 
	cout << "square of double" << endl ;
	return y * y; 
}

int main()
{
	cout << "The square of double 7 is "  << square(7.0) << endl;
    cout << "The square of float  7.5 is "<< square(7.5f) << endl;   

   return 0;
}

