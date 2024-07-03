#include "ATM.h"
#include "Bank.h"
using namespace System;

ATM::ATM() {
	theBank = gcnew Bank();
	Reset();
}

void ATM::Reset()
{
	state = ATM::State::START;
	customerNumber = 0;
	currentAccount = nullptr;
	currentCustomer = nullptr;
}

void ATM::SetCustomerNumber(int number)
{
	// (Precondition: state is START)
	if (state == ATM::State::START) {
		customerNumber = number;
		state = ATM::State::PIN;
	}
}

void ATM::SelectCustomer(int pin)
{
	// (Precondition: state is PIN)
	if (state == ATM::State::PIN) {
		currentCustomer = theBank->FindCustomer(customerNumber, pin);
		if (currentCustomer != nullptr)
			state = ATM::State::ACCOUNT;
		else
			state = ATM::State::START;
	}
}

void ATM::SelectAccount(Account account) 
{
	//(Precondition: state is ACCOUNT or TRANSACT)
	if (state == State::ACCOUNT || state == State::TRANSACT)
	{
		switch (account)
		{
		case ATM::Account::CHECKING:
			currentAccount = currentCustomer->GetCheckingAccnt();
			accountType = ATM::Account::CHECKING;
			break;
		case ATM::Account::SAVINGS:
			currentAccount = currentCustomer->GetSavingsAccnt();
			accountType = ATM::Account::SAVINGS;
			break;
		}
		state = State::TRANSACT;
	}
}

void ATM::Withdraw(double value)
{
	if (state == ATM::State::TRANSACT)
		currentAccount->Withdraw(value);
}

void ATM::Deposit(double value)
{
	if (state == ATM::State::TRANSACT)
		currentAccount->Deposit(value);
}

double ATM::GetBalance()
{
	if (state == ATM::State::TRANSACT)
		return currentAccount->GetBalance();
	else
		return 0;

}

void ATM::back()
{
	switch (state) {
	case (ATM::State::PIN):
		state = ATM::State::START;
		break;
	case (ATM::State::ACCOUNT):
		state = ATM::State::PIN;
		break;
	case (ATM::State::TRANSACT):
		state = ATM::State::ACCOUNT;
		break;
	default:
		break;
	}
}

ATM::State ATM::GetState()
{
	return state;
}

void ATM::CloseAll()
{
	System::Windows::Forms::Application::Exit();
}
