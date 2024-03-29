#include "ccc_empl.h"
#include <iostream>
#include <fstream>

using namespace std;

Employee::Employee()
{  
   salary = 0;
}

Employee::Employee(string employee_name, double initial_salary)
{  
   name = employee_name;
   salary = initial_salary;
}

void Employee::set_salary(double new_salary)
{  
   salary = new_salary;
}

double Employee::get_salary() const
{  
   return salary;
}

string Employee::get_name() const
{  
   return name;
}

void Employee::readFromFile(ifstream &theFile){
	theFile >> name;
	theFile >> salary;	
}
