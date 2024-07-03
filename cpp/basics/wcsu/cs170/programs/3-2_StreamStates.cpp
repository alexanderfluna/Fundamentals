/*
* StreamStates.cpp: Output stream states before and after input
*
* Author: Dr. Sean Murthy
* CS170@WCSU
*
*/

#include <iostream>

using namespace std;

int main()
{
	while (true){
		int number = 0;
		cout << "Variable number before input: " << number << endl << endl;
		cout << "Initial state of cin: " << endl;
		cout << "bad(): " << (cin.bad() ? "true" : "false") << endl;
		cout << "fail(): " << (cin.fail() ? "true" : "false") << endl;
		cout << "cin: " << (cin ? "true" : "false") << endl;
		cout << "eof(): " << (cin.eof() ? "true" : "false") << endl;
		cout << "good(): " << (cin.good() ? "true" : "false") << endl;
		cout << endl << "Run the program many times, each time with different inputs such as 5, 5t, t5, ^Z, and 5^Z" << endl;
		cout << endl << "Enter a number: ";
		cin >> number;
		cout << endl;
		cout << "Variable number after input: " << number << endl << endl;
		cout << "State of cin after input: " << endl;
		cout << "bad(): " << (cin.bad() ? "true" : "false") << endl;
		cout << "fail(): " << (cin.fail() ? "true" : "false") << endl;
		cout << "cin: " << (cin ? "true" : "false") << endl;
		cout << "eof(): " << (cin.eof() ? "true" : "false") << endl;
		cout << "good(): " << (cin.good() ? "true" : "false") << endl;
		cout << endl;
		cin.clear();
		cin.ignore(80, '\n');
	}
	return 0;
}