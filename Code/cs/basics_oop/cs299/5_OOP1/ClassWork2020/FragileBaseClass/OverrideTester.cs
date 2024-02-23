using System;

namespace Overriding {

    public class OverrideTester {

        public static void Main() {
            
            ChildClass obj1 = new ChildClass();
            obj1.AddAll(new int[] { 1, 2, 3 });
            Console.WriteLine("Number of elements is " + obj1.Count);

            GrandChildClass obj2 = new GrandChildClass();
            obj2.AddAll(new int[] { 1, 2, 3 });
            obj2.PrintCount();

            ChildClass obj3 = new GrandChildClass();
            obj3.AddAll(new int[] { 1, 2, 3 });
            //((GrandChildClass)obj3).PrintCount();
            Console.WriteLine("Number of elements is " + obj3.Count);

            BaseClass obj4 = new GrandChildClass();
            // not polymorphic, because of the 
            // new poit of specialization.
            obj4.AddAll(new int[] { 1, 2, 3 });
            //((GrandChildClass)obj3).PrintCount();
            Console.WriteLine("Number of elements is " +
               ((GrandChildClass)obj4).Count);
        }
    }
}

