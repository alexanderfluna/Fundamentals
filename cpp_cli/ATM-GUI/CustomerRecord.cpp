#include "CustomerRecord.h"
using namespace System;

CustomerRecord::CustomerRecord(int custNumber, int pin, int checking, int savings) {
	this->custNumber = custNumber;
	this->pin = pin;
	this->checking = checking;
	this->savings = savings;
}

int CustomerRecord::getCustNumber()
{
	return custNumber;
}

int CustomerRecord::getPin()
{
	return pin;
}

int CustomerRecord::getChecking()
{
	return checking;
}

int CustomerRecord::getSavings()
{
	return savings;
}
