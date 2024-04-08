#include <iostream>
using namespace std;

int main()
{
    int choice;
	while (true){
		cout << "\n                        Zoo Worksheet Menu"
			<< "\n\n          1. Clean parrot cage    4. Play with tigers"
			<< "\n\n          2. Feed aardvark        5. Hospital treatment"
			<< "\n\n                           9. Exit";
		cout << "\n\n          Please enter your choice: ";
		cin >> choice;

		switch (choice)
		{
		case 1:
			// statements for parrot worksheet
			cout << "\nMore flaming parrot droppings!\n\n";
			break;
		case 2:
			// statements for aardvark worksheet
			cout << "\nDid you know they ate termites?\n\n";
			break;
		case 4:
			// statements for tiger worksheet
			cout << "\nAaargh!!\n";
			//break;
		case 5:
			// statements for hospital worksheet
			cout << "\nDo you have current insurance?\n\n";
			break;
		case 9:
			break;
		default:
			cout << "\nPlease enter a valid choice\n\n";
		}
	}
   
}
