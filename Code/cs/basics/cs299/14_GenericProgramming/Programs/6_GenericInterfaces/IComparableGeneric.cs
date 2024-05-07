// IComparableGeneric.cs - A reproduction of the generic interface IComparable<T>.

using System;

namespace ConsoleApplication1
{
	public interface IComparable <T>
								  {
		int CompareTo(T other);
	}

}
