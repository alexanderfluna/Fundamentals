// Fig. 16.21: DrawShapes.cs
// Drawing various shapes on a form.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Drawing2D;

namespace DrawShapes
{
   /// <summary>
   /// draws shapes with different brushes
   /// </summary>
   public class DrawShapesForm : System.Windows.Forms.Form
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      public DrawShapesForm()
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
         // drawShapesForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(520, 197);
         this.Name = "drawShapesForm";
         this.Text = "Drawing Shapes";
         this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawShapesForm_Paint);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new DrawShapesForm() );
      }

      // draw various shapes on form
      private void DrawShapesForm_Paint(
         object sender, System.Windows.Forms.PaintEventArgs e )
      {
         // references to object we will use
         Graphics graphicsObject = e.Graphics;

         // ellipse rectangle and gradient brush
         Rectangle drawArea1 = new Rectangle( 5, 35, 30, 100 );
         LinearGradientBrush linearBrush = 
            new LinearGradientBrush( drawArea1, Color.Blue,
            Color.Yellow, LinearGradientMode.ForwardDiagonal );

         // pen and location for red outline rectangle
         Pen thickRedPen = new Pen( Color.Red, 10 );
         Rectangle drawArea2 = new Rectangle( 80, 30, 65, 100 );

         // bitmap texture
         Bitmap textureBitmap = new Bitmap( 10, 10 );

         // get bitmap graphics
         Graphics graphicsObject2 = 
            Graphics.FromImage( textureBitmap );

         // brush and pen used throughout program
         SolidBrush solidColorBrush = 
            new SolidBrush( Color.Red );
         Pen coloredPen = new Pen( solidColorBrush );

         // draw ellipse filled with a blue-yellow gradient
         graphicsObject.FillEllipse( 
            linearBrush, 5, 30, 65, 100 );

         // draw thick rectangle outline in red
         graphicsObject.DrawRectangle( 
            thickRedPen, drawArea2 );

         // fill textureBitmap with yellow
         solidColorBrush.Color = Color.Yellow;
         graphicsObject2.FillRectangle( 
            solidColorBrush, 0, 0, 10, 10 );

         // draw small black rectangle in textureBitmap
         coloredPen.Color = Color.Black;
         graphicsObject2.DrawRectangle( 
            coloredPen, 1, 1, 6, 6 );

         // draw small blue rectangle in textureBitmpa
         solidColorBrush.Color = Color.Blue;
         graphicsObject2.FillRectangle( 
            solidColorBrush, 1, 1, 3, 3 );

         // draw small red square in textureBitmap
         solidColorBrush.Color = Color.Red;
         graphicsObject2.FillRectangle( 
            solidColorBrush, 4, 4, 3, 3 );

         // create textured brush and 
         // display textured rectangle
         TextureBrush texturedBrush = 
            new TextureBrush( textureBitmap );
         graphicsObject.FillRectangle( 
            texturedBrush, 155, 30, 75, 100 );

         // draw pie-shaped arc in white
         coloredPen.Color = Color.White;
         coloredPen.Width = 6;
         graphicsObject.DrawPie( 
            coloredPen, 240, 30, 75, 100, 0, 270 );

         // draw lines in green and yellow
         coloredPen.Color = Color.Green;
         coloredPen.Width = 5;
         graphicsObject.DrawLine( 
            coloredPen, 395, 30, 320, 150 );

         // draw a rounded, dashed yellow line
         coloredPen.Color = Color.Yellow;
         coloredPen.DashCap = DashCap.Round;
         coloredPen.DashStyle = DashStyle.Dash;
         graphicsObject.DrawLine( 
            coloredPen, 320, 30, 395, 150 );
      
      } // end method DrawShapesForm_Paint

   } // end class DrawShapesForm
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