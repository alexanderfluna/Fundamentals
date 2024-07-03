#pragma once
#include "BankAccount.h"
#include "BankData.h"
using namespace System;

ref class Customer {
public:
	Customer(int custNumber, BankAccount^ checking, BankAccount^ savings, BankData^ bank_data);

	BankAccount^ GetCheckingAccnt();

	BankAccount^ GetSavingsAccnt();
private:
	int custNumber;
	BankAccount^ checkingAccnt;
	BankAccount^ savingsAccnt;
};