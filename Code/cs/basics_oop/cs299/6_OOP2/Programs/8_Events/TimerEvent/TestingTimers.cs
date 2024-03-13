using System;
using System.Timers;

namespace TestingProject
{
	/// <summary>
	
	public class Timer1
	{
		public static void Main()
		{
			// Normally, the timer is declared at the class level, so
			// that it doesn't go out of scope when the method ends.
			// In this example, the timer is needed only while Main 
			// is executing. However, KeepAlive must be used at the
			// end of Main, to prevent the JIT compiler from allowing 
			// aggressive garbage collection to occur before Main 
			// ends.
			System.Timers.Timer aTimer = new System.Timers.Timer();

			// Hook up the Elapsed event for the timer.
			aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

			// Set the Interval to 2 seconds (2000 milliseconds).
			aTimer.Interval = 2000;
			aTimer.Enabled = true;
 
			Console.WriteLine("Press the Enter key to exit the program.");
			Console.ReadLine();

			// Keep the timer alive until the end of Main.
			GC.KeepAlive(aTimer);
		}
 
		// Specify what you want to happen when the Elapsed event is 
		// raised.
		private static void OnTimedEvent(object source, ElapsedEventArgs e)
		{
			Console.WriteLine("Hello World!");
		}
	}
 


}
