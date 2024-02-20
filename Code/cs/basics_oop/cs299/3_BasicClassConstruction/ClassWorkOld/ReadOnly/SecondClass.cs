using System;

namespace TestingProject
{
	public class Greeter
	{
		 public Greeter()
        {
            name = "World";
            age = 18;
        }        
        public Greeter(string aName)
        {
            name = aName;
        }

        public void SetName(string aName)
        {
            name = aName;
            // age = 19; no, because it is readonly
        }

        public string GetName()
        {
            return name;
        }
        public void SayHello()
		{
            Console.WriteLine("Greeter1: Hello " + name);
		}        
          
        public string SayHello(string aName) 
        {
            return ("Greeter3: Hello " + aName);
        }

        public String Name
        { // Read-write property
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private string name;
        public readonly int age = 20;

    }
}
