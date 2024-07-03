// BankAccount.cs - A class BankAccount

using System;

public class BankAccount 
{

	private double interestRate;
	private string owner;
	private double balance;

	public BankAccount(string owner) 
	{
		this.interestRate = 0.0;
		this.owner = owner; 
		this.balance = 0.0;
	}

	public BankAccount(string owner, double interestRate) 
	{
		this.interestRate = interestRate;
		this.owner = owner; 
		this.balance = 0.0;
	}

	public double Balance 
	{
		get
		{
			return balance;
		}
	}

	public void Withdraw (double amount) 
	{
		balance -= amount;
	}

	public void Deposit (double amount) 
	{
		balance += amount;
	}

	public void AddInterests() 
	{
		balance = balance + balance * interestRate;
	}    

	public override string ToString() 
	{
		return owner + "'s account holds " +
			+ balance + " kroner";
	}
} 
