#include <iostream>
#include <string>

using namespace std;

int main()
{  
   cout << "Enter your full name (first middle last): ";
   string first;
   string middle;
   string last;
   cin >> first >> middle >> last;
   string copyLast = last;
   cout << "copyLast is " << copyLast << endl;
   cout << "Enter 2 words: ";
   cin >> first;
   cout << "You entered " << first << endl;
   // to read including white space characters, use getline
   cout << "Enter 2 words: ";
   getline(cin, first); // does not wait for the input
   cout << "You entered " << first << endl;  


/*
   string initials = first.substr(0, 1) 
      + middle.substr(0, 1) + last.substr(0, 1);
   cout << "Your initials are " << initials << "\n";
*/
   return 0;
}
