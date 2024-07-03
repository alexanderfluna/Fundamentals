using System;
using System.Windows.Forms;

namespace UsingConstAndReadonly
{
    // UsingConstAndReadOnly class definition
    public class UsingConstAndReadonly
    {
        // method Main creates Constants 
        // object and displays its values
        static void Main(string[] args)
        {
            Random random = new Random();

            Constants constantValues =
               new Constants(random.Next(1, 20));

            MessageBox.Show("Radius = " + constantValues.radius +
               "\nCircumference = " +
               2 * Constants.PI * constantValues.radius,
               "Circumference");

            //constantValues.radius = 20; readonly field cannot be assigned

        } // end method Main

    } // end class UsingConstAndReadOnly
}
