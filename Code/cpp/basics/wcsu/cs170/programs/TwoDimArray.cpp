// Introducing multidimensional arrays
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
    int n,m;
    int table[3][4] =
	{ {1,2,3,4},{2,4,999,8},{3,6,9,12} };

    
    // dealing with the table
    cout << "The size of the table is " << sizeof(table)
         << " bytes\n";
    cout << "Here are the contents of the table\n";
    for (n = 0; n < 3; n++)
    {
        for (m = 0; m < 4; m++)
        {
            cout << setw(4) << table[n][m] << " ";
        }
        cout << "\n";
    }

    //dealing with rows
    cout << "\nThe size of a row is " << sizeof(table[1])
         << " bytes";
    cout << "\nEnter row in table ";
    cin >> n;
    cout << "Here is the row you chose\n";
    for (m = 0; m < 4; m++)
    {
        cout << setw(4) << table[n][m] << " ";
    }

    // dealing with elements
    cout << "\n\nThe size of an element is " << sizeof(table[1][1])
         << " bytes";
    cout << "\nEnter row and column in table ";
    cin >> n >> m;
    cout << "element [" << n << "]["
         << m << "] = " << table[n][m] << "\n";
    cout << "\nKey in a new value for this element ";
    cin >> table[n][m];

    // redisplay the table
    cout << "\nHere are the altered contents of the table\n";
    for (n = 0; n < 3; n++)
    {
        for (m = 0; m < 4; m++)
        {
            cout << setw(4) << table[n][m] << " ";
        }
        cout << "\n";
    }
    cout << "\n\n";
    
}

