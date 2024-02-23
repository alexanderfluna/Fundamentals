using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

// To use Microsoft.VisualBasic need to add reference to Microsoft.VisualBasic.
// in the Solution Explorer right-click on references ->add -> .NET tag

// To position the InputBox, need to add reference to
// System.Windows.Forms and System.Drawing - again in Solution Explorer

namespace ConsoleApplication1
{
    ///<summary
    /// This program tests the DataSet class by adding 10,000 numbers
    /// to the data set and computing the average.
    ///</summary>
   
    public class TicTacToeTest    {
        public static void Main() {
            char player = 'x';
            TicTacToe game = new TicTacToe();
          while (true) {
            Console.WriteLine(game);
            string prompt = "Row for " + player + " (Cancel to exit)";     
            string title = "Move";
            string deflt = "1";
            int XPos = (SystemInformation.WorkingArea.Width/2 - 200);
            int YPos = (SystemInformation.WorkingArea.Height/2 - 200);
 
            string input = Interaction.InputBox(prompt,title,deflt,XPos,YPos);
            if (input == "") // user pressed Cancel
                break;
            
            int row = int.Parse(input);
            prompt = "Column for " + player;
            input = Interaction.InputBox(prompt,title,deflt,XPos,YPos);
            int column = int.Parse(input);
			  try
			  {
				  game.Set(row, column, player);
			  }
			  catch(ArgumentException e)
			  {
				  Console.WriteLine(e.Message + ". Try again.\n");
				  continue;
			  }
            if (player == 'x') player = 'o'; else player = 'x';    
          }
        }
    }
}
