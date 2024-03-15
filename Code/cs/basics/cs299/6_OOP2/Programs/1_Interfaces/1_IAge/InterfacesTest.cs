// Fig. 10.18: InterfacesTest.cs
// Demonstrating polymorphism with interfaces.
using System.Windows.Forms;

public class InterfacesTest
{
   public static void Main( string[] args )
   {
      Tree tree = new Tree( 1978 );
      Person person = new Person( "Bob", "Jones", 1971 );

      // create array of IAge references
      IAge[] iAgeArray = new IAge[ 2 ];
 
      // iAgeArray[ 0 ] refers to Tree object polymorphically
      iAgeArray[ 0 ] = tree;

      // iAgeArray[ 1 ] refers to Person object polymorphically
      iAgeArray[ 1 ] = person;

      // display tree information
      string output = tree + ": " + tree.Name + "\nAge is " + 
         tree.Age + "\n\n";

      // display person information
      output += person + ": " + person.Name + "\nAge is: " 
         + person.Age + "\n\n";

      // display name and age for each IAge object in iAgeArray
      foreach ( IAge ageReference in iAgeArray )
      {
         output += ageReference.Name + ": Age is " + 
            ageReference.Age + "\n";
      }

      MessageBox.Show( output, "Demonstrating Polymorphism" );

   } // end method Main

} // end class InterfacesTest