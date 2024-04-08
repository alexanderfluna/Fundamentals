#include <iostream>
using namespace std;

void userPrompt();

int main(){
    userPrompt();
}

void userPrompt() {

    while (true) {
        char input = ' ';

        cout << "Delete all files (Y/N)? " << endl;
        cin >> input;

        if (input == 'Y' || input == 'y') {
            cout << "Files deleted" << endl;
            break;
        }
        else if (input == 'N' || input == 'n') {
            cout << "No files deleted" << endl;
            break;
        }
        else {
            cout << "Please answer Y or N" << endl;
            continue;
        }
    }
}