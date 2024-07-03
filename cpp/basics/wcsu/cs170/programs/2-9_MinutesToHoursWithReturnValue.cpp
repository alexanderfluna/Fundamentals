// Hours.cpp
//
// This program determines the number
// of hours in a given number of
// minutes.

#include <iostream>
using namespace std;

//calculate and return the whole hours
//in the given number of minutes
int minutesToHours (int min); // prototype

//calculate and return the remaining minutes
//after the whole hours in the given number of minutes
int remainingMinutes (int min); //prototype

int main ()
{
   int minutes;
   cout << "How many minutes? ";
   cin >> minutes;  // input from user
   cout << "This is " << minutesToHours(minutes) << " hours "; // use function  
   cout <<" and " << remainingMinutes (minutes) << " minutes." << endl;  
   int twiceHours = 2 * minutesToHours(minutes);
   cout << "Thank you for using this program\n";
}


int minutesToHours (int min){
	return min/60;
}

int remainingMinutes (int min){
	return min % 60;
}