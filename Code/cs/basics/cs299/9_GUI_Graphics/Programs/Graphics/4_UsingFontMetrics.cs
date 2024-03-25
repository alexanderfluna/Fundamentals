// Fig 16.12: UsingFontMetrics.cs
// Displaying font metric information.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FontMetricsTest
{
   /// <summary>
   /// displays font information
   /// </summary>
   public class UsingFontMetrics : System.Windows.Forms.Form
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      // default constructor
      public UsingFontMetrics()
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
         // UsingFontMetrics
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(904, 237);
         this.Name = "UsingFontMetrics";
         this.Text = "UsingFontMetrics";

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(new UsingFontMetrics());
      }

      // displays font information
      protected override void OnPaint(
         PaintEventArgs paintEvent )
      {
         Graphics graphicsObject = paintEvent.Graphics;
         SolidBrush brush = new SolidBrush( Color.DarkBlue );

         // Arial font metrics
         Font arial = new Font( "Arial", 12 );
         FontFamily family = arial.FontFamily;
         Font sanSerif = new Font( "Microsoft Sans Serif",
            14, FontStyle.Italic );

         // display Arial font metrics
         graphicsObject.DrawString( "Current Font: " + 
            arial.ToString(), arial, brush, 10, 10 );

         graphicsObject.DrawString( "Ascent: " +
            family.GetCellAscent( FontStyle.Regular ), arial,
            brush, 10, 30 );

         graphicsObject.DrawString( "Descent: " +
            family.GetCellDescent( FontStyle.Regular ), arial,
            brush, 10, 50 );

         graphicsObject.DrawString( "Height: " + 
            family.GetEmHeight( FontStyle.Regular ), arial,
            brush, 10, 70 );

         graphicsObject.DrawString( "Leading: " +
            family.GetLineSpacing( FontStyle.Regular ), arial,
            brush, 10, 90 );

         // display Sans Serif font metrics
         family = sanSerif.FontFamily;

         graphicsObject.DrawString( "Current Font: " + 
            sanSerif.ToString(), sanSerif, brush, 10, 130 );

         graphicsObject.DrawString( "Ascent: " +
            family.GetCellAscent( FontStyle.Regular ), sanSerif,
            brush, 10, 150 );

         graphicsObject.DrawString( "Descent: " +
            family.GetCellDescent( FontStyle.Regular ), sanSerif, 
            brush, 10, 170 );

         graphicsObject.DrawString( "Height: " + 
            family.GetEmHeight( FontStyle.Regular ), sanSerif,
            brush, 10, 190 );

         graphicsObject.DrawString( "Leading: " +
            family.GetLineSpacing( FontStyle.Regular ), sanSerif,
            brush, 10, 210 );

      } // end method OnPaint

   } // end class UsingFontMetrics
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
