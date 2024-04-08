// IncomeTax.cpp
//
// Testing the boolean type in C++
#include <iostream>
#include <string>
using namespace std;

int main ()
{
   // type bool is actually an enumeration
   bool b1 = true;
   cout << "b1 is " << b1 << endl;
   b1 = false;
   cout << "b1 is " << b1 << endl;
   cout << false << endl;
   
   // cannot read true or false from the keyboard
  /* cout << "Enter a value for the boolean variable b1: ";
   cin >> b1;
   cout << "b1 is " << b1 << endl;
   cout << "Enter another value for the boolean variable b1: ";
   cin >> b1;
   cout << "b1 is " << b1 << endl;
   */
   cout << "Enter 1 for the boolean variable b1: ";
   cin >> b1;
   cout << "b1 is " << b1 << endl;
   if (b1)
	   cout << "b1 is true" << endl;
   else 
	   cout << "b1 is false" << endl;

   // integer expression can be tested as boolean
   // 0 is false, non-0 is true
   int low = 20;
   if (low)
	   cout << "low is true" << endl;
   else 
	   cout << "low is false" << endl;

   low = 0;
   if (low)
	   cout << "low is true" << endl;
   else 
	   cout << "low is false" << endl;

   double d1 = 20.0;
   if (d1)
	   cout << "d1 is true" << endl;
   else 
	   cout << "d1 is false" << endl;

   d1 = .0;
   if (d1)
	   cout << "d1 is true" << endl;
   else 
	   cout << "d1 is false" << endl;

   /*
   //conditional expressions of type string are illegal
   string s1 = " ";   
   if (s1)
	   cout << "s1 is true" << endl;
   else 
	   cout << "s1 is false" << endl;
   */
   if (" ")
	   cout << "space means true" << endl;
   else 
	   cout << "space means false" << endl;

   if ("")
	   cout << "empty means true" << endl;
   else 
	   cout << "empty means false" << endl;

   // shortcut evaluation
   int b = 3;
   if ((b < 10) || (b = 10))
	   cout << "b is " << b << endl;

   // full evaluation
   b = 3;
   if ((b < 10) | (b = 10))
	   cout << "b is " << b << endl;

   if (! true && false)
	   cout << "&& has higher priority than !" << endl;
   else
	   cout << "! has higher priority than &&" << endl;

   if (false && false || true && true)
	   cout << "&& has higher priority than ||" << endl;
   else
	   cout << "|| has higher priority than &&" << endl;

   // Comparing strings
  
   string two = "david";
   string one = "Tom";

   if (one < two)
	   cout << "\"Tom\" is less than \"david\"" << endl;
   else
	   cout << "\"Tom\" is NOT less than \"david\"" << endl;

   if ("Tom" < "david")
	   cout << "\"Tom\" is less than \"david\"" << endl;
   else
	   cout << "\"Tom\" is NOT less than \"david\"" << endl;

}