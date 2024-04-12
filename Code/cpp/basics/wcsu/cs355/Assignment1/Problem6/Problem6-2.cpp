// Alexander Luna | Assigment 1 | Problem6-2.cpp
#include <iostream>
#include <cmath>

using namespace System;

int func1() {
    Console::WriteLine("func1()");
    return 1;
}

int func2() {
    Console::WriteLine("func2()");
    return 2;
}

int func3() {
    Console::WriteLine("func3()");
    return 3;
}

int func4() {
    Console::WriteLine("func4()");
    return 4;
}

void myFunc(int a, int b) {
    Console::WriteLine("The first argument is: " + a);
    Console::WriteLine("The second argument is: " + b);
}

void myFunc(int a, int b, int c, int d) {
    Console::WriteLine("The first argument is: " + a);
    Console::WriteLine("The second argument is: " + b);
    Console::WriteLine("The third argument is: " + c);
    Console::WriteLine("The fourth argument is: " + d);
}

int main(array<String^>^ args) {
    // Case 1
    Console::WriteLine("Case 1: myFunc(x++, x++, x++)");
    int x = 1;
    Console::WriteLine("The value of x before the function call: " + x);
    myFunc(x++, x++, x++, x++);
    Console::WriteLine("The value of x after the function call: " + x);

    // Case 2
    Console::WriteLine("\nCase 2: myFunc(func1(), func2(), func3())");
    myFunc(func1(), func2(), func3(), func4());

    // Case 3
    Console::WriteLine("\nCase 3: myFunc(func2() + func1(), func4() - func2())");
    myFunc(func2() + func1(), func4() - func2());

    // Case 4
    Console::WriteLine("\nCase 4: myFunc(func4() - func3() * func2(), (func1() + func2()) / func3())");
    myFunc(func4() - func3() * func2(), (func1() + func2()) / func3());

    return 0;
}
