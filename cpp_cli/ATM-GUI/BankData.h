#pragma once
#include "AccountRecord.h";
#include "CustomerRecord.h";
using namespace System;

ref class BankData {
public:
	BankData();

	void Init();

	double GetBalance(int accNum);

	void SetBalance(int accNum, double amount);

	array<CustomerRecord^>^ GetCustRecords();
private:
	array<AccountRecord^>^ accounts;
	array<CustomerRecord^>^ custRecords;
};