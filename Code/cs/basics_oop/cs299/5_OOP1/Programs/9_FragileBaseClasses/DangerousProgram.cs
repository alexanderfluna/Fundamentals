using System;

namespace ConsoleApplication1
{
	/// <summary>
	/// Summary description for Class8.
	/// </summary>
	// Dangerous program.
	// M2 is virtual in A and overridden in B.
	// Compiles and runs
	// Default Java semantics.

	using System;

	// New version of A
	class A 
	{

		public void M1()
		{
			Console.WriteLine("Method 1");
			this.M2();
		}

		// New method in this version.
		// Same name as the dangerous operation in subclass B
		public  virtual  void M2()
		{
			Console.WriteLine("M2 in new version of A");
		}

	}

	class B: A 
	{
  
		// Compile-time error in C#:
		// 'B.M2()' hides inherited member 'A.M2()'.
		//     Use the new keyword if hiding was intended.
		public override void M2()
		{
			Console.WriteLine("Dangerous Method 2");
		}
	}

	class Client
	{
  
		public static void Main()
		{
			A a = new B();
			B b = new B();

			a.M1();  // Nothing dangerous expected
			// Will, however, call the dangerous operation
			// because M2 is virtual.

			a.M2();  // Makes sense when M2 exists in class A.
			// Calls the dangerous method

			b.M2();  // Calls the dangerous method.
			// This is expected, however.
		}
	}


}
