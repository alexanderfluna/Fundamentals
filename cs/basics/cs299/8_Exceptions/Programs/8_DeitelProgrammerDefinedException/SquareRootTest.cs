// Fig 11.5: SquareRootTest.cs
// Demonstrating a user-defined exception class.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace NegativeNumberSquareRoot
{   
   /// <summary>
   /// accepts input and computes the square root of that input
   /// </summary>
   public class SquareRootTest : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label inputLabel;
      private System.Windows.Forms.Label outputLabel;

      private System.Windows.Forms.TextBox inputTextBox;

      private System.Windows.Forms.Button squareRootButton;

      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      // default constructor
      public SquareRootTest()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();
      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose( bool disposing )
      {
         if ( disposing )
         {
            if ( components != null ) 
            {
               components.Dispose();
            }
         }

         base.Dispose( disposing );
      }

		#region Windows Form Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.outputLabel = new System.Windows.Forms.Label();
         this.squareRootButton = new System.Windows.Forms.Button();
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.inputLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // outputLabel
         // 
         this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.outputLabel.Location = new System.Drawing.Point(14, 71);
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size(264, 23);
         this.outputLabel.TabIndex = 2;
         // 
         // squareRootButton
         // 
         this.squareRootButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.squareRootButton.Location = new System.Drawing.Point(90, 37);
         this.squareRootButton.Name = "squareRootButton";
         this.squareRootButton.Size = new System.Drawing.Size(112, 27);
         this.squareRootButton.TabIndex = 1;
         this.squareRootButton.Text = "Square Root";
         this.squareRootButton.Click += new System.EventHandler(this.squareRootButton_Click);
         // 
         // inputTextBox
         // 
         this.inputTextBox.Location = new System.Drawing.Point(164, 8);
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.TabIndex = 3;
         this.inputTextBox.Text = "";
         // 
         // inputLabel
         // 
         this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.inputLabel.Location = new System.Drawing.Point(28, 10);
         this.inputLabel.Name = "inputLabel";
         this.inputLabel.Size = new System.Drawing.Size(124, 16);
         this.inputLabel.TabIndex = 0;
         this.inputLabel.Text = "Please enter a number:";
         // 
         // SquareRootTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 100);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.inputTextBox,
                                                                      this.outputLabel,
                                                                      this.squareRootButton,
                                                                      this.inputLabel});
         this.Name = "SquareRootTest";
         this.Text = "Computing the Square Root";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new SquareRootTest() );
      } 

      // computes the square root of its parameter; throws
      // NegativeNumberException if parameter is negative
      public double SquareRoot( double operand )
      {
         // if negative operand, throw NegativeNumberException
         if ( operand < 0 )
            throw new NegativeNumberException( 
               "Square root of negative number not permitted" );

         // compute the square root
         return Math.Sqrt( operand );

      } // end class SquareRoot

      // obtain user input, convert to double and calculate
      // square root
      private void squareRootButton_Click(
         object sender, System.EventArgs e )
      {
         outputLabel.Text = "";

         // catch any NegativeNumberExceptions thrown
         try
         {
            double result = 
               SquareRoot( Double.Parse( inputTextBox.Text ) );

            outputLabel.Text = result.ToString();
         }

            // process invalid number format
         catch ( FormatException notInteger )
         {
            MessageBox.Show( notInteger.Message, 
               "Invalid Number Format", MessageBoxButtons.OK, 
               MessageBoxIcon.Error );
         }

            // display MessageBox if negative number input
         catch ( NegativeNumberException error )
         {
            MessageBox.Show( error.Message, "Invalid Operation", 
               MessageBoxButtons.OK, MessageBoxIcon.Error );
         }

      } // end method squareRootButton_Click
     
   } // end class SquareRootTest
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
