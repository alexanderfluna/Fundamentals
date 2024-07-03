/* Problem1_B.cpp | Assignment 3 | Alexander Luna | May 10, 2021
This program will copy a vector of Student objects into a dynamically
allocated array of Student variables. The vector will get populated
from reading a text file and the array will get printed out after copying
from the vector in a well-formatted table showing the names and the grades
of the students. */

#include <iostream>
#include <fstream>
#include <vector>
#include <iomanip>
#include "Student.h"
#include "Student.cpp"
using namespace std;

// HAS TO MATCH THE NUMBER OF STUDENTS IN STUDENT.TXT
const int SIZE = 10;

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

    // Copies vector into array & prints out array
    Student *dynArr = new Student[SIZE];
    cout << "Grade" << setw(16) << "Name" << endl;
    cout << "_________________________" << endl;
    for (int i = 0; i < SIZE; i++)
    {
        dynArr[i] = students[i];
        cout << dynArr[i].getGrade() << setw(20) << dynArr[i].getName() << endl;
        cout << "_________________________" << endl;
    }
}