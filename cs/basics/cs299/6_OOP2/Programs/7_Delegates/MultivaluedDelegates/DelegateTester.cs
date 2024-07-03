// DelegateTester.cs - Testing multivalued delegates. 


using System;



namespace ConsoleApplication1
{
	public class DelegateTester
	{

		public static void Main()
		{
			A a1 = new A(1),
				a2 = new A(2),
				a3 = new A(3);

			Messenger m = new Messenger("CS at WCSU", new Message(a2.MethodA));
			m.InstallMessage(new Message(a1.MethodA));
			Console.WriteLine("Two methods so far:");
			m.DoSend();
			Console.WriteLine();

			m.InstallMessage(new Message(a3.MethodA));
			m.InstallMessage(new Message(a3.MethodA));
			Console.WriteLine("Four methods so far:");
			m.DoSend();
			Console.WriteLine();

			m.UnInstallMessage(new Message(a3.MethodA));
			m.UnInstallMessage(new Message(a1.MethodA));
			Console.WriteLine("Two methods were removed - two methods remaining:");
			m.DoSend();
		}
	}

}
