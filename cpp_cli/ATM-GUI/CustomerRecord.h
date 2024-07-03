#pragma once
using namespace System;

ref class CustomerRecord {
public:
	CustomerRecord(int custNumber, int pin, int checking, int savings);

	// @return custNumber
	int getCustNumber();

	// @return pin
	int getPin();

	// @return checking
	int getChecking();

	// @return savings
	int getSavings();
	
private:
	int custNumber;
	int pin;
	int checking;
	int savings;
};