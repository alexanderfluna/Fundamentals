/* Problem1_A.cpp | Assignment 3 | Alexander Luna | May 10, 2021
This program will prompt the user to enter in a student's name and
scores they have received. It will add the scores together and return
the student's name and current letter grade. */

#include <iostream>
#include <string>
#include "Student.h"
#include "Student.cpp"
using namespace std;

void display(Student student);

int main()
{
    cout << "This program will prompt the user to enter in a student's name and "
            "scores they have received. It will add the scores together and return "
            "the student's name and current letter grade.\n" << endl;

    Student student;
    student.read();
    display(student);
}

void display(Student student)
{
    cout << "The student's name is: " << student.getName() << " and their letter "
            "grade is: " << student.getGrade() << endl;
}