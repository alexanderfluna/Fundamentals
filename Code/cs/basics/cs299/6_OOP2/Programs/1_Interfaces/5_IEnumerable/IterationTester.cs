using System;

namespace EnablingIteration {

    public class IterationApplication
    {

        public static void Main()
        {
            MyContainer container = new MyContainer();
            container.Add("Violin");
            container.Add("Guitar");
            container.Add("Canon Digital Camera");
            container.Add("Saab Sedan");

            foreach (String things in container)
            {
                Console.WriteLine(things);
            }

            //container.Reset();

            Console.ReadLine();
        }
    }
}

/* Output
Violin
Guitar
Canon Digital Camera
Saab Sedan
*/

