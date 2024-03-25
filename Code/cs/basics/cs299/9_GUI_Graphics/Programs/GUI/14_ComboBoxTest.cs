// Fig. 13.16: ComboBoxTest.cs
// Using ComboBox to select shape to draw

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace UsingComboBoxes
{
   /// <summary>
   /// allows users to select the shape they wish to 
   /// draw from a combo box
   /// </summary>
   public class ComboBoxTest : System.Windows.Forms.Form
   {
      // contains shape list (circle, square, ellipse, pie)
      private System.Windows.Forms.ComboBox imageComboBox;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private 
         System.ComponentModel.Container components = null;

      // default constructor
      public ComboBoxTest()
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
         this.imageComboBox = new System.Windows.Forms.ComboBox();
         this.SuspendLayout();
         // 
         // imageComboBox
         // 
         this.imageComboBox.DropDownWidth = 121;
         this.imageComboBox.Items.AddRange(new object[] {
                                                           "Circle",
                                                           "Square",
                                                           "Ellipse",
                                                           "Pie",
                                                           "Filled Circle",
                                                           "Filled Square",
                                                           "Filled Ellipse",
                                                           "Filled Pie"});
         this.imageComboBox.Location = new System.Drawing.Point(8, 8);
         this.imageComboBox.Name = "imageComboBox";
         this.imageComboBox.Size = new System.Drawing.Size(121, 21);
         this.imageComboBox.TabIndex = 1;
         this.imageComboBox.SelectedIndexChanged += new System.EventHandler(this.imageComboBox_SelectedIndexChanged);
         // 
         // ComboBoxTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(256, 229);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.imageComboBox});
         this.Name = "ComboBoxTest";
         this.Text = "ComboBoxTest";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new ComboBoxTest() );
      }

      // get selected index, draw shape
      private void imageComboBox_SelectedIndexChanged(
         object sender, System.EventArgs e )
      {
         // create graphics object, pen and brush
         Graphics myGraphics = base.CreateGraphics();

         // create Pen using color DarkRed
         Pen myPen = new Pen( Color.DarkRed );

         // create SolidBrush using color DarkRed
         SolidBrush mySolidBrush = 
            new SolidBrush( Color.DarkRed );

         // clear drawing area setting it to color White
         myGraphics.Clear( Color.White );

         // find index, draw proper shape
         switch ( imageComboBox.SelectedIndex )
         {
            case 0: // case circle is selected
               myGraphics.DrawEllipse( 
                  myPen, 50, 50, 150, 150 );
               break;
            case 1: // case rectangle is selected
               myGraphics.DrawRectangle( 
                  myPen, 50, 50, 150, 150 );
               break;
            case 2: // case ellipse is selected
               myGraphics.DrawEllipse( 
                  myPen, 50, 85, 150, 115 );
               break;
            case 3: // case pie is selected
               myGraphics.DrawPie( 
                  myPen, 50, 50, 150, 150, 0, 45 );
               break;
            case 4: // case filled circle is selected
               myGraphics.FillEllipse( 
                  mySolidBrush, 50, 50, 150, 150 );
               break;
            case 5: // case filled rectangle is selected
               myGraphics.FillRectangle( 
                  mySolidBrush, 50, 50, 150, 150 );
               break;
            case 6: // case filled ellipse is selected
               myGraphics.FillEllipse(
                  mySolidBrush, 50, 85, 150, 115 );
               break;
            case 7: // case filled pie is selected
               myGraphics.FillPie(
                  mySolidBrush, 50, 50, 150, 150, 0, 45 );
               break;

         } // end switch

      } // end method imageComboBox_SelectedIndexChanged

   } // end class ComboBoxTest
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
