using System;
using System.Collections.Generic;
using System.Text;

namespace OtherModifiers
{
    
    public class OtherModifiersTester{

        public static void Main() {
            Modifiers app = new Modifiers();
            int value = 0;
            app.ProduceSomeValue(out value);
            Console.WriteLine("value: " + value);
            app.ChangeSomeValue(ref value);
            Console.WriteLine("value: " + value);
            Console.ReadLine();
        }
    }
}
/* Output
value: 17
value: 85
*/

