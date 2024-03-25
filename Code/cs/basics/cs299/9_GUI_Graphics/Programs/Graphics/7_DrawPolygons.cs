// Fig. 16.20: DrawPolygons.cs
// Demonstrating polygons.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DrawPolygons
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class PolygonForm : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Button colorButton;
      private System.Windows.Forms.Button clearButton;
      private System.Windows.Forms.GroupBox typeGroup;
      private System.Windows.Forms.RadioButton 
         filledPolygonOption;
      private System.Windows.Forms.RadioButton lineOption;
      private System.Windows.Forms.RadioButton polygonOption;
      private System.Windows.Forms.Panel drawPanel;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private 
         System.ComponentModel.Container components = null;

      // contains list of polygon vertices
      private ArrayList points = new ArrayList();

      // initialize default pen and brush
      Pen pen = new Pen( Color.DarkBlue );

      SolidBrush brush = new SolidBrush( Color.DarkBlue );

      public PolygonForm()
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
         this.colorButton = new System.Windows.Forms.Button();
         this.clearButton = new System.Windows.Forms.Button();
         this.typeGroup = new System.Windows.Forms.GroupBox();
         this.filledPolygonOption = new System.Windows.Forms.RadioButton();
         this.lineOption = new System.Windows.Forms.RadioButton();
         this.polygonOption = new System.Windows.Forms.RadioButton();
         this.drawPanel = new System.Windows.Forms.Panel();
         this.typeGroup.SuspendLayout();
         this.SuspendLayout();
         // 
         // colorButton
         // 
         this.colorButton.Location = new System.Drawing.Point(240, 192);
         this.colorButton.Name = "colorButton";
         this.colorButton.Size = new System.Drawing.Size(112, 24);
         this.colorButton.TabIndex = 7;
         this.colorButton.Text = "Change Color";
         this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
         // 
         // clearButton
         // 
         this.clearButton.Location = new System.Drawing.Point(240, 160);
         this.clearButton.Name = "clearButton";
         this.clearButton.Size = new System.Drawing.Size(112, 24);
         this.clearButton.TabIndex = 6;
         this.clearButton.Text = "Clear";
         this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
         // 
         // typeGroup
         // 
         this.typeGroup.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                this.filledPolygonOption,
                                                                                this.lineOption,
                                                                                this.polygonOption});
         this.typeGroup.Location = new System.Drawing.Point(232, 8);
         this.typeGroup.Name = "typeGroup";
         this.typeGroup.Size = new System.Drawing.Size(128, 104);
         this.typeGroup.TabIndex = 4;
         this.typeGroup.TabStop = false;
         this.typeGroup.Text = "Select Type";
         // 
         // filledPolygonOption
         // 
         this.filledPolygonOption.Location = new System.Drawing.Point(8, 80);
         this.filledPolygonOption.Name = "filledPolygonOption";
         this.filledPolygonOption.Size = new System.Drawing.Size(112, 16);
         this.filledPolygonOption.TabIndex = 2;
         this.filledPolygonOption.Text = "Filled Polygon";
         this.filledPolygonOption.CheckedChanged += new System.EventHandler(this.filledPolygonOption_CheckedChanged);
         // 
         // lineOption
         // 
         this.lineOption.Location = new System.Drawing.Point(8, 24);
         this.lineOption.Name = "lineOption";
         this.lineOption.Size = new System.Drawing.Size(112, 16);
         this.lineOption.TabIndex = 1;
         this.lineOption.Text = "Lines";
         this.lineOption.CheckedChanged += new System.EventHandler(this.lineOption_CheckedChanged);
         // 
         // polygonOption
         // 
         this.polygonOption.Location = new System.Drawing.Point(8, 48);
         this.polygonOption.Name = "polygonOption";
         this.polygonOption.Size = new System.Drawing.Size(112, 24);
         this.polygonOption.TabIndex = 0;
         this.polygonOption.Text = "Polygon";
         this.polygonOption.CheckedChanged += new System.EventHandler(this.polygonOption_CheckedChanged);
         // 
         // drawPanel
         // 
         this.drawPanel.BackColor = System.Drawing.SystemColors.Window;
         this.drawPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.drawPanel.Name = "drawPanel";
         this.drawPanel.Size = new System.Drawing.Size(232, 264);
         this.drawPanel.TabIndex = 5;
         this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
         this.drawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseDown);
         // 
         // polygonForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(360, 269);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.colorButton,
                                                                      this.clearButton,
                                                                      this.typeGroup,
                                                                      this.drawPanel});
         this.Name = "polygonForm";
         this.Text = "Drawing Polygons";
         this.typeGroup.ResumeLayout(false);
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new PolygonForm() );
      }

      // draw panel mouse down event handler
      private void drawPanel_MouseDown(
         object sender, 
         System.Windows.Forms.MouseEventArgs e )
      {
         // add mouse position to vertex list
         points.Add( new Point( e.X, e.Y ) );
         drawPanel.Invalidate(); // refresh panel
      
      } // end method drawPanel_MouseDown

      private void drawPanel_Paint(
         object sender, 
         System.Windows.Forms.PaintEventArgs e )
      {
         // get graphics object for panel
         Graphics graphicsObject = e.Graphics;

         // if arraylist has 2 or more points, display shape
         if ( points.Count > 1 )
         {
            // get array for use in drawing functions
            Point[] pointArray = 
               ( Point[] )points.ToArray( 
               points[ 0 ].GetType() );

            if ( polygonOption.Checked )

               // draw polygon
               graphicsObject.DrawPolygon( pen, pointArray );

            else if ( lineOption.Checked )

               // draw lines
               graphicsObject.DrawLines( pen, pointArray );

            else if ( filledPolygonOption.Checked )

               // draw filled
               graphicsObject.FillPolygon( 
                  brush, pointArray );
         }
      
      } // end method drawPanel_Paint

      // handle clearButton click event
      private void clearButton_Click(
         object sender, System.EventArgs e)
      {
         points = new ArrayList(); // remove points

         drawPanel.Invalidate(); // refresh panel
      
      } // end method clearButton_Click

      // handle polygon radio button CheckedChanged event
      private void polygonOption_CheckedChanged(
         object sender, System.EventArgs e)
      {
         drawPanel.Invalidate(); // refresh panel
      
      } // end method polygonOption_CheckedChanged

      // handle line radio button CheckedChanged event
      private void lineOption_CheckedChanged(
         object sender, System.EventArgs e)
      {
         drawPanel.Invalidate(); // refresh panel

      } // end method lineOption_CheckedChanged

      // handle filled polygon radio button 
      // CheckedChanged event
      private void filledPolygonOption_CheckedChanged(
         object sender, System.EventArgs e)
      {
         drawPanel.Invalidate(); // refresh panel
      
      } // end method filledPolygonOption_CheckedChanged

      // handle colorButton click event
      private void colorButton_Click(
         object sender, System.EventArgs e)
      {
         // create new color dialog
         ColorDialog dialogColor = new ColorDialog();

         // show dialog and obtain result
         DialogResult result = dialogColor.ShowDialog();

         // return if user cancels
         if ( result == DialogResult.Cancel )
            return;

         pen.Color = dialogColor.Color;   // set pen to color
         brush.Color = dialogColor.Color; // set brush
         drawPanel.Invalidate();          // refresh panel
      
      } // end method colorButton_Click

   } // end class PolygonForm
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