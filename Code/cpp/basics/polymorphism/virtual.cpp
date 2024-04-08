/* This type of polymorphism is achieved by Function Overriding:
Function overriding occurs when a derived class has a definition
for one of the member functions of the base class. That base
function is said to be overridden. */

#include <iostream>
using namespace std;

class base {
    public:
        virtual void print() { cout << "Print base class" << endl; }
        
        void show() { cout << "Show base class" << endl; }
};

class derived: public base {
    public:
        /* print() is already a virtual function in derived class,
        we could also declare a virtual void print() explicitly */
        void print() { cout << "Print derived class" << endl; }

        void show() { cout << "Show derived class" << endl; }
};

int main(){
    base *bptr;
    derived d;
    bptr = &d;

    // virtual function, binded at runtime (runtime polymorphism)
    bptr->print();

    // non-virtual function, binded at compile time
    bptr->show();
    
    cout << "Good" << endl;
}