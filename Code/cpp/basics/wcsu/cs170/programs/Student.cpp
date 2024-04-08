#include <iostream>
#include "Student.h"
using namespace std;
Student::Student(int aNumber, char aName[], char aMajor[], Date aDate)
    : birthDate(aDate.getYear(), aDate.getMonth(), aDate.getDay()){
	idNumber = aNumber;
	strcpy(name, aName);
	strcpy(major,aMajor);
}

void Student::setIdNumber(const int aNumber){
	idNumber = aNumber;
}
void Student::setMajor(const char aMajor[]){
	strcpy(major, aMajor);
}

int Student::getIdNumber() const{
	return idNumber;
}

char* Student::getName()const {
	// return a copy of the string
	// to preserve encapsulation
	char * theName = new char[30];
	strcpy(theName, name);
	return theName;
}

char * Student::getMajor() const {
	// return a copy of the string
	// to preserve encapsulation
	char * theMajor = new char[15];
	strcpy(theMajor, major);
	return theMajor;
}

Date Student::getBirthDate() const{
	// return a copy to preserve encapsulation
	// either make the copy on the stack
	Date theDate(birthDate.getYear(),birthDate.getMonth(), birthDate.getDay());
	return theDate; // this is safe, a copy of the local variable is returned	
}

bool Student::hasSameMajorAs(const Student other) const{
	return !strcmp(major,other.getMajor());
}

void Student::print(){
	cout << "Student{id=" << idNumber
		<< ", name=" << name << ", major=" << major
		<< ", birth date=" << birthDate.getMonth() << "/"
		<< birthDate.getDay() << "/" << birthDate.getYear() << "}";		
}
