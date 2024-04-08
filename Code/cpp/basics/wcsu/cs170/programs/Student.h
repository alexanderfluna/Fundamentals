#ifndef STUDENT_H
#define STUDENT_H
#include "Date.h"
class Student{
public:
   Student (int idNumber, char name[], char major[], Date birthDate);
   void setIdNumber(const int aNumber);
   void setMajor(const char aMajor[]);
   int getIdNumber() const;
   char* getName()const;
   char* getMajor() const;
   Date getBirthDate() const;
   bool hasSameMajorAs(const Student other) const;
   void print();
private:
	int idNumber;
	char name[30];
	char major[15];
	Date birthDate;
};
#endif
