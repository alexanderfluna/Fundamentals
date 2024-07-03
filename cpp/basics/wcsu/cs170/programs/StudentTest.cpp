#include <iostream>
#include "Student.h"
using namespace std;

int main()
{
    // Student student; No default constructor
	Student st1(111111,"Peter","Computer Science",Date(1995,1,1));
	Student st2(222222,"John","Computer Science",Date(1996,2,2));
	if (st1.hasSameMajorAs(st2)){
		cout << "These students have the same major: " << endl;
		st1.print();
		cout << endl << "     and" << endl;
		st2.print();
		cout << endl;
	}
   
   return 0;
}
