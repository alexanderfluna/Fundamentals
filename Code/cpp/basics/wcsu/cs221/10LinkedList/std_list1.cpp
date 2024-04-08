#include <string>
#include <list>
#include <iostream>
using namespace std;

void print(list<string> lst);
int main()
{  
   list<string> names;

   names.push_back("Tom");
   names.push_back("Dick");
   names.push_back("Harry");
   names.push_back("Juliet");
   cout << "The list is " << endl;
   print(names);

   // Add a value in fourth place
   list<string>::iterator pos;
   pos = names.begin();
   pos++;
   pos++;
   pos++;
   names.insert(pos, "Romeo");
   cout << "\nAfter inserting Romeo at the 4th position the list is " << endl;
   print(names);
   // Remove the value in second place

   pos = names.begin();
   pos++;   
   pos=names.erase(pos);
   cout << "After erasing Dick pos points to "<< *pos << endl;

   // Print all values
   cout << "\nAfter erasing the second element the list is " << endl;
   print(names);   

   return 0;
}

void print(list<string> lst){
	list<string>::iterator pos;
	for (pos = lst.begin(); pos != lst.end(); pos++)
		cout << *pos << "\n";
}
