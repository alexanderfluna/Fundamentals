#region Using directives

using System;
using System.Text;

#endregion

namespace IntroducingProperties
{
    class PropertiesTester
    {
        public static void Main()
        {
            // New app object
            // importantvalue1 = 17
            SimplePropertiesApplication app = new SimplePropertiesApplication(17);

            // Assign important values
            app.ImportantValue2 = 14;
            app.ImportantValue3 = "ABCDEFG";

            // print 17
            Console.WriteLine("importantValue1 = " + app.ImportantValue1);

            // print out three important values
            Console.WriteLine(app.ToString());
            Console.ReadLine();
        }
    }
}
