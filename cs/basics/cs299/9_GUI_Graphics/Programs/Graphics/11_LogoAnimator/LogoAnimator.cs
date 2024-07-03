// Fig. 16.24: LogoAnimator.cs
// Program that animates a series of images.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace LogoAnimator
{
   /// <summary>
   /// animates a series of 30 images
   /// </summary>
   public class LogoAnimator : System.Windows.Forms.Form
   {
      private System.Windows.Forms.PictureBox logoPictureBox;
      private System.Windows.Forms.Timer Timer;
      private System.ComponentModel.IContainer components;

      private ArrayList images = new ArrayList();
      private int count = -1;

      public LogoAnimator()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();

         for ( int i = 0; i < 30; i++ )
            images.Add( Image.FromFile( "images/deitel" + i +
               ".gif" ) );

         // load first image
         logoPictureBox.Image = (Image) images[ 0 ];

         // set PictureBox to be the same size as Image
         logoPictureBox.Size = logoPictureBox.Image.Size;

      } // end constructor

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
         this.components = new System.ComponentModel.Container();
         this.logoPictureBox = new System.Windows.Forms.PictureBox();
         this.Timer = new System.Windows.Forms.Timer(this.components);
         this.SuspendLayout();
         // 
         // logoPictureBox
         // 
         this.logoPictureBox.Location = new System.Drawing.Point(32, 24);
         this.logoPictureBox.Name = "logoPictureBox";
         this.logoPictureBox.Size = new System.Drawing.Size(168, 88);
         this.logoPictureBox.TabIndex = 1;
         this.logoPictureBox.TabStop = false;
         // 
         // Timer
         // 
         this.Timer.Enabled = true;
         this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
         // 
         // animatorForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(232, 141);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.logoPictureBox});
         this.Name = "animatorForm";
         this.Text = "LogoAnimator";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new LogoAnimator() );
      }

      private void Timer_Tick(
         object sender, System.EventArgs e)
      {
         // increment counter
         count = ( count + 1 ) % 30;

         // load next image
         logoPictureBox.Image = ( Image )images[ count ];

      } // end method Timer_Tick

   } // end class LogoAnimator
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