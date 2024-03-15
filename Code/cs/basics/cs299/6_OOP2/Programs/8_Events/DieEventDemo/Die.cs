// die.cs - The die class with history and dieNotifier. 

using System;
using System.Collections;

namespace ConsoleApplication1
{
	public class Die 
	{
		public delegate void Notifier(string message);  // A delegate type

		private int numberOfEyes;
		private Random randomNumberSupplier; 
		private int maxNumberOfEyes;
		private ArrayList history;
		public event Notifier dieNotifier; // The event - instance of a delegate   

		public int NumberOfEyes
		{
			get {return numberOfEyes;}
		}

		public Die (): this(6){}

		public Die (int maxNumberOfEyes)
		{
			randomNumberSupplier = new Random(unchecked((int)DateTime.Now.Ticks));
			this.maxNumberOfEyes = maxNumberOfEyes;
			numberOfEyes = randomNumberSupplier.Next(1, maxNumberOfEyes + 1);
			history = new ArrayList();
			history.Add(numberOfEyes);
		}
    
		public void Toss ()
		{
			numberOfEyes = randomNumberSupplier.Next(1,maxNumberOfEyes + 1);
			history.Add(numberOfEyes);
			if (TwoSixesInARow(history))
				// activate the event - 
				// the delegate will perform all methods
				// if no methods added, NullReferenceException
				dieNotifier("Two sixes in a row");
		}

		private bool TwoSixesInARow(ArrayList history)  {
			int histLength = history.Count;
			return histLength >= 2 && 
		      (int)history[histLength-1] == 6 && 
		      (int)history[histLength-2] == 6;
		}
       
		public override String ToString(){
			return String.Format("Die[{0}]: {1}", maxNumberOfEyes, NumberOfEyes);
		}
    }

}
