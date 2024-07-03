#pragma once
#include "Customer.h";
using namespace System;

interface class BankInterface{
	Customer^ FindCustomer(int custNumber, int pin);
};