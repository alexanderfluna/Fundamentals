#include <iostream>
using namespace std;

int reverseNum(int num);
bool findDigit(int num, int digit);

int main()
{
    int num, digit, reverse;
    bool digitFound;

    cout << "Type a number: ";
    cin >> num;

    cout << "What digit would you like to search for? ";
    cin >> digit;

    reverse = reverseNum(num);
    digitFound = findDigit(num, digit);
}

int reverseNum(int num)
{
    int digit, reverse;
    while (num > 0)
    {
        digit = num % 10;
        reverse += digit;
        reverse *= 10;
        num /= 10;
    }
    return reverse
}