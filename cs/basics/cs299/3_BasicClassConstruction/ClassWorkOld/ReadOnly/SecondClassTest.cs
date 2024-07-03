using System;

namespace TestingProject
{
	class SwitchTest 
	{ 
		static void Main() 
		{
            Greeter greeter = new Greeter();
            greeter.SayHello(); //Hello World
            Greeter greeter2 = new Greeter();
            //Console.WriteLine(greeter2.SayHello()); //should not compile
            Greeter greeter3 = new Greeter();
            Console.WriteLine(greeter3.SayHello("George")); //Hello George
            Greeter greeter4 = new Greeter("Peter");
            greeter4.SayHello();
            //Console.WriteLine(greeter4.name); cannot access name
            greeter4.SetName("Mary");
            greeter4.SayHello(); //Hello Marry
            greeter.SetName(greeter4.GetName());
            greeter.SayHello(); //Hello Marry
            // greeter.age = 22; // no - it is readonly
            int num = 10;
            ChangeIt(ref num); // OK
            // ChangeIt(ref greeter.age); // no - it is readonly

            Console.WriteLine(greeter4.Name);
            greeter4.Name = "Paul";
            Console.WriteLine(greeter4.Name);
            
		} //Main

        static void ChangeIt(ref int number)
        {
            number = 0;
        }
	} // class
} //namespace
