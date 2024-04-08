#include <iostream>
using namespace std;
int main()
{
	cout << "cout.eof(): " << cout.eof() << endl;
	cout << "cin.eof(): " << cin.eof() << endl;
	cout << "cout.fail(): " << cout.fail() << endl;
	cout << "cin.fail(): " << cin.fail() << endl;
	cout << "cout.bad(): " << cout.bad() << endl;
	cout << "cin.bad(): " << cin.bad() << endl;
	cout << "cout.good(): " << cout.good() << endl;
	cout << "cin.good(): " << cin.good() << endl;
	cout << "cout.rdstate(): " << cout.rdstate() << endl;
	cout << "cin.rdstate(): " << cin.rdstate() << "\n\n";

	int grade = 0;        // one grade       
   
	cout << "Enter grade, ^Z to end: ";    
	cin >> grade;     
	while ( (!cin.eof()) && (!cin.good() || grade < 0 || grade > 100)) {
		//cout << "  cout.eof(): " << cout.eof() << endl;
		cout << "  cin.eof(): " << cin.eof() << endl;
		//cout << "  cout.fail(): " << cout.fail() << endl;
		cout << "  cin.fail(): " << cin.fail() << endl;
		//cout << "  cout.bad(): " << cout.bad() << endl;
		cout << "  cin.bad(): " << cin.bad() << endl;
		//cout << "  cout.good(): " << cout.good() << endl;
		cout << "  cin.good(): " << cin.good() << endl;
		//cout << "  cout.rdstate(): " << cout.rdstate() << endl;
		cout << "  cin.rdstate(): " << cin.rdstate() << "\n\n";
		cout << " Bad input.\n";
		cin.clear();
		if(cin.eof()) break;
		cin.ignore(80,'\n');
		cout << " Try again: ";
		cin >> grade;
	}
	
	cout<< "\ngrade is " << grade << "\n\n";
	
	cout << "cout.eof(): " << cout.eof() << endl;
	cout << "cin.eof(): " << cin.eof() << endl;
	cout << "cout.fail(): " << cout.fail() << endl;
	cout << "cin.fail(): " << cin.fail() << endl;
	cout << "cout.bad(): " << cout.bad() << endl;
	cout << "cin.bad(): " << cin.bad() << endl;
	cout << "cout.good(): " << cout.good() << endl;
	cout << "cin.good(): " << cin.good() << endl;
	cout << "cout.rdstate(): " << cout.rdstate() << endl;
	cout << "cin.rdstate(): " << cin.rdstate() << "\n\n";
}