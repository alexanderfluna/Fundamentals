#include "AccountRecord.h"
using namespace System;

AccountRecord::AccountRecord(int accountNumber, double currentBalance)
{
	this->accountNumber = accountNumber;
	this->currentBalance = currentBalance;
}

void AccountRecord::SetBalance(double balance)
{
	currentBalance = balance;
}

double AccountRecord::GetBalance()
{
	return currentBalance;
}

int AccountRecord::GetNumber()
{
	return accountNumber;
}

