// Fig. 16.18: DrawArcs.cs
// Drawing various arcs on a form.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DrawArcs
{
   /// <summary>
   /// draws various arcs
   /// </summary>
   public class DrawArcs : System.Windows.Forms.Form
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private 
         System.ComponentModel.Container components = null;

      public DrawArcs()
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
         // arcForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.BackColor = System.Drawing.SystemColors.ControlLight;
         this.ClientSize = new System.Drawing.Size(292, 221);
         this.Name = "arcForm";
         this.Text = "Drawing Arcs";
         this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawArcs_Paint);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new DrawArcs() );
      }

      private void DrawArcs_Paint(
         object sender, 
         System.Windows.Forms.PaintEventArgs e )
      {
         // get graphics object
         Graphics graphicsObject = e.Graphics;
         Rectangle rectangle1 = 
            new Rectangle( 15, 35, 80, 80 );
         SolidBrush brush1 = 
            new SolidBrush( Color.Firebrick );
         Pen pen1 = new Pen( brush1, 1 );
         SolidBrush brush2 = new SolidBrush( Color.DarkBlue );
         Pen pen2 = new Pen( brush2, 1 );

         // start at 0 and sweep 360 degrees
         graphicsObject.DrawRectangle( pen1, rectangle1 );
         graphicsObject.DrawArc( pen2, rectangle1, 0, 360 );

         // start at 0 and sweep 110 degrees
         rectangle1.Location = new Point( 100, 35 );
         graphicsObject.DrawRectangle( pen1, rectangle1 );
         graphicsObject.DrawArc( pen2, rectangle1, 0, 110 );

         // start at 0 and sweep -270 degrees
         rectangle1.Location = new Point( 185, 35 );
         graphicsObject.DrawRectangle( pen1, rectangle1 );
         graphicsObject.DrawArc( pen2, rectangle1, 0, -270 );

         // start at 0 and sweep 360 degrees
         rectangle1.Location = new Point( 15, 120 );
         rectangle1.Size = new Size( 80, 40 );
         graphicsObject.DrawRectangle( pen1, rectangle1 );
         graphicsObject.FillPie( brush2, rectangle1, 0, 360 );

         // start at 270 and sweep -90 degrees
         rectangle1.Location = new Point( 100, 120 );
         graphicsObject.DrawRectangle( pen1, rectangle1 );
         graphicsObject.FillPie( 
            brush2, rectangle1, 270, -90 );

         // start at 0 and sweep -270 degrees
         rectangle1.Location = new Point( 185, 120 );
         graphicsObject.DrawRectangle( pen1, rectangle1 );
         graphicsObject.FillPie( 
            brush2, rectangle1, 0, -270 );

      } // end method DrawArcs_Paint

   } // end class DrawArcs
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