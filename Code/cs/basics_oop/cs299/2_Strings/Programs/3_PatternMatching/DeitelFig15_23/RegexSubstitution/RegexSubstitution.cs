// Fig. 15.23: RegexSubstitution.cs
// Using Regex method Replace.

using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegexSubstitution
{
   /// <summary>
   /// performs regex substitution with Replace and Split
   /// </summary>
   class RegexSubstitution
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main( string[] args )
      {
         string testString1 = 
            "This sentence ends in 5 stars *****";

         string testString2 = "1, 2, 3, 4, 5, 6, 7, 8";
         Regex testRegex1 = new Regex( "stars" );
         Regex testRegex2 = new Regex( @"\d" );
         string[] results;
         string output = "Original String 1\t\t\t" + testString1;

         testString1 = Regex.Replace( testString1, @"\*", "^" );

         output += "\n^ substituted for *\t\t\t" + testString1;

         testString1 = testRegex1.Replace( testString1, "carets" );

         output += "\n\"carets\" substituted for \"stars\"\t\t" +
            testString1;

         output += "\nEvery word replaced by \"word\"\t" +
            Regex.Replace( testString1, @"\w+", "word" );

         output += "\n\nOriginal String 2\t\t\t" + testString2;

         output += "\nFirst 3 digits by \"digit\" \t\t" +
            testRegex2.Replace( testString2, "digit", 3 );

         output += "\nString split at commas\t\t[";

         results = Regex.Split( testString2, @",\s*" );

         foreach ( string resultString in results )
         {
            output += "\"" + resultString + "\", ";
         }

         output = output.Substring( 0, output.Length - 2 ) + "]";

         MessageBox.Show( output, 
            "Substitution using regular expressions" );

      } // end method Main

   } // end class RegexSubstitution
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