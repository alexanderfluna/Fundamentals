// Class average program with sentinel-controlled repetition.
#include <iostream>

using std::cout;
using std::cin;
using std::endl;
using std::ios;

#include <iomanip>

using std::setprecision;
using std::setiosflags;

int main()
{
   int total,        // sum of grades
       gradeCounter, // number of grades entered
       grade=0;        // one grade       
   double average;   // number with decimal point for average

   // initialization phase
   total = 0;
   gradeCounter = 0;

   // processing phase
   cout << "Enter grade, ^Z to end: ";    
   while (true) {	   
	   if (!(cin >> grade)){
		   if (cin.eof()) break;
		   else {
			   cout << " Bad input.\n";
			   cin.clear();
			   cin.ignore(80, '\n');
			   cout << " Try again: ";
			   continue;
		   } //else
	   } //if
	   else{
		   total = total + grade;
		   gradeCounter = gradeCounter + 1;
		   cout << "Enter grade, ^Z to end: ";
	   } //else
   }// while

   // termination phase
   if ( gradeCounter != 0 ) {     
      average = static_cast< double >( total ) / gradeCounter;   
      cout << "Class average is " << setprecision( 2 )
           << setiosflags( ios::fixed | ios::showpoint )
           << average << endl;
   }
   else
      cout << "No grades were entered" << endl;

   return 0;   // indicate program ended successfully
}//main

