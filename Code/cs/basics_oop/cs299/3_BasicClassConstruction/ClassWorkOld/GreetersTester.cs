using System;

namespace Greeters
{
    public class GreeterTest
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
             
        }
    }
}
