// demonstrate function with variable no of arguments
#include <iostream>
//#include <stdarg.h>
#include <cstdarg>
// has macros to allow variable no of arguments
using namespace std;

int add_numbers(int num1 ...);   // has a variable number of int arguments
                                 // but only the first argument's type is checked
void show_list(int num1, char * name1 ...); // has a variable number of char * arguments
                                 // but only the first argument is checked

int main()
{

    cout << "Use add_numbers() to add 1,2,3,4" << endl;
    cout << "\n\nResult is " << add_numbers(1, 2, 3, 4, 0);
	cout << "\n\nUse add_numbers() to add 1, \"ab\", \"ab\" "<< endl;
    cout << "\n\nResult is " << add_numbers(1,"ab","ab", 0);

    cout << "\n\nHere is a list of 3 names using show_list()";
    show_list(7, "Sue", "Mike", "Ann", "Mata", "Li Hong");
    cout << endl;
}

int add_numbers(int num1 ...)
{
    va_list arguments; // va_list is a special data type
	                   // defined in CSTDARG
    int num = num1, total = 0;

    va_start(arguments, num1); // va_start sets start of list
	                           // to first argument
    do
    {
		total += num;
		cout << num << " ";
    } while( (num = va_arg(arguments, int) ) != 0); // va_arg needs to
	                                           // know the type is int
    va_end(arguments); //cleans the work space used by va_list etc.
    return total;
}

void show_list(int num1, char * name1 ...)
{
    va_list arguments;
    char *pname = name1;

    va_start(arguments, name1);
    for (int count = 1; count <= num1; count ++)
    {
		cout << "\n" << pname;
		pname = va_arg(arguments, char *); // va_arg needs to know
			                              // the type is char *
    }
    va_end(arguments);
}