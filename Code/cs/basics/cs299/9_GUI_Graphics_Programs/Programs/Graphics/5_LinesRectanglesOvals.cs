// Fig. 16.14: LinesRectanglesOvals.cs
// Demonstrating lines, rectangles and ovals.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DrawingShapes
{
   /// <summary>
   /// draws shapes on the Form
   /// </summary>
   public class LinesRectanglesOvals : System.Windows.Forms.Form
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      // default constructor
      public LinesRectanglesOvals()
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
         // LinesRectanglesOvals
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(488, 149);
         this.Name = "LinesRectanglesOvals";
         this.Text = "LinesRectanglesOvals";

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(new LinesRectanglesOvals());
      }

      protected override void OnPaint(
         PaintEventArgs paintEvent )
      {
         // get graphics object
         Graphics g = paintEvent.Graphics;
         SolidBrush brush = new SolidBrush( Color.Blue );
         Pen pen = new Pen( Color.AliceBlue );

         // create filled rectangle
         g.FillRectangle( brush, 90, 30, 150, 90 );

         // draw lines to connect rectangles
         g.DrawLine( pen, 90, 30, 110, 40 );
         g.DrawLine( pen, 90, 120, 110, 130 );
         g.DrawLine( pen, 240, 30, 260, 40 );
         g.DrawLine( pen, 240, 120, 260, 130 );

         // draw top rectangle
         g.DrawRectangle( pen, 110, 40, 150, 90 );

         // set brush to red
         brush.Color = Color.Red;

         // draw base Ellipse
         g.FillEllipse( brush, 280, 75, 100, 50 );

         // draw connecting lines
         g.DrawLine( pen, 380, 55, 380, 100 );
         g.DrawLine( pen, 280, 55, 280, 100 );

         // draw Ellipse outline
         g.DrawEllipse( pen, 280, 30, 100, 50 );

      } // end method OnPaint

   } // end class LinesRectanglesOvals
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
