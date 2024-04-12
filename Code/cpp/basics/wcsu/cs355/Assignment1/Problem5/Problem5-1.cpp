// Alexander Luna | Assignment 1 | Problem5-1.cpp
#include <iostream>
using namespace std;

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

int fun(int* a) {
    *a = 3;
    return 5;
}

int main() {
    int result = func1() + 2 - 3 + func1();
    cout << "Case 1: \n 1 + 2 - 3 + 1 = " << result << "\n\n";

    result = func4() - 1 * func2();
    cout << "Case 2: \n 4 - 1 * 2 = " << result << "\n\n";

    result = 1 + 6 / func3();
    cout << "Case 3: \n 1 + 6 / 3 = " << result << "\n\n";

    result = 2 - -func2();
    cout << "Case 4: \n 2 - (-2) = " << result << "\n\n";

    result = func3() / (func2() + func1()) + func4();
    cout << "Case 5: \n 3 / (1 + 2) = " << result << "\n" << endl;

    result = (func4() - func2()) * func3();
    cout << "Case 6: \n (4 - 2) * 3 = " << result << "\n\n";

    result = func1() - -func2() * func3();
    cout << "Case 7: \n 1 - -2 * 3 = " << result << "\n\n";

    int a = 10;
    result = a + fun(&a);
    cout << "Case 8: \n a + fun(&a) = " << result << "\n\n";

    int b = 2;
    result = func3() * ++b;
    cout << "Case 9: \n 3 * ++2 = " << result << "\n\n";

    int c = 3;
    bool answer = (5 > func1() + 2 || 4 == --c + 2) && 3 != 3 % 1;
    cout << "Case 10: \n (5 > 1 + 2 || 4 == --c + 2) && 3 != 3 % 1 => " << answer << "\n";

    return 0;
}