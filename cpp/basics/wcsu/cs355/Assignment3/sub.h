// Alexander Luna | Assignment 3 | sub.h
// This file contains the structure of the Sub class.
#pragma once
#include <iostream>
#include <vector>
#include <string>

class Sub
{
public:
    Sub(std::string _name, Sub* _parent, int _numArgs, int _numLocals);

    void printRuntimeStack(); // Prints the runtimeStack

    void printDisplay();  // Prints the display

    bool isVisible(); // Returns true if the sub is visible to the top sub on the stack, otherwise returns false

    // Method call_ will check if this sub's name is visible from the subprogram with the activation record 
    // currently at the top of the runtime stack, and if so, will place an activation record for the called 
    // subprogram as the new top of the runtime stack and will reflect this in the display. Otherwise this call is an error. 
    void call_();

    // Method return_ will remove the activation record of this subprogram from the runtime stack and will reflect this in the display.
    void return_();

private:
    std::string name;
    Sub* parent;
    std::vector<Sub*> children;
    int numArgs;
    int numLocals;
    int staticDepth;
    static std::vector<int> runtimeStack;
    static std::vector<int> display;
    static std::vector<int> nameEncodings;
    static std::vector<std::string> printStack;
};
