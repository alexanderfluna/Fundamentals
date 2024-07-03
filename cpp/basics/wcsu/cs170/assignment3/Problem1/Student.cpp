#include <iostream>
#include "Student.h"
using namespace std;

Student::Student()
{
    name = " ";
    scoreAmount = 0;
    score = 0.0;
    scoreTotal = 0.0;
}

void Student::read()
{
    cout << "Enter the student's name: ";
    getline(cin, name);
    cout << "How many scores will you enter? ";
    cin >> scoreAmount;
    for (int i = 0; i < scoreAmount; i++)
    {
        cout << "Enter score #" << i+1 << ": ";
        cin >> score;
        addScore(score);
    }
    scoreTotal /= scoreAmount;
}

void Student::addScore(double score)
{
    scoreTotal += score;
}

string Student::getName() const
{
    return name;
}

string Student::getGrade() const
{
    if(scoreTotal >= 93)
        return "A";
    else if (scoreTotal >= 90)
        return "A-";
    else if (scoreTotal >= 87)
        return "B+";
    else if (scoreTotal >= 83)
        return "B";
    else if (scoreTotal >= 80)
        return "B-";
    else if (scoreTotal >= 77)
        return "C+";
    else if (scoreTotal >= 73)
        return "C";
    else if (scoreTotal >= 70)
        return "C-";
    else if (scoreTotal >= 67)
        return "D+";
    else if (scoreTotal >= 63)
        return "D";
    else if (scoreTotal >= 60)
        return "D-";
    else
        return "F";
}

double Student::getScore() const
{
    return scoreTotal;
}