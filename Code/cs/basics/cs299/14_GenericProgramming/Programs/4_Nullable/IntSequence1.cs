// IntSequence1.cs - An integer sequence with Min and Max operations - a naive attempt.

using System;


namespace ConsoleApplication1
{
	public class IntSequence 
	{

		private int[] sequence;

		public IntSequence(params int[] elements)
		{
			sequence = new int[elements.Length];
			for(int i = 0; i < elements.Length; i++)
			{
				sequence[i] = elements[i];
			}
		}

		public int Min()
		{
			int theMinimum;
			if (sequence.Length == 0)
				return -1;
			else 
			{
				theMinimum = sequence[0];
				foreach(int e in sequence)    
					if (e < theMinimum)
						theMinimum = e;
			}
			return theMinimum;
		}

		public int Max()
		{
			int theMaximum;
			if (sequence.Length == 0)
				return -1;
			else 
			{
				theMaximum = sequence[0];
				foreach(int e in sequence)    
					if (e > theMaximum)
						theMaximum = e;
			}
			return theMaximum;
		}

		// Other useful sequence methods

	}
}
