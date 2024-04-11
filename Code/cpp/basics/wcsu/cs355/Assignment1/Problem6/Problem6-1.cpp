#include <iostream>

// Experiment 1: Simple function with post-increment
void printValues(int a, int b, int c) {
    std::cout << "Experiment 1 - Simple function with post-increment" << std::endl;
    std::cout << "Argument a: " << a << std::endl;
    std::cout << "Argument b: " << b << std::endl;
    std::cout << "Argument c: " << c << std::endl;
}

// Experiment 2: Reversed order of evaluation
void printValuesReversed(int a, int b, int c) {
    std::cout << "Experiment 2 - Reversed order of evaluation" << std::endl;
    std::cout << "Argument a: " << a << std::endl;
    std::cout << "Argument b: " << b << std::endl;
    std::cout << "Argument c: " << c << std::endl;
}

// Experiment 3: Nested function calls
void printNestedValues(int a, int b, int c) {
    std::cout << "Experiment 3 - Nested function calls" << std::endl;
    std::cout << "Argument a: " << a << std::endl;
    std::cout << "Argument b: " << b << std::endl;
    std::cout << "Argument c: " << c << std::endl;
}

// Experiment 4: Parameters result of addition, subtraction, multiplication, and division
void printArithmeticValues(int a, int b, int c) {
    std::cout << "Experiment 4 - Parameters result of arithmetic operations" << std::endl;
    std::cout << "Argument a: " << a << std::endl;
    std::cout << "Argument b: " << b << std::endl;
    std::cout << "Argument c: " << c << std::endl;
}

int getValue() {
    static int value = 0;
    return ++value;
}

int main() {
    // Experiment 1: Simple function with post-increment
    int x1 = 1;
    int y1 = 2;
    int z1 = 3;
    printValues(x1++, y1++, z1++);
    std::cout << std::endl;

    // Experiment 2: Reversed order of evaluation
    int x2 = 1;
    int y2 = 2;
    int z2 = 3;
    printValuesReversed(z2++, y2++, x2++);
    std::cout << std::endl;

    // Experiment 3: Nested function calls
    printNestedValues(getValue(), getValue(), getValue());
    std::cout << std::endl;

    // Experiment 4: Parameters result of arithmetic operations
    int x4 = 1;
    int y4 = 2;
    int z4 = 3;
    printArithmeticValues(x4 + 1, y4 - 2, z4 * 3);
    std::cout << std::endl;

    return 0;
}

/*
// Alexander Luna | Assignment 1 | Problem 6-1.cpp
#include <iostream>
#include <math.h>
using namespace std;

void myFunc(double a) {
    cout << "The argument is: " << a << endl;
}

void myFunc(double a, double b, double c){
    cout << "The first argument is: " << a << endl;
    cout << "The second argument is: " << b << endl;
    cout << "The third argument is: " << c << endl;
}

int main() {
    // Case 1
    cout << "" << endl;
    myFunc(2 + 3 * 4);

    // Case 2
    cout << "" << endl;
    myFunc( sqrt(4 * 2) );

    // Case 3
    cout << "" << endl;
    myFunc(3.0 / 4.0, 5.5 * 2.0);

    // Case 4
    cout << "" << endl;
    myFunc(3.0 / 4.0, 5.5 * 2.0);

    // Case 5
    cout << "" << endl;
    myFunc();

    // Case 6
    cout << "" << endl;
    myFunc();

    // Case 7
    cout << "" << endl;
    myFunc();

    // Case 8
    cout << "" << endl;
    myFunc();

    // Case 9
    cout << "" << endl;
    myFunc( ( (1 + 2) * 3) / (4 - 1) );

    // Case 10
    cout << "Case 10: myFunc(x++, x++, x++)" << endl;
    double x = 1;
    cout << "The value of x before the function call: " << x << endl;
    myFunc(x++, x++, x++);
    cout << "The value of after the function call: " << x << endl;

    return 0;
}


*/