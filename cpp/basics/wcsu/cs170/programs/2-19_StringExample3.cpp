#include <iostream>
#include <string>
using namespace std;

int main ()
{
	string name = "John"; // declaration and initialization
	cout << "name is " << name << endl;
	name = "Carl"; // assignment
	cout << "name is " << name << endl;
	cout << "Please enter your name (no spaces): "; // output 
	cin >> name; // input (stops at first white space)
	cout << "name is |" << name << "|\n";	
	getline(cin, name); // ignore the end-of-line characters, left after >>
	//cout << "name is |" << name << "|\n";
	cout << "Please enter your name (can have spaces):"; // output 
	getline(cin, name); // no new line characters left in stream
	cout << "Please enter your name (can have spaces)again:"; // output 
	getline(cin, name);

	cout << "name is |" << name << "|\n";
	cout << "The length of name is " << name.length() << " characters." << endl;
	cout << "The first 5 characters of name are " << name.substr(0,5) << endl;
	cout << "The part of name starting at position 6 is " << name.substr(6) << endl;
	cout << "Positions are numbered from 0" << endl;

	// using function ignore() after >> to ignore the new line left in the stream
	string word, line;
	cout << "Please enter your one word (no spaces): "; // output 
	cin >> word; // input (stops at first white space)
	cout << "You entered |" << word << "|\n";	
	cin.ignore(80,'\n'); // ignore the end-of-line characters, left after >>		
	cout << "Please enter a line (can have spaces):"; // output 
	getline(cin, line); // no new line characters left in stream
	cout << "You entered |" << line << "|\n";
	cout << line + word;
	//cout << "Hello " + "world"; // + cannot be used with 2 C-strings
	cout << string("Hello") + " world!"; //constructing a string object
	cout << ((string) "Hello") + " world!"; // casting

}





