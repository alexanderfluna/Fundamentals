/* Problem1_C.cpp | Assignment 3 | Alexander Luna | May 10, 2021
This program will overload the stream insertion operator << so that it can be
used with the Student class and use the overloaded stream insertion operator
to print the array on the screen. */

#include <iostream>
#include <fstream>
#include <vector>
#include <string>
#include <iomanip>
#include "Student.h"
#include "Student.cpp"
using namespace std;

// HAS TO MATCH THE NUMBER OF STUDENTS IN STUDENT.TXT
const int SIZE = 10;

ostream& operator<< (ostream& out, Student *dynArr)
{
    for (int i = 0; i < SIZE; i++)
        out << dynArr[i].getName() << " " << dynArr[i].getScore() << endl;
    return out;
}

int main()
{
    vector<Student> students;
    Student student;
    char fileName[]="student.txt";
    
    // Opens file
    ifstream theFile;
    theFile.open(fileName);
    if (!theFile)
    {
        cout << "Cannot open file: " << fileName << endl;
        exit(1);
    }

    // Stores values in vector
    for (int i = 0; i < SIZE; i++)
    {
        theFile >> student.name;
        theFile >> student.scoreTotal;
        students.push_back(student);
    }
    theFile.close();

    // Copies vector into dynamically allocated array & prints out array
    Student *dynArr = new Student[SIZE];
    for (int i = 0; i < SIZE; i++)
    {
        dynArr[i] = students[i];
    }

    cout << dynArr;
}