// Exploring the C++ data types
#include <iostream>
#include <cmath>
using namespace std; //so that we don't have to repeat std::
int main()
{	
	// printing the integer value of char data
	char c = 'B';
	cout << "c contains the letter " << c <<". Its ASCII code is " 
		 << (short) c << endl;
	cout << "\nAddresses and sizes" << endl;
	// getting the address and the size of a variable
	printf("1)c is stored at address %p or %x\n", c, c);
	cout << "The size of c is " << sizeof(c) << endl;
	// the statement below prints the sequence of characters 
	// starting at the address of c, because c is of type char
	printf("The sequence of characters at the address of c is %p or %x\n", c, c);

/////////////////////////////////////////////////////////////////////////////////

	int i = 68;
	cout << "The address if i in hexadecimal is  " << &i << endl;
	printf("The address of i in decimal is %p or %x", i);
	cout  << ". The size of i is " << sizeof(i) << endl;	

	float f = 10;
	cout << "f is stored at address " << &f 
		 << ". The size of f is " << sizeof(f) << endl;	
	
	cout << "The size of type double is " << sizeof(double) << endl;
	cout << "The size of type long is " << sizeof(long) << endl;
	cout << "The size of type short is " << sizeof(short) << endl;

	// using pointers
	cout << "\nUsing pointers"<< endl;
	int * iptr = &i;
	cout << "iptr contains the address " << iptr 
		 << ". The value at this address is " << * iptr << endl;
/////////////////////////////////////////////////////////////////////////////////
	float * fptr = &f;
	double d;
	double * dptr = &d;
	// the size of the pointer does not depend on the size 
	// of the value it points to
	cout << "The size of an int pointer is " << sizeof(iptr) 
		 << ", the size of a float pointer is "<< sizeof(fptr)
		 << " and the size of a double pointer is " << sizeof(dptr) << endl;

	// fptr = &i; // cannot convert
/////////////////////////////////////////////////////////////////////////////////
	// pointer arithmetic
	cout << "\ndptr points to                " << dptr << endl;
	dptr = dptr + 1; //will increment by 8
	cout << "After adding 1 dptr points to " << dptr << endl;

	cout << "\niptr points to                " << iptr << endl;
	iptr = iptr + 1; //will increment by 4
	cout << "After adding 1 iptr points to " << iptr << endl;

	char * cptr = &c;
	cout << "\ncptr points to                " << cptr << endl;
	cptr = cptr + 1; //will increment by 1
	cout << "After adding 1 cptr points to " << cptr << endl;
    
	cout << "\nPointers are dangerous:" << endl;
	//cptr = cptr - 2686460;
	//cout << *cptr << endl; crashes the program
	cptr = cptr - 16;	
	cout <<  "Now cptr points to   " << cptr 
		<< "\nThe address of i is  " << &i 
		<< "\nThe character at this address is " << *cptr << endl;
    cout << "i is " << i << endl;
	cout << "Storing 'A' at the address pointed by cptr: ";
	*cptr = 'A'; // we can change the value at this location
	cout << *cptr << endl;
	cout << "Now i is " << i << endl;

	// change the value of cptr
	cptr +=10;
	cout << "Used casting to set cptr to the addres of i" << endl;
	cptr = (char *) &i;
	cout << "cptr points to " << *cptr << endl;

	cout << "cptr: " << cptr << endl;
	cout << "iptr: " << iptr << endl;
	for (int cnt=0; cnt < 4; cnt++)
	{
		cout << cptr + cnt << ": " << (int)*(cptr + cnt) << endl;
	}

	iptr = new int;
	cout << "Address of iptr: " << &iptr << endl;
	printf("Actual address of iptr: %p", iptr);
	cout << "iptr points to: " << *iptr << endl;

/////////////////////////////////////////////////////////////////////////////////
	//set the pointer to 0
	// cptr = NULL;
	cout << "cptr = NULL; now cptr is " << cptr << endl;
	// cout << *cptr << endl; program crash
	//+=, -=, /=, *=
	cout << "\nUsing +=, -=, /=, *=" << endl;	
	i = 10;
	i += 3 * 8 / 2;
	cout <<"i = 10;i += 3 * 8 / 2; i is " << i << endl;

	cout << "\nPre-and post- increment: " << endl;
	int k=5, l=5, m, n;
	m = ++k; // pre-increment, m will be k + 1
	n = l++; // post-increment, n will be l, but l will be incremented afterwards
    cout << "m is " << m << endl;
	cout << "k is " << k << endl;
	cout << "n is " << n << endl;
	cout << "l is " << l << endl;
    int result = 5*k++ - --l/n++;//don't write expressions like this
	
	const int MY_CONSTANT1 = 5;
	const int MY_CONSTANT2 = 5* MY_CONSTANT1;
	cout << "\nEnter i to test initializing a constant the value of a variable: ";
	cin >> i;
	const int MY_CONSTANT3 = 5 * i;
	cout << "const int MY_CONSTANT3 = 5 * i; The constant is "<< MY_CONSTANT3 << endl;
	// MY_CONSTANT3 *= 3; // cannot do this
	
	cout << "\nThe floating point numbers are only approximations:" << endl;
	d = 2 - sqrt(2.) * sqrt(2.);
	cout << "2 - sqrt(2.) * sqrt(2.) is " << d << endl;

}
