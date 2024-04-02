using System;

namespace TestingProject
{
    /// <summary>
    /// This program tests the BankAccount class and
    /// its subclasses. 
    /// </summary>
    public class AccountTester
    {
        public class Client
        {
            public static void Test()
            {
                Random random = new Random();
                BankAccount[] accounts = {
                new CheckingAccount(1000),
                new SavingsAccount(0.5),
                new TimeDepositAccount(1000, 1.2, 12), // 12 months to maturity
                new CheckingAccount(2000),
                new SavingsAccount(1.0),
                new TimeDepositAccount(1000, 1.5, 24) // 24 months to maturity
            };

                foreach (BankAccount account in accounts)
                {
                    Console.WriteLine($"\nTesting {account.GetType().Name}:");
                    for (int i = 0; i < random.Next(6, 11); i++)
                    {
                        double amount = random.Next(1, 101); // random amount between 1 and 100
                        if (random.Next(2) == 0) // randomly select between deposit and withdraw
                        {
                            account.Deposit(amount);
                            Console.WriteLine($"\tTransaction {i + 1}: Deposited {amount:C}. Current balance: {account.GetBalance():C}");
                        }
                        else
                        {
                            account.Withdraw(amount);
                            Console.WriteLine($"\tTransaction {i + 1}: Withdrawn {amount:C}. Current balance: {account.GetBalance():C}");
                        }

                        if (account is Reservable reservableAccount)
                        {
                            if (random.Next(2) == 0) // randomly select between reserve and release
                            {
                                reservableAccount.Reserve(amount / 2);
                                Console.WriteLine($"\tTransaction {i + 1}: Reserved {amount / 2:C}. Current balance after reservation: {account.GetBalance():C}");
                            }
                            else
                            {
                                reservableAccount.Release(amount / 2);
                                Console.WriteLine($"\tTransaction {i + 1}: Released {amount / 2:C}. Current balance after release: {account.GetBalance():C}");
                            }
                        }
                    }

                    account.EndOfMonth();
                    Console.WriteLine($"\tBalance at the end of the month: {account.GetBalance():C}");
                    Console.WriteLine();
                }
            }
        }

        class Program
        {
            static void Main()
            {
                Client.Test();
            }
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 12491b52e6abb37a19bfab4d18931ea6b6ad828b
