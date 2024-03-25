// Fig. 16.7: ShowColorsComplex.cs
// Change the background and text colors of a form.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace UsingComplexColors
{
   /// <summary>
   /// allows users to change colors using a ColorDialog
   /// </summary>
   public class ShowColorsComplex : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Button backgroundColorButton;
      private System.Windows.Forms.Button textColorButton;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      // default constructor
      public ShowColorsComplex()
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
         if( disposing )
         {
            if (components != null) 
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
         this.backgroundColorButton = new System.Windows.Forms.Button();
         this.textColorButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // backgroundColorButton
         // 
         this.backgroundColorButton.Location = new System.Drawing.Point(16, 16);
         this.backgroundColorButton.Name = "backgroundColorButton";
         this.backgroundColorButton.Size = new System.Drawing.Size(264, 32);
         this.backgroundColorButton.TabIndex = 0;
         this.backgroundColorButton.Text = "Change Background Color";
         this.backgroundColorButton.Click += new System.EventHandler(this.backgroundColorButton_Click);
         // 
         // textColorButton
         // 
         this.textColorButton.Location = new System.Drawing.Point(16, 64);
         this.textColorButton.Name = "textColorButton";
         this.textColorButton.Size = new System.Drawing.Size(264, 32);
         this.textColorButton.TabIndex = 1;
         this.textColorButton.Text = "Change Text Color";
         this.textColorButton.Click += new System.EventHandler(this.textColorButton_Click);
         // 
         // ShowColorsComplex
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 109);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.textColorButton,
                                                                      this.backgroundColorButton});
         this.Name = "ShowColorsComplex";
         this.Text = "ShowColorsComplex";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new ShowColorsComplex() );
      }

      // change text color
      private void textColorButton_Click(
         object sender, System.EventArgs e )
      {
         // create ColorDialog object
         ColorDialog colorChooser = new ColorDialog();
         DialogResult result;

         // get chosen color
         result = colorChooser.ShowDialog();

         if ( result == DialogResult.Cancel )
            return;
         
         // assign forecolor to result of dialog
         backgroundColorButton.ForeColor = colorChooser.Color;
         textColorButton.ForeColor = colorChooser.Color;

      } // end method textColorButton_Click

      // change background color
      private void backgroundColorButton_Click(
         object sender, System.EventArgs e )
      {
         // create ColorDialog object
         ColorDialog colorChooser = new ColorDialog();
         DialogResult result;

         // show ColorDialog and get result
         colorChooser.FullOpen = true;
         result = colorChooser.ShowDialog();

         if ( result == DialogResult.Cancel )
            return;

         // set background color
         this.BackColor = colorChooser.Color;
               
      }  // end method backgroundColorButton_Click
    
   } // end class ShowColorsComplex
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
