using System;

namespace TestingProject
{
	public class Greeter1
	{
		public void SayHello()
		{
            Console.WriteLine("Greeter1: Hello World");
		}
		
	}
    public class Greeter2
    {
        public String SayHello()
        {
            return ("Greeter2: Hello World");
        }

    }

    public class Greeter3
    {
        public void SayHello(string name)
        {
            Console.WriteLine("Greeter3: Hello " + name);
        }

    }

    public class Greeter4
    {
        public Greeter4()
        {
            name = "World";
        }
        
        public Greeter4(string aName)
        {
            name = aName;
        }

        public string SayHello()
        {
            return ("Greeter3: Hello " + name);
        }

        string name;

    }
}
