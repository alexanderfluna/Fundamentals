// Fig. 16.23: DisplayLogoForm.cs
// Displaying and resizing an image.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DisplayLogo
{
   /// <summary>
   /// displays an image and allows the user to resize it
   /// </summary>
   public class DisplayLogoForm : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Button setButton;
      private System.Windows.Forms.TextBox heightTextBox;
      private System.Windows.Forms.Label heightLabel;
      private System.Windows.Forms.TextBox widthTextBox;
      private System.Windows.Forms.Label widthLabel;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private 
         System.ComponentModel.Container components = null;

      private 
         Image image = Image.FromFile( "images/Logo.gif" );
      private Graphics graphicsObject;

      public DisplayLogoForm()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();

         graphicsObject = this.CreateGraphics();
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
         this.setButton = new System.Windows.Forms.Button();
         this.heightTextBox = new System.Windows.Forms.TextBox();
         this.heightLabel = new System.Windows.Forms.Label();
         this.widthTextBox = new System.Windows.Forms.TextBox();
         this.widthLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // setButton
         // 
         this.setButton.Location = new System.Drawing.Point(456, 200);
         this.setButton.Name = "setButton";
         this.setButton.TabIndex = 9;
         this.setButton.Text = "Set";
         this.setButton.Click += new System.EventHandler(this.setButton_Click);
         // 
         // heightTextBox
         // 
         this.heightTextBox.Location = new System.Drawing.Point(440, 160);
         this.heightTextBox.Name = "heightTextBox";
         this.heightTextBox.TabIndex = 8;
         this.heightTextBox.Text = "";
         // 
         // heightLabel
         // 
         this.heightLabel.Location = new System.Drawing.Point(440, 128);
         this.heightLabel.Name = "heightLabel";
         this.heightLabel.TabIndex = 7;
         this.heightLabel.Text = "Height";
         // 
         // widthTextBox
         // 
         this.widthTextBox.Location = new System.Drawing.Point(440, 88);
         this.widthTextBox.Name = "widthTextBox";
         this.widthTextBox.TabIndex = 6;
         this.widthTextBox.Text = "";
         // 
         // widthLabel
         // 
         this.widthLabel.Location = new System.Drawing.Point(440, 56);
         this.widthLabel.Name = "widthLabel";
         this.widthLabel.TabIndex = 5;
         this.widthLabel.Text = "Width";
         // 
         // DisplayLogoForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(568, 273);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.setButton,
                                                                      this.heightTextBox,
                                                                      this.heightLabel,
                                                                      this.widthTextBox,
                                                                      this.widthLabel});
         this.Name = "DisplayLogoForm";
         this.Text = "Display Logo";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new DisplayLogoForm() );
      }

      private void setButton_Click(
         object sender, System.EventArgs e)
      {
         // get user input
         int width = Convert.ToInt32( widthTextBox.Text );
         int height = Convert.ToInt32( heightTextBox.Text );

         // if dimensions specified are too large 
         // display problem
         if ( width > 375 || height > 225 )
         {
            MessageBox.Show( "Height or Width too large" );

            return;
         }

         // clear Windows Form
         graphicsObject.Clear( this.BackColor );

         // draw image
         graphicsObject.DrawImage( 
            image, 5, 5, width, height );

      } // end method setButton_Click

   } // end class DisplayLogoForm
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