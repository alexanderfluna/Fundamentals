/* Compile-time polymorphism: This type of polmorphism
 is achieved by function overloading or operator overloading */

/* Function overloading: When there are multiple functions with
the same name but different parameters, then the functions are
said to be overloaded. Functions can be overloaded by changing
the number of arguments and/or changing th argument types. */

// C++ program for function overloading
#include <iostream>
using namespace std;

class Geeks {
    public:

    // function with 1 int parameter
    void func(int x) {
        cout << "The value of x is " << x << endl;
    }

    // function with same name but 1 double parameter
    void func(double x) {
        cout << "The value of x is " << x << endl;
    }

    // function with same name and 2 int parameters
    void func(int x, int y) {
        cout <<"The value of x and y is " << x << ", " << y << endl;
    }
}; 

int main(){

    Geeks obj1;

    // Which function is called will depend on the parameters passed
    // The first 'func' is called
    obj1.func(7);

    // The second 'func' is called
    obj1.func(9.132);

    // The third 'func' is called
    obj1.func(85, 64);

    cout << "Good" << endl;
}