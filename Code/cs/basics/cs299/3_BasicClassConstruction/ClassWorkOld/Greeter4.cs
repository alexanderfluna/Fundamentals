using System;

namespace Greeters
{
		public class Greeter4
		{
            public Greeter4(string aName)
            {
                name = aName;
            }			
            
            public string SayHello()
			{
                return "Hello " + name;
			}

            string name;
		}
}
