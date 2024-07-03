// Fig. 10.25: BubbleSortForm.cs
// Demonstrates bubble sort using delegates to determine
// the sort order.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
//using System.Windows.Forms;

namespace Delegates
{
   /// <summary>
   /// Summary description for BubbleSortForm.
   /// </summary>
   public class BubbleSortTest
   {
      private int[] elementArray = new int[ 10 ];      
      
      // create randomly generated set of numbers to sort
      private void createData()
      {
         // create random-number generator
         Random randomNumber = new Random();

         // populate elementArray with random integers
         for ( int i = 0; i < elementArray.Length; i++ )
         {
            elementArray[ i ] = randomNumber.Next( 100 );            
         }
      } 
    
      // delegate implementation for ascending sort
      private bool CompareAscending( int element1, int element2 )
      {
         return element1 > element2;
      }

      // delegate implementation for descending sort
      private bool CompareDescending(int element1, int element2)
      {
          return element1 < element2;
      } 
      

      // sort randomly generated numbers in ascending order
      private void sortAscending()
      {
         // sort array, passing delegate for SortAscending
         DelegateBubbleSort.SortArray( elementArray, 
            new DelegateBubbleSort.Comparator( 
               CompareAscending ) );

         //DisplayResults();      
      }

       
      
      // sort randomly generating numbers in descending order
      private void sortDescending()
      {
         // sort array, passing delegate for SortDescending
         DelegateBubbleSort.SortArray( elementArray, 
            new DelegateBubbleSort.Comparator( 
               CompareDescending ) );

         //DisplayResults();       
      }   

      // display the sorted array in sortedTextBox
      private void DisplayResults()
      {
          foreach (int element in elementArray)
              Console.Write("{0} ", element);
          Console.WriteLine();
          Console.WriteLine();

      }

      // main entry point for application
      public static void Main( string[] args )
      {
          BubbleSortTest test = new BubbleSortTest();
          test.createData();
          test.DisplayResults();
          test.sortAscending();
          test.DisplayResults();
          test.sortDescending();
          test.DisplayResults();
      }
   }
}
