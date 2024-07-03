// Fig 16.6: ShowColors.cs
// Using different colors in C#.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace UsingColors
{
   /// <summary>
   /// allows users to change colors using the name of 
   /// the color or argb values
   /// </summary>
   public class ShowColors : System.Windows.Forms.Form
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      // color for back rectangle
      private Color behindColor = Color.Wheat;
      private System.Windows.Forms.GroupBox nameGroup;
      private System.Windows.Forms.GroupBox colorValueGroup;
      private System.Windows.Forms.TextBox colorNameTextBox;
      private System.Windows.Forms.TextBox alphaTextBox;
      private System.Windows.Forms.TextBox redTextBox;
      private System.Windows.Forms.TextBox greenTextBox;
      private System.Windows.Forms.TextBox blueTextBox;
      private System.Windows.Forms.Button colorValueButton;
      private System.Windows.Forms.Button colorNameButton;

      // color for front rectangle
      private Color frontColor = 
         Color.FromArgb( 100, 0 , 0, 255 );

      // default constructor
      public ShowColors()
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
         this.nameGroup = new System.Windows.Forms.GroupBox();
         this.colorValueGroup = new System.Windows.Forms.GroupBox();
         this.colorNameTextBox = new System.Windows.Forms.TextBox();
         this.alphaTextBox = new System.Windows.Forms.TextBox();
         this.redTextBox = new System.Windows.Forms.TextBox();
         this.greenTextBox = new System.Windows.Forms.TextBox();
         this.blueTextBox = new System.Windows.Forms.TextBox();
         this.colorValueButton = new System.Windows.Forms.Button();
         this.colorNameButton = new System.Windows.Forms.Button();
         this.nameGroup.SuspendLayout();
         this.colorValueGroup.SuspendLayout();
         this.SuspendLayout();
         // 
         // nameGroup
         // 
         this.nameGroup.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                this.colorNameButton,
                                                                                this.colorNameTextBox});
         this.nameGroup.Location = new System.Drawing.Point(8, 184);
         this.nameGroup.Name = "nameGroup";
         this.nameGroup.Size = new System.Drawing.Size(320, 64);
         this.nameGroup.TabIndex = 0;
         this.nameGroup.TabStop = false;
         this.nameGroup.Text = "Set Back Color Name";
         // 
         // colorValueGroup
         // 
         this.colorValueGroup.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                      this.colorValueButton,
                                                                                      this.blueTextBox,
                                                                                      this.greenTextBox,
                                                                                      this.redTextBox,
                                                                                      this.alphaTextBox});
         this.colorValueGroup.Location = new System.Drawing.Point(8, 264);
         this.colorValueGroup.Name = "colorValueGroup";
         this.colorValueGroup.Size = new System.Drawing.Size(320, 56);
         this.colorValueGroup.TabIndex = 1;
         this.colorValueGroup.TabStop = false;
         this.colorValueGroup.Text = "Set Front Color Value";
         // 
         // colorNameTextBox
         // 
         this.colorNameTextBox.Location = new System.Drawing.Point(16, 24);
         this.colorNameTextBox.Name = "colorNameTextBox";
         this.colorNameTextBox.Size = new System.Drawing.Size(152, 20);
         this.colorNameTextBox.TabIndex = 0;
         this.colorNameTextBox.Text = "";
         // 
         // alphaTextBox
         // 
         this.alphaTextBox.Location = new System.Drawing.Point(16, 24);
         this.alphaTextBox.Name = "alphaTextBox";
         this.alphaTextBox.Size = new System.Drawing.Size(32, 20);
         this.alphaTextBox.TabIndex = 0;
         this.alphaTextBox.Text = "";
         // 
         // redTextBox
         // 
         this.redTextBox.Location = new System.Drawing.Point(56, 24);
         this.redTextBox.Name = "redTextBox";
         this.redTextBox.Size = new System.Drawing.Size(32, 20);
         this.redTextBox.TabIndex = 1;
         this.redTextBox.Text = "";
         // 
         // greenTextBox
         // 
         this.greenTextBox.Location = new System.Drawing.Point(96, 24);
         this.greenTextBox.Name = "greenTextBox";
         this.greenTextBox.Size = new System.Drawing.Size(32, 20);
         this.greenTextBox.TabIndex = 2;
         this.greenTextBox.Text = "";
         // 
         // blueTextBox
         // 
         this.blueTextBox.Location = new System.Drawing.Point(136, 24);
         this.blueTextBox.Name = "blueTextBox";
         this.blueTextBox.Size = new System.Drawing.Size(32, 20);
         this.blueTextBox.TabIndex = 3;
         this.blueTextBox.Text = "";
         // 
         // colorValueButton
         // 
         this.colorValueButton.Location = new System.Drawing.Point(192, 24);
         this.colorValueButton.Name = "colorValueButton";
         this.colorValueButton.Size = new System.Drawing.Size(104, 23);
         this.colorValueButton.TabIndex = 4;
         this.colorValueButton.Text = "Set Color Value";
         this.colorValueButton.Click += new System.EventHandler(this.colorValueButton_Click);
         // 
         // colorNameButton
         // 
         this.colorNameButton.Location = new System.Drawing.Point(192, 24);
         this.colorNameButton.Name = "colorNameButton";
         this.colorNameButton.Size = new System.Drawing.Size(104, 23);
         this.colorNameButton.TabIndex = 1;
         this.colorNameButton.Text = "Set Color Name";
         this.colorNameButton.Click += new System.EventHandler(this.colorNameButton_Click);
         // 
         // ShowColors
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(344, 333);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.colorValueGroup,
                                                                      this.nameGroup});
         this.Name = "ShowColors";
         this.Text = "ShowColors";
         this.nameGroup.ResumeLayout(false);
         this.colorValueGroup.ResumeLayout(false);
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new ShowColors() );
      }

      // override Form OnPaint method
      protected override void OnPaint( PaintEventArgs e )
      {
         Graphics graphicsObject = e.Graphics; // get graphics

         // create text brush
         SolidBrush textBrush = new SolidBrush( Color.Black );

         // create solid brush
         SolidBrush brush = new SolidBrush( Color.White ); 

         // draw white background
         graphicsObject.FillRectangle( brush, 4, 4, 275, 180 );

         // display name of behindColor
         graphicsObject.DrawString( behindColor.Name, this.Font,
            textBrush, 40, 5 );

         // set brush color and display back rectangle
         brush.Color = behindColor;

         graphicsObject.FillRectangle( brush, 45, 20, 150, 120 );

         // display Argb values of front color
         graphicsObject.DrawString( "Alpha: " + frontColor.A +
            " Red: " + frontColor.R + " Green: " + frontColor.G 
            + " Blue: " + frontColor.B, this.Font, textBrush, 
            55, 165 );

         // set brush color and display front rectangle
         brush.Color = frontColor;

         graphicsObject.FillRectangle( brush, 65, 35, 170, 130 );

      } // end method OnPaint

      // handle colorValueButton click event
      private void colorValueButton_Click( 
         object sender, System.EventArgs e )
      {
         // obtain new front color from text boxes
         frontColor = Color.FromArgb( Convert.ToInt32( 
            alphaTextBox.Text ), 
            Convert.ToInt32( redTextBox.Text ),
            Convert.ToInt32( greenTextBox.Text ), 
            Convert.ToInt32( blueTextBox.Text ) );

         Invalidate(); // refresh Form
      }

      // handle colorNameButton click event
      private void colorNameButton_Click( 
         object sender, System.EventArgs e )
      {
         // set behindColor to color specified in text box
         behindColor = Color.FromName( colorNameTextBox.Text );

         Invalidate(); // refresh Form
      } 

   } // end class ShowColors
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
