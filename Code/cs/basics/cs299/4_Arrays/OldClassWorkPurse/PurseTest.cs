using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace TestingProject
{
    /// <summary>
    /// This class tests the Purse class by prompting the
    /// user to add coins into a purse and computing the total
    /// value of the purse.
    /// </summary>

    // To use Microsoft.VisualBasic need to add reference to Microsoft.VisualBasic.
    // in the Solution Explorer right-click on References -> Add -> .NET tag

    // To position the InputBox, need to add reference to
    // System.Windows.Forms and System.Drawing - again in Solution Explorer, References

    public class PurseTest
    {
        public static void Main()
        {
            // set the value of the coins
            double NICKEL_VALUE = 0.05;
            double DIME_VALUE = 0.1;
            double QUARTER_VALUE = 0.25;

            // create new purse
            Purse myPurse = new Purse();

            bool done = false;
            while (!done)
            {
                // string input 
                //	= JOptionPane.showInputDialog("Enter coin name or Cancel");

                // Prompt user to enter coin
                string prompt = "Enter coin name or Cancel";

                // Adjust window
                string title = "Coin";
                string deflt = "";
                int XPos = (SystemInformation.WorkingArea.Width / 2 - 200);
                int YPos = (SystemInformation.WorkingArea.Height / 2 - 200);
                string input = Interaction.InputBox(prompt, title, deflt, XPos, YPos);
                if (input == "") // user pressed Cancel
                    done = true;
                else
                {
                    // set value to corresponding coin value
                    double value = 0;
                    if (input == "nickel")
                        value = NICKEL_VALUE;
                    else if (input == "dime")
                        value = DIME_VALUE;
                    else if (input == "quarter")
                        value = QUARTER_VALUE;
                    if (value != 0)
                    {
                        // Add coin to purse
                        Coin c = new Coin(value, input);
                        myPurse.Add(c);
                        double totalValue = myPurse.GetTotal();
                        Console.WriteLine("The total is " + totalValue);
                        Console.WriteLine(myPurse);
                    }

                }
            }
            Console.WriteLine("Reversing the coins in the purse");
            myPurse.Reverse(); // reverses the order of the elements in an array list
            Console.WriteLine(myPurse);

            //System.exit(0);
        }
    }
}
