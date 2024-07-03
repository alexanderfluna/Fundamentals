// Square.cs
// A Square on the TicTacToe board.

using System.Windows.Forms;

namespace TicTacToeClient
{
   // the representation of a square in a tic-tac-toe grid
   public class Square
   {
      private Panel panel;
      private char mark;
      private int location;

      // constructor
      public Square( Panel newPanel, char newMark, int newLocation )
      {
         panel = newPanel;
         mark = newMark;
         location = newLocation;
      }
      
      // property SquarePanel; the panel which the square represents
      public Panel SquarePanel
      {
         get
         {
            return panel;
         }
      } // end property SquarePanel

      // property Mark; the mark of the square
      public char Mark
      {
         get
         {
            return mark;
         }

         set
         {
            mark = value;
         }
      } // end property Mark

      // property Location; the square's location on the board
      public int Location
      {
         get
         {
            return location;
         }
      } // property Location

   } // end class Square
}

