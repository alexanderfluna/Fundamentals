// Fig. 16.22: DrawStarsForm.cs
// Using paths to draw stars on the form.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Drawing2D;

namespace DrawStars
{
   /// <summary>
   /// draws randomly colored stars
   /// </summary>
   public class DrawStarsForm : System.Windows.Forms.Form
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private 
         System.ComponentModel.Container components = null;

      public DrawStarsForm()
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
         // DrawStarsForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.BackColor = System.Drawing.SystemColors.Info;
         this.ClientSize = new System.Drawing.Size(304, 285);
         this.Name = "DrawStarsForm";
         this.Text = "Drawing Stars";
         this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawStarsForm_Paint);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new DrawStarsForm() );
      }

      // create path and draw stars along it
      private void DrawStarsForm_Paint(
         object sender, 
         System.Windows.Forms.PaintEventArgs e )
      {
         Graphics graphicsObject = e.Graphics;
         Random random = new Random();
         SolidBrush brush = 
            new SolidBrush( Color.DarkMagenta );

         // x and y points of the path
         int[] xPoints = 
            { 55, 67, 109, 73, 83, 55, 27, 37, 1, 43 };
         int[] yPoints = 
            { 0, 36, 36, 54, 96, 72, 96, 54, 36, 36 };

         // create graphics path for star;
         GraphicsPath star = new GraphicsPath();

         // translate the origin to (150, 150)
         graphicsObject.TranslateTransform( 150, 150 );

         // create star from series of points
         for ( int i = 0; i <= 8; i += 2 )
            star.AddLine( xPoints[ i ], yPoints[ i ],
               xPoints[ i + 1 ], yPoints[ i + 1 ] );

         // close the shape
         star.CloseFigure();

         // rotate the origin and draw stars in random colors
         for ( int i = 1; i <= 18; i++ )
         {
            graphicsObject.RotateTransform( 20 );

            brush.Color = Color.FromArgb( 
               random.Next( 200, 255 ), random.Next( 255 ), 
               random.Next( 255 ), random.Next( 255 ) );

            graphicsObject.FillPath( brush, star );
         }

      } // end method DrawStarsForm_Paint

   } // end class DrawStarsForm
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
