// using the C++ qsort function
#include <iostream>
#include <search.h>
using namespace std;

int compare(const void* , const void*);

void main()
{
    int i, test[10];

    cout << "Enter 10 integers seperated by spaces:\n";
    for (i = 0; i < 10; i++)
    {
        cin >> test[i];
    }

    qsort(test, 10, sizeof(int), compare);

    cout << "\n\nThe sorted numbers are:\n";
    for (i = 0; i < 10; i++)
    {
        cout << test[i] << " ";
    }

    cout << "\n\n";

}

int compare(const void* pnum1, const void *pnum2)
// compares two numbers, returns -1 if first is smaller
// returns 0 is they are equal, returns 1 if first is larger
{
    int num1, num2;

    num1 = *(int *)pnum1;  // cast from pointer to void
    num2 = *(int *)pnum2;  // to pointer to int

    if(num1 < num2)
        return -1;
    else
        if (num1 == num2)
            return 0;
        else
            return 1;
}

