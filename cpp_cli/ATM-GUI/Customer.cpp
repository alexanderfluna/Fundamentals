#include "Customer.h"
#include "BankAccount.h"
#include "BankData.h"
#include "CustomerRecord.h"

Customer::Customer(int custNumber, BankAccount^ checking, BankAccount^ savings, BankData^ bank_data)
{
    this->custNumber = custNumber;
    this->checkingAccnt = checking;
    this->savingsAccnt = savings;
    BankData^ bankData = bank_data;
    CustomerRecord^ custRecord = nullptr;
    for (int i = 0; i < bankData->GetCustRecords()->Length; i++)
    {
        if (bankData->GetCustRecords()[i]->getCustNumber() == custNumber)
        {
            custRecord = bankData->GetCustRecords()[i];
            break;
        }
    }
    if (custRecord != nullptr)
    {
        checkingAccnt = gcnew BankAccount(custRecord->getChecking(), bankData);
        savingsAccnt = gcnew BankAccount(custRecord->getSavings(), bankData);
    }
}

BankAccount^ Customer::GetCheckingAccnt()
{
	return checkingAccnt;
}

BankAccount^ Customer::GetSavingsAccnt()
{
	return savingsAccnt;
}