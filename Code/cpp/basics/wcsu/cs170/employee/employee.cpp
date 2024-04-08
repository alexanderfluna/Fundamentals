#include <iostream>

using namespace std;

#include "ccc_empl.h"

int main()
{  
   Employee harry("Hacker, Harry", 45000.00);
   
   double new_salary = harry.get_salary() + 3000;
   harry.set_salary(new_salary);

   cout << "Name: " << harry.get_name() << "\n";
   cout << "Salary: " << harry.get_salary() << "\n";
   
   Employee peter;
   cout << peter.get_name() <<endl;
   cout << peter.get_salary() << endl;
  
   return 0;
}
