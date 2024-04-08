/* Problem1.cpp | Assignment 1 | Alexander Luna | March 13, 2021
This program will generate a random even integer greater than 2
and find two prime integers that add up to the generated one */

#include <iostream>
#include <cstdlib>
#include <ctime>
using namespace std;

int numberGenerator();
void primeNumbers(int rand);
bool isPrime(int number);

int main()
{
    // Prints out purpose of the program
    cout << "This program will generate a random even integer greater than 2\n"
            "and find two prime integers that add up to the generated one.\n" << endl;

    // Initializes dynamically allocated variable
    int *randomNumber;
    randomNumber = new int;

    // Calls numberGenerator function
    *randomNumber = numberGenerator();

    // Prints dynamically allocated variable
    cout << "The randomly generated number is: "<< *randomNumber << endl;

    // Calls primeNumbers function
    primeNumbers(*randomNumber);
}

// Generatse a random number to return as an int
int numberGenerator()
{
    // Infinite loop
    while (true)
    {
        // Resets rand()
        srand(time(0));

        // Variable is set to a random int
        int randomNumber = rand();

        // Checks if r is even or odd & only returns when even
        if (randomNumber % 2 == 0)
        {
            return randomNumber;
        }
        else
        {
            continue;
        }
    }
}

// Uses the parameter rand to find two prime numbers that add up to it
void primeNumbers(int rand)
{
    // Initializes variables
    int firstNumber, secondNumber;

    // Iterates every number 2-randomNumber until it reaches a prime number
    for (int i = 2; i < rand; i++)
    {   
        // Tests if this iteration of i is a prime number
        bool firstPrime = isPrime(i);

        // If this iteration of i is a prime number, do the below
        if (firstPrime == true)
        {
            // Sets the first number equal to the value of this iteration
            firstNumber = i;

            // Sets secondNumber to the difference of rand & firstNumber
            secondNumber = rand - firstNumber;

            // Tests if secondNumber is a prime number
            bool secondPrime = isPrime(secondNumber);

            // If the secondNumber is a prime number, break from the for loop
            if (secondPrime == true)
            {
                // Prints both prime numbers
                cout << "\nThe first prime number is: " << firstNumber << 
                        "\nThe second prime number is " << secondNumber << endl;
                cout << endl;
                break;
            }
        }
    }
    return;
}

// Takes in a number and returns a bool of true if it's prime and false if it's not
bool isPrime(int number)
{
    // Initializes variable
    bool prime = true;

    // Iterates from 2-number
    for (int i = 2; i < number; i++)
    {
        // If there is no remainder, then it is not a prime number so false is returned
        if (number % i == 0)
        {
            prime = false;
            break;
        }
    }

    // If there was always a remainder, then it is a prime number so return true
    return prime;
}