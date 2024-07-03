#include "BankAccount.h"
using namespace System;

BankAccount::BankAccount(int accountNumber, BankData^ bank_data) {
	this->accountNumber = accountNumber;
	currentBalance = bank_data->GetBalance(accountNumber);
	bankData = bank_data;
}


BankAccount::BankAccount(const BankAccount% other) {
	accountNumber = other.accountNumber;
	currentBalance = other.currentBalance;
	bankData = other.bankData;
}

void BankAccount::Deposit(double value)
{
	currentBalance += value;
	StoreBalance();
}

void BankAccount::Withdraw(double value)
{
	if (value > currentBalance) {
		return;
	}
	else {
		currentBalance -= value;
		StoreBalance();
	}
}

double BankAccount::GetBalance()
{
	return currentBalance;
}

int BankAccount::GetNumber()
{
	return accountNumber;
}

void BankAccount::StoreBalance()
{
	bankData->SetBalance(accountNumber, currentBalance);
}
