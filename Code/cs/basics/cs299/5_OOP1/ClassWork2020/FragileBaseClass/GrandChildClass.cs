using System;

namespace Overriding {

    public class GrandChildClass : ChildClass {

        public void PrintCount()
        {
            Console.WriteLine("Count is " + Count);
        }
    }
}

