// IncomeTax.cpp
//
// This is an improved version of IncomeTax.cpp
// The program computes the new New Zealand 
// annual income tax given a person's annual salary, 
// announces the rates used, and validates the input 
//
// Income tax rates:
//    Income up to $38,000 - 19.5%
//    Income between $38,001 and $60,000 - 33%
//    Income over $60,000 - 39%


#include <iostream>
#include <iomanip>
using namespace std;

int main () {

    int income;
    double tax;
	const int LOW = 38000, MEDIUM = 60000;
	const double LOWRATE =.195, MEDRATE =.33, HIGHRATE =.39;
	//while (true){
		cout << "Enter annual income: $";
		cin >> income;
		while (!cin.good()) {

			cout << " Bad input. \n";
			cin.clear();
			cin.ignore(80, '\n');
			cout << " Try again: ";
			cin >> income;
		}
		if (income <= LOW) {
			tax = income * LOWRATE;
			cout << "Income taxed at " << LOWRATE * 100 << "%.\n";
		}
		else {
			cout << "Income to $" << LOW << " taxed at " << LOWRATE * 100 << "%.\n";
			if (income <= MEDIUM) {
				tax = LOW* LOWRATE + (income - LOW) * MEDRATE;
				cout << "The rest of income taxed at " << MEDRATE * 100 << "%\n";
			} // if
			else {
				tax = LOW * LOWRATE
					+ (MEDIUM - LOW) * MEDRATE
					+ (income - MEDIUM) * HIGHRATE;
				cout << "Income between $" << LOW << " and $"
					<< MEDIUM << " taxed at " << MEDRATE * 100 << "%.\n";
				cout << "The rest of income taxed at " << HIGHRATE * 100 << "%\n";
			} // else
		} // else
		cout << "Income tax = $" << setiosflags(ios::fixed)
			<< setprecision(2) << tax << endl;
	//}
    
}