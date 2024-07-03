/**********************************************************
* FILE'S NAME: Problem03.cpp
* PROJECT: Assigment 1 for C170 @ WCSU
* AUTHOR: Diu Nghiem, ntdiu@yahoo.com
* Last updated date: March 19, 2021
************************************************************
An ISBN (International Standard Book Number) consists of 10 digits 
                     d1d2d3d4d5d6d7d8d9d10.
The last digit is a checksum, which is calculated from the other
nine digits using the following formula:
          (d1*1+d2*2+d3*3+d4*4+d5*5+d6*6+d7*7+d8*8+d9*9) % 11
If the result of the modulo operation is 10, the letter 
X is used for the last digit.

Develop a program that will generalize the process above.
It will prompt the user for a positive range of integers and
generate a random integer in this range.
Then it will check whether the last digit of the generated number
is equal to (d1*1+d2*2+….+dn-1*(n-1)) % (n+1), where n is the
number of digits of the integer generated.
If it is not, in a loop visit each of the digits d2 to dn-1 
of the number and try to modify that digit so that after modification
dn = (d1*1+d2*2+….+dn-1*(n-1)) % (n+1).

Show all solutions your program finds.
Your program should work with positive integers of any length from 3 to 9.

NOTE: Since the function rand generates integers between 0 and the constant RAND_MAX  (32767),
you can satisfy the minimum requirements for this problem by limiting the length of
the interval the user specifies to 32767, so that your program can still be tested
with  positive integers of any length from 3 to 9.
Removing this limitation will be considered extension of the functionality of the program.

Design your solution with functions that perform smaller, easier to understand and debug algorithms.
Do not use character or string representation of numbers and do not convert numbers to strings anywhere
in the program. Do not use arrays, vectors, or other collections.
*/

#include <iostream>
#include <ctime>
#include <cassert>
using namespace std;

int CreateRandom();                      
int RandWithRAND_MAX();
int readInt(string message);                // Read an integer with a promt message
int countDigit(int num);                    // count number of digit in the integer num
bool isLikeISBN(int Num, int nDigit);       // check if integer Num with nDigit is alike an ISBN
bool isISBN_Wiki1(int Num, int nDigit);      // "Wiki Formula"
bool Modify(int Num, int nDigit, int istart, int iend);     // Modify from d_istart to d_iend

int main()
{
//    assert(countDigit(123) == 3);         assert(countDigit(12345) == 5);
//    assert(countDigit(12345678) == 8);    assert(countDigit(123456789) == 9);
//    assert(!isLikeISBN(367,3));
//    assert(isISBN_Wikipedia(2383,4));     assert(isLikeISBN(2383, 4));
//    system("pause");
  
    int Num, nDigit;
    bool canModify;
    char again;               // works with label_again;

label_again:

    Num = CreateRandom();     //   Num = 280129398; // 417065; //11404;

    nDigit = countDigit(Num);
    cout << "\n         Your number is " << Num <<". "
          << " It has " << nDigit << " digits and it";
    if (isLikeISBN(Num, nDigit))
        cout << " is like an ISBN.\n";
    else
        cout << " is Not like an ISBN.\n";


    if (!isLikeISBN(Num, nDigit)) {

        if ((Num % 10) > nDigit)
            cout << "         To be like an ISBN, the last digit "
                 << Num % 10 
                 << " should not bigger than "
                 << nDigit
                 << ", the number of digits.\n";
        else if (nDigit > 9)
            cout << "        This program can not handle"
                  <<" a number more than 9 digits.\n";
        else {
            cout << "        Try to modify each digit from d2 to dn-1"
                << " independently to make this number like an ISBN.\n";
            canModify = Modify(Num, nDigit, 2, nDigit - 1);
            if (!canModify) 
                cout << "\n        Cannot do that! ";
        }
    }

    cout << "\n\n          Do you want to try it again? (Y/N): ";
    cin >> again;
    if ((again == 'Y') || (again == 'y')) goto label_again;

//  ISBN_WIKI?
/*
9992158107	Qatar	NCCAH, Doha
9971502100	Singapore	World Scientific
9604250590	Greece	Sigma Publications
8090273416	Czech Republic; Slovakia	Taita Publishers
8535902775	Brazil	Companhia das Letras
1843560283	English-speaking area	Simon Wallenberg Press
0684843285	English-speaking area	Scribner
0851310419	English-speaking area	J. A. Allen & Co.
9386954214	English-speaking area	Edupedia Publications Pvt Ltd.
0943396042	English-speaking area	Willmann–Bell
*/
    return 0;

}
/**
  Create a random number with options
  @return a random number
*/
int CreateRandom()
{
    srand(static_cast<unsigned int>(time(NULL)));
    char option;
    cout << "\n\n\n                      User's Menu"
        << "\n\n          How do you want to generate a random number?"
        << "\n\n          A. A number in a range [X1,X2]."
        << "\n\n          B. A number of any length from 3 to 9."
        << "\n\n          (Ctrl+C anytime to terminate this program.)\n";
    do  {
        cout << "\n          Please enter A or B : ";
        cin.clear();
        cin >> option;
        option = toupper(option);
    
        if (option == 'A')
            return RandWithRAND_MAX();
        else if (option == 'B') {
            int max9 = 999999999;
            int min3 = 100;
            return min3 + int((max9 - min3) * (rand() * 1.0 / RAND_MAX));
        }
        else   // Without this else a warning will appear when compiling
            continue;
    } while (cin.fail() || (option != 'A') || (option != 'B')); 
}
/**
  Create a random number in a range within RAND_MAX
  @return a random number 
*/
int RandWithRAND_MAX()
{
    cout << "\n          You choose to get a random number in a range [X1,X2] \n";
    int rangeA, rangeB, min;
    rangeA = rangeB = 0;
    rangeA = readInt("          Enter a value of X1: ");
    rangeB = readInt("          Enter a value of X2: ");
    min = (rangeA < rangeB) ? rangeA : rangeB;
    if (abs(rangeB - rangeB) > RAND_MAX) {
        rangeA = min;
        rangeB = min + 32767;
    }
    int Num = rangeA + rand() % (rangeB - rangeA + 1);
//    cout << Num << " in [ " << rangeA << "," << rangeB << "]" << endl;
    return Num;
}
/**
   Read an integer with a promt message. This function will validate the input
   @param message: a message for reading Num
   @param Num: an integer input
   @return Num
*/
int readInt(string message)
{
    int Num;
    cout << message;
    cin >> Num;
    while (cin.fail()) {
        cout << "          Bad Input!!! Ctr+C to exit or try it again.\n";
        cin.clear();
        cin.ignore(80, '\n');
        cout << message;
        cin >> Num;
    }
    return Num;
}

