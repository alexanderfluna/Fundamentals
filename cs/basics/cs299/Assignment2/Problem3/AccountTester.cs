// Alexander Luna | Assignment 2 | Problem 3
using System;

namespace TestingProject
{
    /// <summary>
    /// This program tests the BankAccount class and its subclasses. 
    /// </summary>
    public class AccountTester
    {
        public class Client
        {
            /// <summary>
            /// This static method void Test creates a small array of BankAccount references
            /// referring to various types of accounts and has a for-loop in which in each iteration
            /// it selects randomly an account from the array, performs 6 to 10 random transactions
            /// (with some of them being reserving and releasing money) with it, prints out the balance after each of them,
            /// and then calls EndOfMonth and prints the balance of this account once again.
            /// </summary>
            public static void Test(int numberOfIterations)
            {
                // random will be used to randomly select an account from the array
                // and perform 6 to 10 random transactions
                Random random = new Random();

                // Creates a small array of BankAccount references
                BankAccount[] accounts = {
                    new CheckingAccount(1000, 100),              // initial balance 1000, reserved amount 100
                    new SavingsAccount(2000, 0.5, 200),          // initial balance 2000, interest rate 0.5, reserved amount 200
                    new TimeDepositAccount(3000, 1.2, 12, 300),  // initial balance 3000, interest rate 1.2, 12 months to maturity, reserved amount 300
                    new CheckingAccount(4000, 400),              // initial balance 4000, reserved amount 400
                    new SavingsAccount(5000, 1.0, 500),          // initial balance 5000, interest rate 1.0, reserved amount 500
                    new TimeDepositAccount(6000, 1.5, 24, 600)   // initial balance 6000, interest rate 1.5, 24 months to maturity, reserved amount 600
                };

                // Performs the number of iterations provided by the user
                for (int iteration = 0; iteration < numberOfIterations; iteration++)
                {
                    // Randomly select an index from 0 to the length of accounts
                    int randomIndex = random.Next(0, accounts.Length);

                    // Get the randomly selected account
                    BankAccount account = accounts[randomIndex];

                    // Print account's type and balance
                    Console.WriteLine($"\nIteration {iteration+1}: Testing {account.GetType().Name} with balance: {account.GetBalance():c}");
                    
                    // Perform 6 to 10 random transactions
                    for (int i = 0; i < random.Next(6, 11); i++)
                    {
                        try
                        {
                            double amount = random.Next(1, 101); // random amount between 1 and 100
                            int operation = random.Next(4);      // randomly select operation: 0 for deposit, 1 for withdraw, 2 for reserve, 3 for release

                            switch (operation)
                            {
                                case 0: // Deposit
                                    account.Deposit(amount);
                                    Console.WriteLine($"\tTransaction {i + 1}: Deposited {amount:c}. Current balance after deposit: {account.GetBalance():c}");
                                    break;
                                case 1: // Withdraw
                                    account.Withdraw(amount);
                                    Console.WriteLine($"\tTransaction {i + 1}: Withdrawn {amount:c}. Current balance after withdrawal: {account.GetBalance():c}");
                                    break;
                                case 2: // Reserve
                                    if (account is Reservable reservableAccount) // cast account to Reservable
                                    {
                                        reservableAccount.Reserve(amount);
                                        Console.WriteLine($"\tTransaction {i + 1}: Reserved {amount:c}. Current balance after reservation: {account.GetBalance():c}");
                                    }
                                    break;
                                case 3: // Release
                                    if (account is Reservable aReservableAccount) // cast account to Reservable
                                    {
                                        aReservableAccount.Release(amount);
                                        Console.WriteLine($"\tTransaction {i + 1}: Released {amount:c}. Current balance after release: {account.GetBalance():c}");
                                    }
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }

                    // Call EndofMonth and print the balance of this account once again
                    try
                    {
                        account.EndofMonth();
                        Console.WriteLine($"\tBalance at the end of the month: {account.GetBalance():c}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        class Program
        {
            /// <summary>
            /// The Main method, which calls the Test method of the Client class.
            /// </summary>
            static void Main()
            {
                // Print the purpose of the program
                Console.WriteLine("This program will create a small array of BankAccount references referring to\nvarious type of bank accounts and has a for-loop in which each iteration" +
                    " it randomly\nselects an account from the array, performs 6 to 10 random transactions\n(some being reserving and releasing money), prints out the balance after each of them\n" +
                    "and then calls EndOfMonth and prints the balance of this account once again.");

                // Ask the user for how many iterations they would like to perform
                Console.WriteLine("\nHow many iterations would you like to perform?");

                // Verifies the input is a number and stores the number in numberOfIterations
                int numberOfIterations;
                if (!int.TryParse(Console.ReadLine(), out numberOfIterations))
                {
                    // Print error if the user did not enter a valid number
                    Console.Write("ERROR: Invalid input. Please enter a valid number.\n");
                }

                // Call the Test method of the Client class
                Client.Test(numberOfIterations);
            }
        }
    }
}
