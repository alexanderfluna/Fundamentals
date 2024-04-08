// Alexander Luna | Assignment 1 | Problem5-1.cpp
#include <iostream>
using namespace std;

int functionCallCount = 0;

double func1() {
    cout << "Function 1 is called." << endl;
    functionCallCount++;
    return 1;
}

double func2() {
    cout << "Function 2 is called." << endl;
    functionCallCount++;
    return 2;
}

double func3() {
    cout << "Function 3 is called." << endl;
    functionCallCount++;
    return 3;
}

double func4() {
    cout << "Function 4 is called." << endl;
    functionCallCount++;
    return 4;
}

int main() {
    // Case 1
    double result = 1 + func2();
    cout << "1 + 2 = " << result << "\n" << endl;

    // Case 2
    result = 2 - func1();
    cout << "2 - 1 = " << result << "\n" << endl;

    // Case 3
    result = 3 * func4();
    cout << "3 * 4 = " << result << "\n" << endl;
    
    // Case 4
    result = 4 / func3();
    cout << "4 / 3 = " << result << "\n" << endl;

    // Case 5
    result = func1() + func2() * func3();
    cout << "1 + 2 * 3 = " << result << "\n" << endl;

    // Case 6
    result = (func1() + func2()) * func3();
    cout << "(1 + 2) * 3 = " << result << "\n" << endl;

    // Case 7
    result = func3() / func3();
    cout << "3 / 3 = " << result << "\n" << endl;

    // Case 8
    result = func1() / func4();
    cout << "1 / 4 = " << result << "\n" << endl;

    // Case 9
    result = func1() * func2() / func3();
    cout << "1 * 2 / 3 = " << result << "\n" << endl;

    // Case 10
    result =  func3() / (func1() - func2());
    cout << "3 / (1 - 2) = " << result << "\n" << endl;

    cout << "functionCallCount: " << functionCallCount << endl;

    return 0;
}

/*
               a = 10;
         b = a + fun(a); // a passed by reference 
         //Assume that fun changes its parameter
*/