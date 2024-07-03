#include <iostream>
#include <string>

using namespace std;

int main()
{  
   cout << "Enter your full name (first middle last): ";
   string first;
   string middle;
   string last;
  
   first = "Peter";
   middle = "George";
   last = "Thomas";
   cout << "first is "<< first << endl;
   //cout << "its length is " << length(); // cannot call length without an object
   cout << "its length is " << first.length() << endl;
   cout << "The substring of first, starting at position 2, length 3 is " 
	   << first.substr(2,3) << endl;
   
   string initials = first.substr(0, 1) 
      + middle.substr(0, 1) + last.substr(0, 1);
   cout << "Your initials are " << initials << "\n";
   //string test = first + 2; // cannot convert - ambiguous 
   string test = first + "2";
   cout << "test is " << test << "\n";
   test = "2" + first;
   cout << "test is " << test << "\n";

   return 0;
}
