// Fig 16.9: UsingFonts.cs
// Demonstrating various font settings.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FontTest
{
   /// <summary>
   /// demonstrate font constructors and properties
   /// </summary>
   public class UsingFonts : System.Windows.Forms.Form
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      // default constructor
      public UsingFonts()
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
         // 
         // UsingFonts
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(504, 109);
         this.Name = "UsingFonts";
         this.Text = "UsingFonts";

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new UsingFonts() );
      }

      // demonstrate various font and style settings
      protected override void OnPaint( 
         PaintEventArgs paintEvent )
      {
         Graphics graphicsObject = paintEvent.Graphics;
         SolidBrush brush = new SolidBrush( Color.DarkBlue );

         // arial, 12 pt bold
         FontStyle style = FontStyle.Bold;
         Font arial = 
            new Font( new FontFamily( "Arial" ), 12, style );

         // times new roman, 12 pt regular
         style = FontStyle.Regular;
         Font timesNewRoman = 
            new Font( "Times New Roman", 12, style );

         // courier new, 16 pt bold and italic
         style = FontStyle.Bold | FontStyle.Italic;
         Font courierNew = new Font( "Courier New", 16, style );

         // tahoma, 18 pt strikeout
         style = FontStyle.Strikeout;
         Font tahoma = new Font( "Tahoma", 18, style );

         graphicsObject.DrawString( arial.Name + 
            " 12 point bold.", arial, brush, 10, 10 );

         graphicsObject.DrawString( timesNewRoman.Name + 
            " 12 point plain.", timesNewRoman, brush, 10, 30 );

         graphicsObject.DrawString( courierNew.Name + 
            " 16 point bold and italic.", courierNew, 
            brush, 10, 54 );

         graphicsObject.DrawString( tahoma.Name +
            " 18 point strikeout.", tahoma, brush, 10, 75 );

      } // end method OnPaint

   } // end class UsingFonts
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
