using System;
using System.Collections;

namespace Iteration {

    public class IterationApplication {

        static void Main() {
            ArrayList myList = new ArrayList();
            myList.Add("Erik");
            myList.Add("Anna");
            myList.Add("Marc");
            myList.Add("Daniel");
            foreach (String name in myList) {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
