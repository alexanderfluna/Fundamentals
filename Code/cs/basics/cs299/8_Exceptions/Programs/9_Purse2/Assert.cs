using System;
using System.Diagnostics;

// to set the system configuration right-click on project name in Solution Explorer
// -> Properties -> Build, under Conditional Compilation Symbols  
// check DEBUG.

namespace TestingProject
{
	/// <summary>
	/// Summary description for Class2.
	/// </summary>
	class Assert
	{
		
		public class FailedException : ApplicationException 
		{
			public FailedException(string s) : base(s) {}
		}
 
		//[System.Diagnostics.Conditional("ASSERT")]
        //[System.Diagnostics.Conditional("DEBUG")]
		public static void Test(bool condition)
		{
			if (condition)   { return; }
			throw new FailedException("Assertion failed.");
		}
 
		//[System.Diagnostics.Conditional("ASSERT")]
		//[System.Diagnostics.Conditional("DEBUG")]
		public static void Test(bool condition, string message)
		{
			if (condition)   { return; }
			throw new FailedException("Assertion '" + message + "' failed.");
		}
	}

}