/**
   Count the number of digits of an integer
   @param num the number need to count
   @return number of digits
*/
int countDigit(int num)
{
    int count = 0;
    while (num != 0) {
        num = num / 10;
        count = count + 1;
    }
    return count;
}

/**
   Tests if an integer Num with nDigit is like an ISBN: 
//     dn = (d1*1+d2*2+….+dn-1*(n-1)) % (n+1)
   @param Num any positive integer
   @param nDigit the number of digits of Num
   @return true iff Num is like an ISBN
*/
bool isLikeISBN(int Num, int nDigit)
{
    int dn = Num % 10; // Last digit of Num
    if (dn > nDigit) return false;

    Num = Num / 10;     // = d1d2..dn-1
    int wi = nDigit;
    int di, sum = 0;    // sum will be  (d1*1+d2*2+….+dn-1*(n-1)) 
    while (Num != 0) {
        di = Num % 10;
        wi = wi - 1;
        sum = sum + di * wi;    //  cout <<" di="<<di << " wi=" << wi << " sum=" << sum <<endl;
        Num = Num / 10;
    }                           //  cout << "sum= " << sum << endl;
    int n1 = nDigit + 1;
    return (dn == (sum % n1));
}
/**
Returns ISBN error syndrome, true for a valid ISBN, false for an invalid one.
(d1*10 +d2*9+d3*8+d4*7+d5*6+d6*5+d7*4+d8*3+d9*2+d10*1) % 11 = 0
*/
bool isISBN_Wiki1(int Num, int nDigit)
{
    int di, wi = 1;
    int sum = 0;

    while (Num != 0) {
        di = Num % 10;
        sum += di * wi;
        wi++;
        Num = Num / 10;
    }
    cout << "sum= " << sum << endl;
    return (sum % (nDigit + 1));
}

/**
   Try to modify each digit from d2 to dn-1 so a number d1d2..dn is like an ISBN
   @param Num a positive integer is expressed as d1d2d3..dn-1dn
   @param nDigit the number of digits of Num
   @param istart the starting index for modification, istart < iend
   @param iend the endding index for modification, iend <= nDigit
   @return void
*/
bool Modify(int Num, int nDigit, int istart, int iend)
{
    bool canModify = false;
    if ((istart > iend) || (iend > nDigit)) return canModify;

    int head, di, tail, new_di, newNum;
    int di_unit = (int)pow(10., nDigit - istart);

    for (int i = istart; i <= iend; i++) {
        head = Num / (di_unit * 10) * di_unit * 10;
        tail = Num % di_unit;
        di = (Num - head - tail) / di_unit;
//        cout << " " << head << " + " << di*di_unit << " + " << tail << endl;        cout << "\n";
        for (new_di = 0; new_di < 10; new_di++) {
            if (new_di != di) {
                newNum = head + new_di * di_unit + tail;
//                cout << " " << newNum << " isISBN " << isLikeISBN(newNum, nDigit) << endl;
                if (isLikeISBN(newNum, nDigit)) {
                    cout << "            " << newNum << " is like an ISBN.\n";
                    canModify = true;
                }                  
            }
        }
        di_unit = di_unit / 10;
    }
    return canModify;
}