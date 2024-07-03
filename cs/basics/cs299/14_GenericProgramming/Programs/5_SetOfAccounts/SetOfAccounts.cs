// SetOfAccounts.cs - Sets of check accounts and bank accounts.

using System;


namespace TestingProject
{
	class SetOfAccounts
	{

		public static void Main()
		{

			// Construct accounts:
			BankAccount ba1 = new BankAccount("John", 1100),
				        ba2 = new BankAccount("Anne", 1200);

			CheckingAccount ca1 = new CheckingAccount("Mike", 2100),
				            ca2 = new CheckingAccount("Paul",2200);

			// Constructs empty sets of accounts:
			Set<BankAccount> s1 = new Set<BankAccount>();
			Set<CheckingAccount> s2 = new Set<CheckingAccount>();

			// Insert elements in the sets:
			s1.Insert(ba1);  s1.Insert(ba2);
			s2.Insert(ca1);  s2.Insert(ca2);

			// Establish s1 as an alias to s2
			// s1 = s2;   // Compile-time error:
			// Cannot implicitly convert type 'Set<CheckAccount>' 
			// to 'Set<BankAccount>'

			// Insert a BankAccount object into s1, 
			// and via the alias also in s2
			s1.Insert(new BankAccount("Bodil", 1300));
            
			// Activates some CheckingAccount operation on a BankAccount object
			foreach(CheckingAccount ca in s2)
			{
				// ca.SomeCheckAccountOperation();
				ca.Deposit(100);
				ca.Withdraw(100);
				ca.Deposit(100);
				ca.Withdraw(100); // there are 3 free transactions
				ca.DeductFees();
			}

			Console.WriteLine("Set of BankAccount: {0}", s1);
			Console.WriteLine("Set of CheckingAccount: {0}", s2);
   

		}

	}
}
