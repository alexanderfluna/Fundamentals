using System;

namespace ConsoleApplication
{
    public class DataSetTester
    {
        public static void Main()
        {
            // Instantiate new DataSet object bankData
            DataSet bankData = new DataSet();

            // Add new bank account balances to the data set
            bankData.Add(new BankAccount());
            bankData.Add(new BankAccount(10000));
            bankData.Add(new BankAccount(200));

            // Print the average and highest bank account balance
            Console.WriteLine("Average bank account balance: " + bankData.GetAverage());
            MeasurableI maximum = bankData.GetMaximum();
            Console.WriteLine("Highest bank account balance: " + maximum.GetMeasure());

            // Instatiate new Dataset object coinData
            DataSet coinData = new DataSet();
            coinData.Add(new Coin(0.01, "Penny"));
            coinData.Add(new Coin(0.05, "Nickel"));
            coinData.Add(new Coin(0.1, "Dime"));
            coinData.Add(new Coin(0.25, "Quarter"));

            // Print the average and highest coin balance {0:f2}
            Console.WriteLine("Average coin value: {0:c}", coinData.GetAverage());
            maximum = coinData.GetMaximum();
            Console.WriteLine("Highest coin value: {0:c}", maximum.GetMeasure());
        }
    }
}