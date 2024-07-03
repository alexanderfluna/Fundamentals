/* Problem2.cpp | Assignment 1 | Alexander Luna | March 13, 2021
This program will ask the user for a Roman number and print out
its equivalent decimal value */

#include <iostream>
#include <string>
using namespace std;

void calculateValue(string num);

int main()
{
    // Prints purpose of the program
    cout << "This program will ask the user for a Roman number and print out"
            " its equivalent decimal value.\n" <<endl;

    // Initializes variable
    string romanNumber;

    // Collects Roman number
    cout << "Type a Roman number: ";
    cin >> romanNumber;

    // Calls function
    calculateValue(romanNumber);
}

// Takes in Roman number and converts it to its equivalent decimal value
void calculateValue(string num)
{
    // Initializes variable
    int decimalValue;

    // Iterates from 0 - length of num
    for (int i = 0; i < num.length(); i++)
    {
        // Extracts each Roman numeral
        char symbol = num[i];

        // Adds to decimalValue depending on Roman numeral
        if (num[i] == 'I' && num[i+1] == 'V')
        {
            decimalValue += 4;
            i++;
        }
        else if (num[i] == 'I' && num[i+1] == 'X')
        {
            decimalValue += 9;
            i++;
        }
        else if (num[i] == 'X' && num[i+1] == 'L')
        {
            decimalValue += 40;
            i++;
        }
        else if (num[i] == 'X' && num[i+1] == 'C')
        {
            decimalValue += 90;
            i++;
        }
        else if (num[i] == 'C' && num[i+1] == 'D')
        {
            decimalValue += 400;
            i++;
        }
        else if (num[i] == 'C' && num[i+1] == 'M')
        {
            decimalValue += 900;
            i++;
        }
        else if (symbol == 'I')
        {
            decimalValue += 1;
        }
        else if (symbol == 'V')
        {
            decimalValue += 5;
        }
        else if (symbol == 'X')
        {
            decimalValue += 10;
        }
        else if (symbol== 'L')
        {
            decimalValue += 50;
        }
        else if (symbol == 'C')
        {
            decimalValue += 100;
        }
        else if (symbol == 'D')
        {
            decimalValue += 500;
        }
        else if (symbol == 'M')
        {
            decimalValue += 1000;
        }
    }

    // Prints out decimalValue
    cout << "The decimal value is: " << decimalValue << endl;
}