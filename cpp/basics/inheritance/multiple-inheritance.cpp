//Multiple Inheritance is a feature of C++ where a class can 
// inherit from more than one class. i.e one subclass is inherited
// from more than one base class.

#include <iostream>
#include <string.h>
using namespace std;

class Car {
    public:
    string make;
    string model;
    int fuelAmount;
    int capacity;
    Car() {}
    void set_v(string, string, int, int);
};

void Car::set_v(string m1, string m2, int f, int c) {
    make = m1;
    model = m2;
    fuelAmount = f;
    capacity = c;
}

// Inheritance
class Sedan: public Car {
    public:
    Sedan() {}
    void set_s(string, string, int, int);
};

void Sedan::set_s(string m1, string m2, int f, int c) {
    set_v(m1,m2,f,c);
}

class Truck: public Car {
    public:
    Truck() {}
    void set_t(string, string, int, int);
};

void Truck::set_t(string m1, string m2, int f, int c) {
    set_v(m1,m2,f,c);
}


int main() {
    Sedan a;
    a.set_s("Honda", "Accord", 11, 5);
    cout << "My first sedan holds " << a.fuelAmount << " gallons" << endl;

    Truck b;
    b.set_t("Ford", "F-150", 13, 5);
    cout << "The make of my truck is a " << b.make << endl;
}

