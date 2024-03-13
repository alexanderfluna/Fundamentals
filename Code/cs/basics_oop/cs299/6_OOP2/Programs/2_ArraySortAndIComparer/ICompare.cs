using System;
using System.Collections;

namespace SortingGrades 
{

	public class CompareObjects : IComparer 
	{

		// Fields
		private bool ascending = true;

		// Constructor
		public CompareObjects(bool ascending) 
		{
			this.ascending = ascending;
		}

		public int Compare(Object obj1, Object obj2) 
		{
			// obj1 and obj2 will be either of type double or String
			IComparable c1 = obj1 as IComparable;
			IComparable c2 = obj2 as IComparable;
			if (c1 == null || c2 == null) 
			{
				throw new 
					Exception("Comparing objects that are not comparable");
			}
			if (c1.CompareTo(c2) > 0) 
			{
				return ascending ? 1 : -1;
			} 
			else if (c1.CompareTo(c2) == 0) 
			{
				return 0;
			} 
			else 
			{
				return ascending ? -1 : 1;
			}
		}
	}
}