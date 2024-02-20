using System;

namespace IndexerApplication {

    public class CarCollectionApp {

        public static void Main() {
            CarCollection myCars = new CarCollection();
            for (int index = 1; index <= myCars.Size; index++) {
                Console.WriteLine(myCars[index]);
            }
            Console.WriteLine();
            myCars[2] = "Audi";
            for (int index = 1; index <= myCars.Size; index++) {
                Console.WriteLine(myCars[index]);
            }
            Console.ReadLine();
        }
    }
}
/* Output
Ford
Toyota
Saab
Volvo
Chevy
Dodge
Mercedes

Ford
Audi
Saab
Volvo
Chevy
Dodge
Mercedes
*/
