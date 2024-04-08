// Data types
#include <iostream> //for input and output
#include <cmath> //for the built-in mathematical functions
using namespace std; 
void main()
{
	// char type
	char c;
	c = 'A'; //'A' is a char literal
	cout << "c is " << c << endl; //endl is for end of line

	int num = c; //assign the value of c to num
	cout << "num is " << num << 
		    " which is the ASCII code for 'A'"<<endl; 	
	char temp = 'a';
	cout << (int) temp << " is the ASCII code of 'a'"<< endl;
	c = c+1; // can do arithmetic with ch
	
	cout << "c is " << c << endl;
	cout << "c in lower case is " << (char)( c + ('a' - 'A')) << endl<< endl;
	cout << "===============Type short===============" << endl;
	// type short
	short s1 = -32768;
	cout << "s1 is " << s1 << endl;
	s1 = s1 - 1; //overflow, results in a positive number
	cout << "s1 is " << s1 << endl;
	s1 = s1 + 1; // overflow resulting in a negative number
	cout << "s1 is " << s1 << endl;
	s1 = c;
	cout << "s1 is " << s1 << endl;
	c = 32767; // overflow, compiler issues a warning
	s1 = c;
	cout << "s1 is " << s1 << endl;
	cout << "c is |" << c << "|\n\n";
	
	// type int
	cout << "===============Type int===============" << endl;	
	int num2 = -32768;
	num2 = num2 - 1; // no overflow
	cout << "num2 is " << num2 << "\n";
	num2 = 2147483647;
	num2 = num2 + 1; // overflow
	cout << "num2 is " << num2 << "\n\n";

	// type float
	cout << "===============Type int===============" << endl;
	float f1 = 2.5; //2.5 is a double literal; no warning from the compiler
	cout << "f1 is " << f1 << endl;
	f1 = 0.123456789; // warning: truncation from double to float
	cout << "f1 is " << f1 << endl;
	f1 = 2.5F;
	f1 = 0.123456789F;
	cout << "f1 is " << f1 << endl;
	
	//assigning a float or double to int
	num = f1+0.5F; //the fractional part is lost
	cout << "num is " << num << endl;

	//double literals in scientific notation
	double d = 0.5E-5; // 0.000005
	cout << "d is " << d << endl;
	cout << 1 - d << endl;
	d = 0.000005;
	cout << "d is " << d << endl;

	// checking the type
	cout << "f1+0.5 is of type " << typeid(f1 + 0.5).name() << endl;

	cout << "0.5E-5 is of type " << typeid(0.5E-5).name() << ". Its size is " 
		 << sizeof(0.5E-5) << "bytes." << endl;
	cout << "0.5F is of type " << typeid(0.5F).name() <<". Its size is " 
		 << sizeof(0.5F) << " bytes." << endl;
	
	// named constant
	const int START = 2000; // must be initialized

	// enumerated type
	cout << "===============Enumerations===============" << endl;
	enum Color { RED, YELLOW, GREEN, BLACK }; // type declaration
	Color carColor = RED; //carColor is a variable of type Color
	cout << "carColor is " << carColor << endl; //prints the numeric value
    cout << "GREEN is " << GREEN << endl;
	num = BLACK;
	//carColor = num; no automatic conversion
	carColor = (Color) num;
	cout << "carColor is " << carColor << endl;
	carColor =(Color) 10;
	cout << "carColor is " << carColor << endl<<endl;
	
	//Integer division
	cout << "===============Integer division and modulo===============" << endl;
	num = 10/3; // integer division, results in 3
	cout << "num is " << num << endl;
	num = 10 % 3; // modulus operation, results in 1
	cout << "num is " << num << endl;
	
	d = 10/3; // Integer division. assigning an int to double
	cout << "d is " << d << endl;
	d = 10.0/3.0; //floating point division
	cout << "d is " << d << endl;
	d = (double) 10/ (double) 3;//casting the integers to double
	cout << "d is " << d << endl;	
	num = 10.0/3.0; //assigning double to int - fractional part lost
	cout << "num is " << num << endl;
	num = 10.0/3.0+ 0.5; //fractional part is lost
	cout << "num is " << num << endl;
	//(double) 10 / 3 is of type double
	cout << "(double) 10 / 3 is of type " << typeid((double) 10 / 3).name() << endl;
	d = (double) 10/ 3; //casting one of the operands leads to automatic conversion of the other
	cout << "d is " << d << endl;
	d = (double) (10/ 3);// result is 3
	cout << "d is " << d << endl;
	
	// Using built-in functions
	//Floating point types are approximations	
	cout << "===============Floating point arithmetic===============" << endl;
	if (2.0 == sqrt(2.0) * sqrt(2.0))
		cout << "sqrt(2.0) * sqrt(2.0)) is 2" << endl;
	else 
		cout << "sqrt(2.0) * sqrt(2.0)) is NOT 2" << endl;

	// get the difference
	d = 2.0 - sqrt(2.0) * sqrt(2.0);
	cout << "d is " << d << endl;

	//better way to compare floating point numbers
	//compare the absolute value of the difference
	//with the required precision
	if (abs(2.0 - sqrt(2.0) * sqrt(2.0)) < 1e-15)
		cout << "sqrt(2.0) * sqrt(2.0)) is close enough to 2" << endl;
	else
		cout << "sqrt(2.0) * sqrt(2.0)) is NOT close enough to 2" << endl;

	if (abs(2.0 - sqrt(2.0) * sqrt(2.0)) < 1e-16)
		cout << "sqrt(2.0) * sqrt(2.0)) is close enough to 2" << endl;
	else
		cout << "sqrt(2.0) * sqrt(2.0)) is NOT close enough to 2" << endl;

}
