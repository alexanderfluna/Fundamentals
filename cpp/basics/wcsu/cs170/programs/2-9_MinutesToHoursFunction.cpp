#include <iostream>

// This function inputs the number of minutes,
// converts this amount into hours and minutes,
// and prints the result.
void minutesToHours ()
{
   int minutes, hours;    // variables

   std::cout << "How many minutes? ";
   std::cin >> minutes;  // input from user
   hours = minutes / 60;
   minutes = minutes % 60;
   std::cout << "This is " << hours <<
      " hour(s) and " << minutes <<
      " minute(s)." << std::endl;
}
