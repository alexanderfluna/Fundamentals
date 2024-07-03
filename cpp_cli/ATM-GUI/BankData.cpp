#include "BankData.h"
#include "CustomerRecord.h"
#include "AccountRecord.h"
using namespace System;

BankData::BankData()
{
	
}

void BankData::Init()
{
	custRecords = gcnew array<CustomerRecord^>(3);
	custRecords[0] = gcnew CustomerRecord(1, 123, 4011, 5011);
	custRecords[1] = gcnew CustomerRecord(2, 456, 6011, 7011);
	custRecords[2] = gcnew CustomerRecord(3, 789, 8011, 9011);

	accounts = gcnew array<AccountRecord^>(6);
	accounts[0] = gcnew AccountRecord(4011, 1000);
	accounts[1] = gcnew AccountRecord(5011, 10000);
	accounts[2] = gcnew AccountRecord(6011, 555.55);
	accounts[3] = gcnew AccountRecord(7011, 21000);
	accounts[4] = gcnew AccountRecord(8011, 750.25);
	accounts[5] = gcnew AccountRecord(9011, 35580.72);
}

double BankData::GetBalance(int accNum)
{
	for (int i = 0; i < accounts->Length; i++) {
		if (accounts[i]->GetNumber() == accNum)
			return accounts[i]->GetBalance();
	}
	return 0.0;
}

void BankData::SetBalance(int accNum, double amount)
{
	for (int i = 0; i < accounts->Length; i++) {
		if (accounts[i]->GetNumber() == accNum) {
			accounts[i]->SetBalance(amount);
			return;
		}
	}
	return;
}

array<CustomerRecord^>^ BankData::GetCustRecords()
{
	return custRecords;
}