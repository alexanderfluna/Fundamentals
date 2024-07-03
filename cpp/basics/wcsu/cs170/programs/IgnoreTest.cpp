#include <iostream>
#include <string>

using namespace std;

int main( ) 
{  
   string s;
   cout << "Type 'abcdef': ";
   cin.ignore( 2, 'l' );
   cin >> s;
   cout << s << endl;

   cout << "Type 'abcdef': ";
   cin.ignore( 2, 'l' );
   cin >> s;
   cout << s << endl;
}