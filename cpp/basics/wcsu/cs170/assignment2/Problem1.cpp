#include <iostream>
#include <string>
#include <cstdarg>
#include <math.h>
#include <iomanip>
using namespace std;

void write(string str, int num, ...);

int main()
{
    cout << "This program will use the function write to take in a string with "
            "formats in the form {index[:specifier]}, take in any number of "
            "arguments of type double, and print out the result according to "
            "the formats.\n" << endl;

    /* The first argument must be a string that may contain formats of the form {index[:specfier]}, where the :specifier may be missing. 
    The second argument must be the number of doubles getting passed. The subsequent arguments are the doubles */
    write("The multiple format specifiers are {0}, {1:c}, {2:e}, {3:f}, and {4:i}", 5, 62.39, 87.43, 3.91, 43.46, 360.91);
    write("{0} is less than {1}", 2, 21.9, 72.58);
    write("I had {0:c} and spent {1:c}, so now I have {2:c} left", 3, 72.58, 11.08, 61.50);
    write("Scientific notation is used for very large or small numbers and look like {0:e}, {1:e}, {2:e}, and {3:e}", 4, 6.5, 1.62, 2.7321, 9.384);
    write("{0:f} and {1:f} rounded would be {2:i} and {3:i}, respectively", 4, 12.01, 89.89, 12.01, 89.89);
}

/**
    Prints string with doubles in place of the formats
    @param str string that may include formats
    @param num number of doubles getting passed
*/
void write(string str, int num, ...)
{
    // The doubles are passed into the array
    double arguments[num];
    va_list valist;
    va_start(valist, num);
    for (int i = 0; i < num; i++)
    {
        arguments[i] = va_arg(valist, double);
    }
    va_end(valist);

    // Iterates through the string
    for (int i = 0; i < str.length(); i++)
    { 
        if (str[i] == '{')
        {
            // If there is no :specifier
            int index = int(str[i+1]) - '0';
            if (str[i+4] != '}')
            {
                cout << arguments[index];
                i += 2;
            }
            // If there is a :specifier
            else
            {
                switch(str[i+3])
                {            
                    case 'c':
                        cout << "$" << fixed << setprecision(2) << arguments[index];
                        i += 4; 
                        break;
                    case 'e':
                        cout << scientific << setprecision(6) << arguments[index];
                        i += 4; 
                        break;
                    case 'f':
                        cout << fixed << setprecision(6) << arguments[index];
                        i += 4; 
                        break;
                    case 'i':
                        cout << setprecision(0) << round(arguments[index]);
                        i += 4; 
                        break;
                }
            }
        }
        // Prints every other character
        else
        {
            cout << str[i];
        }
    }
    cout << "\n";
}