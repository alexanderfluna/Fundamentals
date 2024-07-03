#include "Bank.h"
#include "Customer.h"
#include "BankInterface.h"
#include "CustomerRecord.h"
#include "BankData.h"

Bank::Bank() {
	bankData = gcnew BankData();
	bankData->Init();
	custRecords = bankData->GetCustRecords();
}

Customer^ Bank::FindCustomer(int custNumber, int pin)
{
    for (int i = 0; i < custRecords->Length; i++)
    {
        if (custRecords[i]->getCustNumber() == custNumber && custRecords[i]->getPin() == pin)
        {
            BankAccount^ checkingAccnt = gcnew BankAccount(custRecords[i]->getChecking(), bankData);
            BankAccount^ savingsAccnt = gcnew BankAccount(custRecords[i]->getSavings(), bankData);
            Customer^ customer = gcnew Customer(custNumber, checkingAccnt, savingsAccnt, bankData);
            return customer;
        }
    }
    return nullptr; // customer not found
}
