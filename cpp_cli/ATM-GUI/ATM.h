#pragma once
#include "Customer.h";
#include "BankAccount.h";
#include "BankInterface.h";
using namespace System;

ref class ATM {
public:
	enum class State {START, PIN, ACCOUNT, TRANSACT};
	enum class Account {CHECKING, SAVINGS};
	enum class Transaction {DEPOSIT, WITHDRAWAL};

	ATM();

	/**
		Resets the ATM to the initial state
	*/
	void Reset();

	/**
		Sets the current customer number and sets state to PIN
		(Precondition: state is START)
		@param number the customer number
	*/
	void SetCustomerNumber(int number);

	/**
		Finds customer in bank. If found, sets state to ACCOUNT, else to START
		(Precondition: state is PIN)
		@param pin the PIN of the current customer
	*/
	void SelectCustomer(int pin);

	/**
	  Sets current account to checking or savings. Sets
	  state to TRANSACT.
	  (Precondition: state is ACCOUNT or TRANSACT)
	  @param account one of CHECKING or SAVINGS
   */
	void SelectAccount(Account account);

	/**
	  Withdraws amount from current account.
	  (Precondition: state is TRANSACT)
	  @param value the amount to withdraw
   */
	void Withdraw(double value);

	/**
	  Deposits amount to current account.
	  (Precondition: state is TRANSACT)
	  @param value the amount to deposit
   */
	void Deposit(double value);

	/**
	  Gets the balance of the current account.
	  (Precondition: state is TRANSACT)
	  @return the balance
   */
	double GetBalance();

	/**
	  Moves back to the previous state.
   */
	void back();

	/**
	  Gets the current state of this ATM.
	  @return the current state
   */
	State GetState();

	/**
	 Frees resources used – closes files, databases, sockets etc.
   */
	void CloseAll();

	State state;
	Account accountType;
	Transaction transaction;
	Customer ^currentCustomer;
	BankAccount ^currentAccount;
	int customerNumber;
	double transactionAmount;
	BankInterface ^theBank;
};