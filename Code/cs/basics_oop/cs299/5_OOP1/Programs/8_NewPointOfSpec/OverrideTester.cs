using System;

namespace Overriding {

    public class OverrideTester {

        public static void Main() {
            // no polymorphism, uses BaseClass operation
            BaseClass obj = new ChildClass(20);
            obj.SomeImportantOperation();
            Console.WriteLine(obj.ToString());//520

            // no polymorphism, uses ChildClass operation
            ChildClass obj1 = new ChildClass(50);
            obj1.SomeImportantOperation();
            Console.WriteLine(obj1.ToString());//100
            //Console.ReadLine();

            // polymorphism, uses GrandChildClass operation
            ChildClass obj2 = new GrandChildClass(50);
            obj2.SomeImportantOperation();
            Console.WriteLine(obj2.ToString());// 25
            //Console.ReadLine();

            // no polymorphism, uses BaseClass operation
            BaseClass obj3 = new GrandChildClass(50);
            obj3.SomeImportantOperation();
            Console.WriteLine(obj3.ToString());// 550
            Console.ReadLine();
        }
    }
}
/* Output
baseClassValue: 520
baseClassValue: 25
*/
