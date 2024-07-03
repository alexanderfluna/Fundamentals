#pragma once
#include "CustomerRecord.h";
#include "Customer.h";
#include "BankInterface.h"
#include "CustomerRecord.h"
#include "BankData.h"
using namespace System;

ref class Bank : public BankInterface {
public:
	Bank();
	virtual Customer^ FindCustomer(int custNumber, int pin);
private:
	array<CustomerRecord^>^ custRecords;
	BankData^ bankData;
};