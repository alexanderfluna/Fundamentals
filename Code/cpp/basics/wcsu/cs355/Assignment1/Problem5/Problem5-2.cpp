// Alexander Luna | Assignment 1 | Problem5-2.cpp (C++/CLI)
#include <iostream>
using namespace System;

int func1() {
    return 1;
}

int func2() {
    return 2;
}

int func3() {
    return 3;
}

int func4() {
    return 4;
}

int fun(int% a) {
    a = 3;
    return 5;
}

int main(array<System::String^>^ args) {
    int result = func1() + 2 - 3 + func1();
    Console::WriteLine("Case 1: \n 1 + 2 - 3 + 1 = {0}\n", result);

    result = func4() - 1 * func2();
    Console::WriteLine("Case 2: \n 4 - 1 * 2 = {0}\n", result);

    result = 1 + 6 / func3();
    Console::WriteLine("Case 3: \n 1 + 6 / 3 = {0}\n", result);

    result = 2 - -func2();
    Console::WriteLine("Case 4: \n 2 - (-2) = {0}\n", result);

    result = func3() / (func2() + func1()) + func4();
    Console::WriteLine("Case 5: \n 3 / (1 + 2) = {0}\n", result);

    result = (func4() - func2()) * func3();
    Console::WriteLine("Case 6: \n (4 - 2) * 3 = {0}\n", result);

    result = func1() - -func2() * func3();
    Console::WriteLine("Case 7: \n 1 - -2 * 3 = {0}\n", result);

    int a = 10;
    result = a + fun(a);
    Console::WriteLine("Case 8: \n a + fun(a) = {0}", result);
    Console::WriteLine(" After the exeuction of fun(a), the value of a is = {0}\n", a);

    int b = 2;
    result = func3() * ++b;
    Console::WriteLine("Case 9: \n 3 * ++2 = {0}\n", result);

    int c = 3;
    bool answer = (5 > func1() + 2 || 4 == --c + 2) && 3 != 3 % 1;
    Console::WriteLine("Case 10: \n (5 > 1 + 2 || 4 == --c + 2) && 3 != 3 % 1 => {0}", answer);

    return 0;
}
