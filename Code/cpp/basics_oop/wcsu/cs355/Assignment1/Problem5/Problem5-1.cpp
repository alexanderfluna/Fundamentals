#include <iostream>
using namespace std;

double functionCallCount = 0;

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
    double result1 = func1() + func2();
    cout << "1 + 2 = " << result1 << "\n" << endl;

    double result2 = func2() + func1();
    cout << "2 + 1 = " << result2 << "\n" << endl;


    double result3 = func3() * func4();
    cout << "3 * 4 = " << result3 << "\n" << endl;

    double result4 = func4() * func3();
    cout << "4 * 3 = " << result4 << "\n" << endl;


    double result5 = func1() + func2() * func3();
    cout << "1 + 2 * 3 = " << result5 << "\n" << endl;

    double result6 = (func1() + func2()) * func3();
    cout << "(1 + 2) * 3 = " << result6 << "\n" << endl;


    double result7 = func3() / func3();
    cout << "3 / 3 = " << result7 << "\n" << endl;

    double result8 = func1() / func4();
    cout << "1 / 4 = " << result8 << "\n" << endl;


    double result9 = func1() * func2() / func3();
    cout << "1 * 2 / 3 = " << result9 << "\n" << endl;

    double result10 = (func1() - func2()) / func3();
    cout << "(1 - 2) / 3 = " << result10 << "\n" << endl;

    cout << "functionCallCount: " << functionCallCount << "\n" << endl;

    return 0;
}
