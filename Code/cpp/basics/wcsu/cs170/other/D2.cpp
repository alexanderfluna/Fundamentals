// D2.cpp | Test 2 | Alexander Luna | May 14, 2021 
#include <iostream>
#include <fstream>
#include <string>
#include <iomanip>
#include "SalesSlip.h"
#include "SalesSlip.cpp"
using namespace std;

// NUMBER OF ENTRIES IN SALESSLIPS.TXT
const int SIZE = 17;

int main()
{
   // Reads from the file
   SalesSlip sale;
   SalesSlip arr[SIZE];
   char fileName[]="SalesSlips.txt";
   ifstream theFile;
   theFile.open(fileName);
   if (!theFile)
   {
      cout << "Cannot open file: " << fileName << endl;
      exit(1);
   }

   for (int i = 0; i < SIZE; i++)
   {
      theFile >> sale.name;
      theFile >> sale.productNum;
      theFile >> sale.totalSales;
      arr[i] = sale;
   }
   theFile.close();

   /* Here I was attempting to copy the name and total sales from arr
   into arr2d */
   SalesSlip arr2d[4][5];
   for (int i = 0; i < 4; i++)
   {
      for (int j = 1; j < 5+1; j++)
      {
         arr2d[i][0].name = arr[i].name;
         arr2d[i][j].totalSales = arr[i].totalSales;
      }
   }

   /* Here I was attempting to print arr2d into the table */
   cout << "Total Sales By Salesperson" << endl;
   cout << "Product #" << setw(10) << "1" << setw(10) << "2" << setw(10) << "3" << setw(10) << "4" << setw(10) << "5" << endl;
   for (int i = 0; i < 4; i++)
   {
      for (int j = 0; j < 5; j++)
           cout << arr2d[i][j].getName() << setw(10) << arr2d[i][j].getSales() << setw(5) << arr2d[i][j].getSales() << setw(5) << arr2d[i][j].getSales() << setw(5) << arr2d[i][j].getSales() << setw(5) << arr2d[i][j].getSales() << endl;
   }
}
