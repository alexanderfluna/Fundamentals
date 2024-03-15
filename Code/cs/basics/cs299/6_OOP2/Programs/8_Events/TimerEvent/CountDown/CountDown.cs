using System;
using System.Timers;

namespace TestingProject
{
	/// <summary>
	/// Summary description for Class2.
	/// </summary>
	public class CountDown
		{
			public CountDown(int initialCount)
			{
				count = initialCount;
			}

		    public void Action(object source, ElapsedEventArgs e)	{
				if (count >= 0)
					Console.WriteLine(count);
				if (count == 0)
					Console.WriteLine("Liftoff!");
				count--;
			}

		private int count;
	}	
}
