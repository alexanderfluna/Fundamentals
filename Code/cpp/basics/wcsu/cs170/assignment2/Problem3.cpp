#include <iostream>
#include <iomanip>
using namespace std;

void createSquare(int n);

int main()
{
    cout << "This program will prompt for an odd integer and create a magic "
            "square with the 1 starting in the middle of the bottom row.\n" << endl;

    /* Prompts for an odd integer and calls createSquare() 
    with the odd integer as its argument */
    int n;
    do
    {
        cout << "Enter an odd integer: ";
        cin >> n;
    } while (n % 2 == 0 || n < 0);
    createSquare(n);
}

/**
    Prints a magic square given the specifications
    @param n odd integer given by user
*/
void createSquare(int n)
{
    int magicSquare[n][n], i, j;

    // Populates magicSquare with 0s
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            magicSquare[i][j] = 0;
        }
    }

    // Starting position for 1
    i = n - 1;
    j = n / 2;

    // Populates magicSquare with values n - n*n
    for (int k = 1; k <= n * n;)
    {
        magicSquare[i][j] = k++;
        int row = i;
        int column = j;
        i++;
        j++;
        if (i == n)
            i = 0;
        if (j == n)
            j = 0;
        if (magicSquare[i][j])
        {
            i = row;
            j = column;
            i--;
        }          
    }

    // Print magic square
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            cout << setw(4) << magicSquare[i][j];
        }
        cout << "\n";
    }
}