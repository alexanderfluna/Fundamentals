// Alexander Luna | Assignment 3 | sub.cpp
// This file contains the implementation of Sub's methods.
#include "sub.h"

Sub::Sub(std::string _name, Sub* _parent, int _numArgs, int _numLocals) :
    name(_name), parent(_parent), numArgs(_numArgs), numLocals(_numLocals) // Initialize fields
{
    // Initialize staticDepth
    staticDepth = (parent == nullptr) ? 0 : parent->staticDepth + 1;

    // If sub isn't main_, add this object to its parent's children
    if (parent != nullptr)
        parent->children.push_back(this);
}

void Sub::printRuntimeStack()
{
    for (int i = printStack.size() - 1; i >= 0; i--)
        std::cout << i << ": " << printStack[i] << std::endl;
}

void Sub::printDisplay()
{
    for (int i = display.size() - 1; i >= 0; i--)
        std::cout << i << ": Index " << display[i] << std::endl;
}

bool Sub::isVisible()
{
    // A Sub object with name main_ is always the first called
    if (runtimeStack.empty() && name == "main_")
    {
        display.push_back(0);
        return true;
    }

    // If main_ is on the stack, check the called sub's visibility
    else if (!runtimeStack.empty())
    {
        int topSubIndex = 0; // First, get the index of the top sub on the stack

        // If we have the same # of blocks in the display as we do subprograms 
        // on the stack, iterate down the display to get the index of the top sub
        if (display.size() == nameEncodings.size()) 
        {
            int max = 0;
            for (int i = display.size() - 1; i > 0; i--)
            {
                max = display[i];
                if (max > topSubIndex)
                    topSubIndex = max;
            }
        }
        // Else, iterate down the stack and nameEncoding vectors to get the index of the top sub
        else 
        {
            for (int i = runtimeStack.size() - 3; i > 0; i--)
            {
                for (int j = nameEncodings.size() - 1; j > 0; j--)
                {
                    if (runtimeStack[i] == nameEncodings[j])
                    {
                        topSubIndex = i;
                        break;
                    }
                }
                if (topSubIndex > 0)
                    break;
            }
        }
        
        // If the top sub is the parent of the called sub (Case 1: Caller has a lower static depth)
        if (runtimeStack[topSubIndex] == (int)&parent->name)
        {
            // Add a block in the display that will point to the index of the called sub
            display.push_back(runtimeStack.size());
            return true;
        }
        else
        {
            int topSubName = runtimeStack[topSubIndex]; // Store the encoded name of the top sub

            for (int i = 0; i < parent->children.size(); i++)  // Look through each of the siblings of the called sub
            {
                if (topSubName == (int)&parent->children[i]->name) // If the top sub is a sibling of the called sub (Case 2: Caller has equal static depth)
                {
                    display[staticDepth] = runtimeStack.size(); // The block in the display that was pointing to the top sub will now point to the called sub
                    return true;
                }

                for (int j = 0; j < parent->children[i]->children.size(); j++)  // Look through each of the children of the current sibling
                {
                    if (topSubName == (int)&parent->children[i]->children[j]->name) // If the top sub is a niece/nephew of the called sub (Case 3: Caller has higher static depth)
                    {
                        display[staticDepth] = runtimeStack.size(); // The block in the display that was pointing to the top sub will now point to the called sub
                        return true;
                    }
                }
            }
        }
    }
    return false;
}
 
void Sub::call_()
{
    if (isVisible()) // If the sub is visible, push the sub's ARI onto the stack
    {
        // Integer encoding of the subprogram name
        int nameEncoding = (int)&name;
        printStack.push_back("Sub " + name);
        nameEncodings.push_back(nameEncoding);

        // Saved display link (The position/index in the runtimeStack which was stored in the display earlier in the call)
        int savedDisplayLink = display[staticDepth];
        printStack.push_back("Saved Link: " + std::to_string(savedDisplayLink));

        // Dynamic link: (The position/index in the runtimeStack of the last element of the old top sub's ARI)
        int dynamicLink = runtimeStack.size() - 1;
        printStack.push_back("Dynamic Link: " + std::to_string(dynamicLink));

        runtimeStack.push_back(nameEncoding);
        runtimeStack.push_back(savedDisplayLink);
        runtimeStack.push_back(dynamicLink);

        // One integer element for each argument (I used the value 8 for arguments)
        for (int i = 0; i < numArgs; i++)
        {
            runtimeStack.push_back(8);
            printStack.push_back("Arg: 8");
        }

        // One integer element for each local variable (I used the value 9 for local variables)
        for (int i = 0; i < numLocals; i++)
        {
            runtimeStack.push_back(9);
            printStack.push_back("Local: 9");
        }

        // Print runtimeStack and display
        std::cout << "\nRuntime stack after calling subprogram " << name << ":\n";
        printRuntimeStack();
        std::cout << "\nDisplay after calling subprogram " << name << ":\n";
        printDisplay();
    }
    else // If the sub is not visible, print an error message
        std::cout << "\nERROR: Subprogram " << name << " is not in the scope." << std::endl;
}

void Sub::return_() {
    if (!runtimeStack.empty()) // If the runtimeStack isn't empty
    {
        int nameEncoding = (int)&name; // Get the integer encoding of the sub's name

        int index = runtimeStack.size() - (numArgs + numLocals + 3); // Calculate the index on the stack where the sub's name would be

        if (runtimeStack[index] == nameEncoding) // If the called sub's name matches what is at this index
        {
            // Remove the ARI from runtime stack
            for (int i = 0; i < numArgs + numLocals + 3; i++) {
                runtimeStack.pop_back();
                printStack.pop_back();
            }

            // Erase the block with the top sub's index from the display and erase the sub's name from the nameEncodings vector
            display.erase(std::remove(display.begin(), display.end(), index), display.end());
            nameEncodings.erase(std::remove(nameEncodings.begin(), nameEncodings.end(), nameEncoding), nameEncodings.end());

            // Print runtime stack and display
            std::cout << "\nRuntime stack after returning from subprogram " << name << ":\n";
            printRuntimeStack();
            std::cout << "\nDisplay after returning from subprogram " << name << ":\n";
            printDisplay();
        }
        else // If the called sub's name does not match what is at this index
            std::cout << "\nERROR: Subprogram " << name << " is not the last subprogram in the stack." << std::endl;
    }
    else // If the sub is empty, print an error message
        std::cout << "\nERROR: There are no subprograms on the stack." << std::endl;
}

std::vector<int> Sub::runtimeStack;
std::vector<int> Sub::display;
std::vector<std::string> Sub::printStack;
std::vector<int> Sub::nameEncodings;
