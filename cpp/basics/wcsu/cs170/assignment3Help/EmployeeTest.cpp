#include <iostream>
#include <fstream>
#include "ccc_empl.h"
using namespace std;

void main(){
	Employee * empPtr = new Employee[3];
	ifstream theFile;
	char fileName[]="Employees.txt";
	theFile.open(fileName);
	if (!theFile)
    {
        cout << "Cannot open file - " << fileName << endl;
        exit(1);  
    }
	
	for (int i = 0; i < 3; i++){
		empPtr[i].readFromFile(theFile);      
		cout << empPtr[i].get_name() << " " << empPtr[i].get_salary() << endl;
	}	
	theFile.close();
	
}

