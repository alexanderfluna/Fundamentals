// ObsoleteClasses.cs - An obsolete class C, and a class D with an obsolete method M. 

using System;

namespace ConsoleApplication1
{
	
	[Obsolete("Use class D instead")]
	class C
	{
		// ...
	}

	class D
	{
		// [Obsolete("Do not call this method.",false)] // will compile
		[Obsolete("Do not call this method.",true)] //will not compile
		public void M()
		{
		}
	}

	class E
	{
		public static void Main()
		{
			C c = new C();
			D d = new D();
			d.M();
		}
	}

}
