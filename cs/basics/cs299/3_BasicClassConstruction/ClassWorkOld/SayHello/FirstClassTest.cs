using System;

namespace TestingProject
{
	class SwitchTest 
	{ 
		static void Main() 
		{
            Greeter1 greeter = new Greeter1();
            greeter.SayHello(); //Hello World
            Greeter2 greeter2 = new Greeter2();
            Console.WriteLine(greeter2.SayHello()); //Hello World
            Greeter3 greeter3 = new Greeter3();
            greeter3.SayHello("George"); //Hello George
            Greeter4 greeter4 = new Greeter4("Peter");
            Console.WriteLine(greeter4.SayHello());//Hello Peter
            greeter4 = new Greeter4();
            Console.WriteLine(greeter4.SayHello());//Hello World
		} //Main
	} // class
} //namespace
