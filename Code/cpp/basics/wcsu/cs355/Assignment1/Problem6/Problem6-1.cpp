// Alexander Luna | Assignment 1 | Problem 6-1.cpp
#include <iostream>
#include <math.h>
using namespace std;

int func1() {
    cout << "func1()" << endl;
    return 1;
}

int func2() {
    cout << "func2()" << endl;
    return 2;
}

int func3() {
    cout << "func3()" << endl;
    return 3;
}

int func4() {
    cout << "func4()" << endl;
    return 4;
}

void myFunc(int a, int b) {
    cout << "The first argument is: " << a << endl;
    cout << "The second argument is: " << b << endl;

}

void myFunc(int a, int b, int c, int d){
    cout << "The first argument is: " << a << endl;
    cout << "The second argument is: " << b << endl;
    cout << "The third argument is: " << c << endl;
    cout << "The fourth argument is: " << d << endl;
}



int main() {
    // Case 1
    cout << "Case 1: myFunc(x++, x++, x++)" << endl;
    int x = 1;
    cout << "The value of x before the function call: " << x << endl;
    myFunc(x++, x++, x++, x++);
    cout << "The value of x after the function call: " << x << endl;

    // Case 2
    cout << "\nCase 2: myFunc(func1(), func2(), func3())" << endl;
    myFunc(func1(), func2(), func3(), func4());

    // Case 3
    cout << "\nCase 3: myFunc(func2() + func1(), func4() - func2()))" << endl;
    myFunc(func2() + func1(), func4() - func2());

    // Case 4
    cout << "\nCase 4: myFunc(func4() - func3() * func2(), (func1() + func2()) / func3())" << endl;
    myFunc(func4() - func3() * func2(), (func1() + func2()) / func3());

    return 0;
}