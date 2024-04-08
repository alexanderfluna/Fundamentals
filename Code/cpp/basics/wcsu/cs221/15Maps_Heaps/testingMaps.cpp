//Use a map to count how many times each number was generated
#include <iostream>
#include <cstdlib>
#include <utility>
#include <string>
#include <map>
#include <ctime>
using namespace std;

int main()
{  
   map<string, int> testMap;
   testMap["Peter"] = 1;
   testMap["Harry"] = 2;
   map<string,int>::iterator pos = testMap.begin();
   
   while (pos != testMap.end()){
	   cout << pos->first <<" "<< pos->second << endl;
	   pos++;
   }
   cout << "End of testMap" << endl;

   pos = testMap.find("Dick");
   if (pos != testMap.end())
	   cout << "Found " << pos->first << " "<< pos->second << endl;
   else
	   cout << "\nDick not found\n"<< endl;

   pair<string, int> p = make_pair("Dick", 86);
   testMap.insert(p);
   pos = testMap.find("Dick");
   if (pos != testMap.end())
	   cout << "Found " << pos->first << " "<< pos->second << "\n"<<endl;
   else
	   cout << "\nDick not found\n" << endl;


   // Find the number of occurencies of a number
   // in a randomly generated sequence of numbers
   map<int, int> intMap;
   srand(time(0));
   int i;
   for (i = 1; i <= 100; i++)
   {
	   int num = 1 + rand() % 5;
	   if (intMap.find(num) == intMap.end())
		   intMap[num] = 1;
	   else {
		   int temp = intMap[num];
		   temp++;
		   intMap[num] = temp;
	   }
   }
   int sum = 0;
   map<int, int>::iterator intPos = intMap.begin();
   
   for (intPos = intMap.begin(); intPos != intMap.end(); intPos++)
   {
	   sum += intPos->second;
	   cout << intPos->first
		   << " was generated " << intPos->second << " times\n";
   }

   cout << "In total " << sum << " numbers were generated.\n" << endl;
   return 0;
}
