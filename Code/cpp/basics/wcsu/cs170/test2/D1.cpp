// D1.cpp | Test 2 | Alexander Luna | May 14, 2021 
#include <iostream>
#include <fstream>
#include "SalesSlip.h"
#include "SalesSlip.cpp"
using namespace std;

int main()
{
    SalesSlip sale;
    char fileName[]="SalesSlips.txt";
    ifstream theFile;
    theFile.open(fileName);
    if (!theFile)
    {
        cout << "Cannot open file: " << fileName << endl;
        exit(1);
    }
    sale.read(theFile);
    theFile.close();
}