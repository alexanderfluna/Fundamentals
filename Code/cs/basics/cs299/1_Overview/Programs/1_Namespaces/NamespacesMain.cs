using System;


namespace NamespaceApplication {

    public class MyClass {
		

		public void Talk() {
			System.Console.WriteLine("In MyClass in NamespaceApplication");
			System.Console.WriteLine("Press any key to continue");
			System.Console.ReadLine();
		}


		
		static void Main(string[] args) {
			MyClass appObject = new MyClass();
			appObject.Talk();

			Namespace2.MyClass object1 = new Namespace2.MyClass();
			object1.Talk();
			
			Namespace1.AnotherClass object2 = new Namespace1.AnotherClass();
			object2.Talk();

			Namespace3.MyClass object3 = 
 					new Namespace3.MyClass();
			object3.Talk();

			Namespace3.Namespace4.MyClass object4 = 
  					new Namespace3.Namespace4.MyClass();
			object4.Talk();
		}
	}
}



