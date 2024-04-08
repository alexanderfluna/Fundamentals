#include <iostream>
#include <fstream>
#include <string>
#include "SalesSlip.h"
using namespace std;

SalesSlip::SalesSlip()
{
    name = "";
    productNum = 0;
    totalSales = 0;
}

void SalesSlip::read(ifstream& theFile)
{
    if (theFile.is_open())
    {
        string line;
        while (getline(theFile, line))
        {
            cout << line << "\n";
        }
    }
}

string SalesSlip::getName() const
{
    return name;
}

double SalesSlip::getSales() const
{
    return totalSales;
}