#include <iostream>
using namespace std;

bool askUser();
void deleteFiles(bool);

int main()
{
    bool permissionGiven = askUser();
}

bool askUser()
{
    char response;
    do
    {
        cout << "Delete all files? (Y/N) ";
        cin >> response;
        switch (response)
        {
            case 'Y':
            case 'y':
                return true;
            case 'N':
            case 'n':
                return false;
            default: cout <<
                "Please answer Y or N." << endl;
        }
    } while (true);
}

void deleteFiles (bool allowed)
{
    if (allowed)
        cout << "All files deleted." << endl;
    else
        cout << "No files deleted." << endl;
}