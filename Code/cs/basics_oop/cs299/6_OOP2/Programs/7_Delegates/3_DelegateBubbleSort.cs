// Fig. 10.24: DelegateBubbleSort.cs
// Demonstrating delegates for sorting numbers.

public class DelegateBubbleSort
{
   public delegate bool Comparator( int element1, 
      int element2 );

   // sort array using Comparator delegate
   public static void SortArray( int[] array, 
      Comparator Compare )
   {
      for ( int pass = 0; pass < array.Length; pass++ )

         for ( int i = 0; i < array.Length - 1; i++ )
   
            if ( Compare( array[ i ], array [ i + 1 ] ) )
               Swap( ref array[ i ], ref array[ i + 1 ] ); 
   }
   
   // swap two elements
   private static void Swap( ref int firstElement, 
      ref int secondElement )
   {
      int hold = firstElement;
      firstElement = secondElement;
      secondElement = hold;
   }
}
