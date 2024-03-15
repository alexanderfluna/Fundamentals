// Fig. 10.17: Tree.cs
// Class Tree contains number of rings corresponding to its age.
using System;

public class Tree : IAge
{
   private int rings; // number of rings in tree trunk

   // constructor
   public Tree( int yearPlanted )
   {
      // count number of rings in Tree
      rings = DateTime.Now.Year - yearPlanted;
   }

   // increment ring
   public void AddRing()
   {
      rings++;
   }

   // property Age implementation of interface IAge
   public int Age
   {
      get
      {
         return rings;
      }
   }

   // property Name implementation of interface IAge
   public string Name
   {
      get
      {
         return "Tree";
      }
   }

} // end class Tree