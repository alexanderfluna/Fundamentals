#ifndef SALES_H
#define SALES_H
#include <iostream>
#include <fstream>
#include <string>
using namespace std;

class SalesSlip
{
public:
    SalesSlip();
    void read(ifstream& theFile);
    string getName() const;
    double getSales() const;
public:
    string name;
    int productNum;
    double totalSales;
};

#endif