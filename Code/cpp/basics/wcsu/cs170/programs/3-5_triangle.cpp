#include <iostream>

using namespace std;

int main()
{ 
   int area = 0;
   cout << "Enter number of rows: "; 
   int rows; 
   cin >> rows; 

   for (int row = 1; row <= rows; row++) 
   { 
      for (int col = 1; col <= row; col++) {
         cout << "[]";
         area++; 
      }
      cout << endl;  
   } 
   
   cout << "The area of this triangle is " << area
   << " units" << endl;
   return 0; 
} 
