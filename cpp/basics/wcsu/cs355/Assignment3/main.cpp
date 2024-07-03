// Alexandwer Luna | Assignment 3 | main.cpp
// This file contains multiple tests for the Sub class.
#include "sub.h"

int main()
{
    // Declare Sub objects
    Sub main_("main_", nullptr, 0, 1);  // static depth 0
    Sub bigsub("BIGSUB", &main_, 1, 0); // static depth 1
    Sub sub1("SUB1", &bigsub, 1, 2);    // static depth 2
    Sub sub2("SUB2", &bigsub, 2, 1);    // static depth 2
    Sub sub3("SUB3", &sub2, 3, 3);      // static depth 3

    // Provide a sufficient number of suitable calls of their call_ and return_ methods to demonstrate in full the rules of static scoping visibility

    
    // Test 1: (main_ must be called first)
    std::cout << "TEST 1" << std::endl;
    bigsub.call_(); //error
    sub1.call_(); //error
    sub2.call_(); //error
    sub3.call_(); //error



    // Test 2: (Out of scope)
    std::cout << "\n\n\n==============================================================================================================\n\n\n\nTEST 2\n"; 
    main_.call_(); std::cout << "\n_________________________________________________\n";
    sub1.call_(); //error
    sub2.call_(); //error
    sub3.call_(); std::cout << "\n_________________________________________________\n"; //error
    

    bigsub.call_(); std::cout << "\n_________________________________________________\n";
    sub3.call_(); std::cout << "\n_________________________________________________\n"; //error

    bigsub.return_(); std::cout << "\n_________________________________________________\n";
    main_.return_();



    // Test 3: (Returning when the sub is not on top of the stack)
    std::cout << "\n\n\n==============================================================================================================\n\n\n\nTEST 3\n";
    main_.return_(); std::cout << "\n_________________________________________________\n"; //error

    main_.call_(); std::cout << "\n_________________________________________________\n";
    bigsub.call_(); std::cout << "\n_________________________________________________\n";
    sub1.call_(); std::cout << "\n_________________________________________________\n";

    bigsub.return_(); std::cout << "\n_________________________________________________\n"; //error
    sub1.return_(); std::cout << "\n_________________________________________________\n";
    bigsub.return_(); std::cout << "\n_________________________________________________\n";
    main_.return_();



    // Test 4: (Case 1 Equal static depths: Sub2 calls Sub1)
    std::cout << "\n\n\n==============================================================================================================\n\n\n\nTEST 4\n";
    main_.call_(); std::cout << "\n_________________________________________________\n";
    bigsub.call_(); std::cout << "\n_________________________________________________\n";
    sub2.call_(); std::cout << "\n_________________________________________________\n";
    sub1.call_(); std::cout << "\n_________________________________________________\n";

    sub1.return_(); std::cout << "\n_________________________________________________\n";
    sub2.return_(); std::cout << "\n_________________________________________________\n";
    bigsub.return_(); std::cout << "\n_________________________________________________\n";
    main_.return_();



    // Test 5 (Case 2 Caller has lower static depth: Sub2 calls Sub3)
    std::cout << "\n\n\n==============================================================================================================\n\n\n\nTEST 5\n";
    main_.call_(); std::cout << "\n_________________________________________________\n";
    bigsub.call_(); std::cout << "\n_________________________________________________\n";
    sub2.call_(); std::cout << "\n_________________________________________________\n";
    sub3.call_(); std::cout << "\n_________________________________________________\n";

    sub3.return_(); std::cout << "\n_________________________________________________\n";
    sub2.return_(); std::cout << "\n_________________________________________________\n";
    bigsub.return_(); std::cout << "\n_________________________________________________\n";
    main_.return_();



    // Test 6 (Caller has higher static depth: Sub3 calls Sub1)
    std::cout << "\n\n\n==============================================================================================================\n\n\n\nTEST 6\n";
    main_.call_(); std::cout << "\n_________________________________________________\n";
    bigsub.call_(); std::cout << "\n_________________________________________________\n";
    sub2.call_(); std::cout << "\n_________________________________________________\n";
    sub3.call_(); std::cout << "\n_________________________________________________\n";
    sub1.call_(); std::cout << "\n_________________________________________________\n";

    sub1.return_(); std::cout << "\n_________________________________________________\n";
    sub3.return_(); std::cout << "\n_________________________________________________\n";
    sub2.return_(); std::cout << "\n_________________________________________________\n";
    bigsub.return_(); std::cout << "\n_________________________________________________\n";
    main_.return_();
}
