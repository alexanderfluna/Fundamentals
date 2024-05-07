using System;
using System.Threading;

namespace ConsoleApplication1
{
	/// <summary>
	/// Summary description for Class2.
	/// </summary>
	public class SynchBankTest
	{
		public static void Main(String[] args) 
		{
			   
			Bank b = new Bank(NACCOUNTS, INITIAL_BALANCE);
			int i;
			for (i = 0; i < NACCOUNTS; i++)
			{
				TransferThread worker = new TransferThread(b, i, INITIAL_BALANCE);
				//TransferThread worker = new TransferThread(b, i, 13000);
				Thread t = new Thread(new ThreadStart(worker.DoTransfer));
				t.Priority = ThreadPriority.Normal + i % 2;
				t.Start();
				Console.WriteLine("thread started");
			}
		}

		public const int NACCOUNTS = 10;
		public const int INITIAL_BALANCE = 10000;
	}

	class Bank
	{
		public Bank(int n, int initialBalance)	   
		{
			accounts = new int[n];
			int i;
			for (i = 0; i < accounts.Length; i++)
				accounts[i] = initialBalance;
			ntransacts = 0;
		}

		public void Transfer(int from, int to, int amount)	{
			Monitor.Enter(this);
			while (accounts[from] < amount)
				Monitor.Wait(this);
			Random random = new Random();
			if (random.NextDouble()< 0.5)
			{
				accounts[from] -= amount;
				Thread.Sleep(1);
				accounts[to] += amount;
			}
			else
			{
				accounts[to] += amount;
				Thread.Sleep(1);
				accounts[from] -= amount;
			}
			ntransacts++;
			//Monitor.PulseAll(this);
			//Monitor.Exit(this);
			
			if (ntransacts % NTEST == 0) Test();
			Monitor.PulseAll(this);
			Monitor.Exit(this);
			
		}

		public void Test()	{
			Monitor.Enter(this);
			int sum = 0;
			for (int i = 0; i < accounts.Length; i++)
				sum += accounts[i];
			Console.WriteLine("Transactions:" + ntransacts + " Sum: " + sum);
			Monitor.Exit(this);			
		}

		public int Size() 
		{
			return accounts.Length;
		}

		public const int NTEST = 100;
		private int[] accounts;
		private long ntransacts = 0;
	}	

	class TransferThread 
	{
		
		public TransferThread(Bank b, int from, int max)	
		{
			bank = b;
			fromAccount = from;
			maxAmount = max;
		}

		public void DoTransfer()
		{
			Random random = new Random();
			Thread current = Thread.CurrentThread;
			Console.WriteLine(current.ThreadState);
			while (current.ThreadState == ThreadState.Running)
			{
				int toAccount = (int)(bank.Size() * random.NextDouble());
				int amount = (int)(maxAmount * random.NextDouble());
				bank.Transfer(fromAccount, toAccount, amount);
				// bank.Test();
				Thread.Sleep(1);
			}		
		}

		private Bank bank;
		private int fromAccount;
		private int maxAmount;
	}


}
