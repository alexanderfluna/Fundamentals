// Fig. 15.20: RegexMatches.cs
// Demonstrating Class Regex.

using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegexMatches
{
   /// <summary>
   /// test out regular expressions
   /// </summary>
   class RegexMatches
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main(string[] args)
      {
         string output = "";

         // create regular expression
         Regex expression = 
            new Regex( @"J.*\d[0-35-9]-\d\d-\d\d" );

         string string1 = "Jane's Birthday is 05-12-75\n" +
            "Dave's Birthday is 11-04-68\n" +
            "John's Birthday is 04-28-73\n" +
            "Joe's Birthday is 12-17-77";

         // match regualr expresison to string and
         // print out all matches
         foreach ( Match myMatch in expression.Matches( string1 ) )
            output += myMatch.ToString() + "\n";

         MessageBox.Show( output, "Using class Regex",
            MessageBoxButtons.OK, MessageBoxIcon.Information );

      } // end method Main

   } // end class RegexMatches
}

/*
 **************************************************************************
 * (C) Copyright 2002 by Deitel & Associates, Inc. and Prentice Hall.     *
 * All Rights Reserved.                                                   *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************
*/