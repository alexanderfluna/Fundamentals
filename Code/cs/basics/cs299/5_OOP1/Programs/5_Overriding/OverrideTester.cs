using System;

namespace Overriding {

    public class OverrideTester {

        public static void Main() {
            BaseClass obj = new ChildClass(20);
            obj.SomeImportantOperation();
            Console.WriteLine(obj.ToString());

            ChildClass obj2 = new GrandChildClass(50);
            obj2.SomeImportantOperation();
            Console.WriteLine(obj2.ToString());
            Console.ReadLine();
        }
    }
}
/* Output
baseClassValue: 520
baseClassValue: 25
*/
