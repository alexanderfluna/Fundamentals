// In single inheritance, a class is allowed to inherit from only 
// one class. i.e. one subclass is inherited by one base class only.

#include <iostream>
#include <string.h>
using namespace std;

class Person
{
    public:
        void set_p(int, string);
        int id;
        string name;
};

void Person::set_p(int id, string n)
{
    this->id=id;
    name = n;
    
}

// Creates public derived class
class Student: public Person
{
    public:
        void set_s(int, string, string, int);
        string course;
        int fee;
};

void Student::set_s(int id, string n, string c, int f)
{
    set_p(id,n);
    course = c;
    fee = f;
}

int main()
{
    Student Alexander;

    Alexander.set_s(8, "Alexander", "Economics", 3500);
}