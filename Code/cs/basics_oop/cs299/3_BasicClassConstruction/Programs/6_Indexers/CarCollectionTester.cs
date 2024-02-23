using System;

namespace IndexerApplication
{

    public class CarCollectionApp
    {

        public static void Main()
        {
            // create car collection
            CarCollection myCars = new CarCollection();

            // print out every car
            for (int index = 1; index <= myCars.Size; index++)
            {
                Console.WriteLine(myCars[index]);
            }
            Console.WriteLine();

            // set car at index 2 to audi
            myCars[2] = "Audi";

            // print out every car
            for (int index = 1; index <= myCars.Size; index++)
            {
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
