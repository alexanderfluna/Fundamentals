/* Problem3.cpp | Assignment 1 | Alexander Luna | March 14, 2021
This proram will prompt the user for a positive range of integer
and generate a random integer in the range. Then it will run the
integer through the ISBN formula and modify the last digit if required */

#include <iostream>
using namespace std;

void formulaCheck(int num);
void newInteger(int formula);

int main()
{
    // Initializes variables
    int startRange, endRange;

    // Prints purpose of the program
    cout << "This proram will prompt the user for a positive range of integers"
            " and generate a random integer in the range. Then it will run the"
            " integer through the ISBN formula and modify the last digit if required.\n" << endl;

    // Gets range for integer
    cout << "Enter a positive integer for the start of the range: ";
    cin >> startRange;
    cout << "Enter a positive integer for the end of the range: ";
    cin >> endRange;

    // Creates random integer in given range
    srand(time(0));
    int randomNumber = (rand() % (endRange - startRange + 1 )) + startRange;
    cout << "Your random number is " << randomNumber << endl;

    // Calls function
    formulaCheck(randomNumber);
}

// Takes in int num to check if the integer follows the ISBN formula
void formulaCheck(int num)
{
    // Initializes variables
    int temp;
    int digits = 0;
    int reverse = 0;
    int digitCount = 0;
    int formula = 0;
    int i = 0;
    int checkSum;

    // Create a variable with the reversed digits of num, keeps track of
    // the amount of digits, and stores reverse into temp
    while (num != 0)
    {
        digits = num % 10;
        reverse += digits;
        reverse *= 10;
        num /= 10;
        digitCount++;
    }
    reverse /= 10;
    temp = reverse;

    // Runs reverse through ISBN formula and sets checkSum = to the last 
    // digit of the integer
    while (i < digitCount - 1)
    {
        i++;
        digits = (reverse % 10) * i;
        formula += digits;
        reverse /= 10;
    }
    checkSum = reverse % 10;
    formula %= (digitCount + 1);

    // If formula is equal to checksum, the random int works with the formula
    if (formula == checkSum)
    {
        cout << "The random integer works with the ISBN formula." << endl;
    }
    // If not, this will print out the correct value of the last digit
    else
    {
        cout << "The random integer does not work with the ISBN formula."
                " The correct value for the last digit would be " << formula << endl;
    }
}