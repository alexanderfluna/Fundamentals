#ifndef STUDENT_H
#define STUDENT_H
#include <string>
using namespace std;

class Student
{
public:
    /**
        Constructor to initialize variables
    */
    Student();
    /**
        Reads student's name and sequence of scores
    */
    void read();
    /**
        Adds a new score for the student
    */
    void addScore(double score);
    /**
        @return student's name
    */
    string getName() const;
    /**
        @return student's letter grade
    */
    string getGrade() const;
    /**
        Overloads the stream insertion operator
    */
    friend ostream& operator<< (ostream& out, Student *dynArr);
    /*
        Returns student's score
    */
    double getScore() const;
public:
    string name;
    int scoreAmount;
    double score;
    double scoreTotal;
};

#endif