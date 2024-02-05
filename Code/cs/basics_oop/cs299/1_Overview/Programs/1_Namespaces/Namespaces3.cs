namespace Namespace3 {

	public class MyClass {

		public void Talk() {
			System.Console.WriteLine("In MyClass in Namespace3");
			System.Console.WriteLine("Press any key to continue");
			System.Console.ReadLine();
		}
	}

	namespace Namespace4 {

		public class MyClass {

			public void Talk() {
				System.Console.WriteLine("In MyClass in Namespace3.Namespace4");
				System.Console.WriteLine("Press any key to continue");
				System.Console.ReadLine();
			}
		}
	}
}
