// Alexander Luna | Assignment 1 | Problem5-2.cpp
#include <iostream>
using namespace System;

int functionCallCount = 0;

double func1() {
    Console::WriteLine("Function 1 is called.");
    functionCallCount++;
    return 1;
}

double func2() {
    Console::WriteLine("Function 2 is called.");
    functionCallCount++;
    return 2;
}

double func3() {
    Console::WriteLine("Function 3 is called.");
    functionCallCount++;
    return 3;
}

double func4() {
    Console::WriteLine("Function 4 is called.");
    functionCallCount++;
    return 4;
}

int main(array<System::String^>^ args) {
    // Case 1
    double result = 1 + func2();
    Console::WriteLine("1 + 2 = {0}\n", result);

    // Case 2
    result = 2 - func1();
    Console::WriteLine("2 - 1 = {0}\n", result);

    // Case 3
    result = 3 * func4();
    Console::WriteLine("3 * 4 = {0}\n", result);

    // Case 4
    result = 4 / func3();
    Console::WriteLine("4 / 3 = {0}\n", result);

    // Case 5
    result = func1() + func2() * func3();
    Console::WriteLine("1 + 2 * 3 = {0}\n", result);

    // Case 6
    result = (func1() + func2()) * func3();
    Console::WriteLine("(1 + 2) * 3 = {0}\n", result);

    // Case 7
    result = func3() / func3();
    Console::WriteLine("3 / 3 = {0}\n", result);

    // Case 8
    result = func1() / func4();
    Console::WriteLine("1 / 4 = {0}\n", result);

    // Case 9
    result = func1() * func2() / func3();
    Console::WriteLine("1 * 2 / 3 = {0}\n", result);

    // Case 10
    result = func3() / (func1() - func2());
    Console::WriteLine("3 / (1 - 2) = {0}\n", result);

    Console::WriteLine("functionCallCount: {0}", functionCallCount);

    return 0;
}
