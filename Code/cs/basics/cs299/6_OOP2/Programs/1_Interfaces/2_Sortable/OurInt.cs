using System;

namespace ConsoleApplication1
{
	/// <summary>
	/// This class encapsulates an integer
	/// as an object and implements Sortable
	/// for integers.
	/// </summary>
	public class OurInteger : Sortable 
	{
		public int val;

		public OurInteger(int i) 
		{
			val = i;
		}

		public bool LessThan(Sortable a) 
		{
			OurInteger i = (OurInteger)a;
			return (val < i.val);
		}
	}
}
