// Alexander Luna
#include <iostream>
using namespace std;

 void mortageSchedule(float principal, float repayment, float interest);

int main()
{
    float principal, repayment, interest;

    cout << "Enter principal: ";
    cin >> principal;
    cout << "Enter monthly repayment: ";
    cin >> repayment;
    cout << "Enter monthly interest rate (%): ";
    cin >> interest;
    interest /= 100;
    mortageSchedule(principal, repayment, interest);
}

 void mortageSchedule(float principal, float repayment, float interest)
 {
    float percentage;
    cout << "Month\tRepayment\tRemaining" << endl;
    cout << "-----------------------------------" << endl;
    for (int i = 1; principal > 0; i++)
    {
        percentage = principal * interest;
        principal += percentage;
        if (principal - repayment < 0)
        {
            principal = 0;
        }
        else
        {
            principal -= repayment;
        }
        cout.precision(2);
        cout.fixed;
        cout.setf(ios::fixed);
        cout << i << "\t" << repayment << "\t\t" << principal << endl;

    }
 }