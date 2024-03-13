// SimpleClass.cs - used to illustrate multivalued delegates 


using System;


namespace ConsoleApplication1
{
	using System;

	public class A
	{
  
		private int state;

		public A(int i)
		{
			state = i;
		}

		public void MethodA(string s)
		{
			Console.WriteLine("A: {0}, {1}", state, s);
		}   
	}


}
