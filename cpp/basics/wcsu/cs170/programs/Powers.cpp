// a recursive function. It prints a
// table of the powers of two.
//

#include <iostream>
#include <iomanip>
using namespace std;

const int LARGEST_POWER = 10;

// This function computes x raised to the nth power. It assumes n>=0.
double power (double x, int n);

int main ()
{
   ////int i = 3;
   //double pow = power(2.0, i);
   //cout << setw(2) << i << setw(8) << pow << endl;
   
   cout << "Powers of 2" << endl << endl;
   cout << " n     2^n\n--  ------" << endl;
   for (int i=1; i<= LARGEST_POWER; i++){
	   double pow = power(2.0, i);
       cout << setw(2) << i << setw (8) << pow << endl;
   }
   
}

// This function computes x raised to the nth power. It assumes n>=0.
double power (double x, int n)
{
  // cout << "function power  with argument " << n << "starts." << endl;
   if (n <= 0)
      return 1;
   else{
	   double res = x * power(x, n - 1);
	  // cout << "function power  with argument " << n 
		//   << " returns " << res << endl;
	   return res;
   }
}
