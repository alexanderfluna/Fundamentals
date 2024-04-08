// Alexander Luna
#include <iostream>
#include <string.h>
using namespace std;

void reverse(string str);

int main()
{
    string sentence, firstHalf, secondHalf;
    cout << "Type in a sentence: ";
    getline(cin, sentence);
    firstHalf = sentence.substr(0,sentence.length()/2);
    secondHalf = sentence.substr(sentence.length()/2);
    cout << "Your reversed sentence is: ";
    reverse(secondHalf);
    reverse(firstHalf);
    cout << "\n";
}

void reverse(string str)
{
    if (str.size() == 0)
    {
        return;
    }
    else
    {
        cout << str[str.size()-1];
        reverse(str.substr(0, str.size()-1));
    }

    
}