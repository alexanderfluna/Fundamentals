#pragma once
#include "BankData.h";
using namespace System;

ref class BankAccount {
public:
	BankAccount(int accountNumber, BankData^ bank_data);

	BankAccount(const BankAccount% other);

	void Deposit(double value);

	void Withdraw(double value);

	double GetBalance();

	int GetNumber();

	void StoreBalance();

private:
	int accountNumber;
	double currentBalance;
	BankData^ bankData;
};