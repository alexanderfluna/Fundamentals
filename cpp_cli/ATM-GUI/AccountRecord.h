#pragma once
using namespace System;

ref class AccountRecord {
public:
	AccountRecord(int accountNumber, double currentBalance);

	void SetBalance(double balance);

	double GetBalance();

	int GetNumber();
private:
	int accountNumber;
	double currentBalance;
};