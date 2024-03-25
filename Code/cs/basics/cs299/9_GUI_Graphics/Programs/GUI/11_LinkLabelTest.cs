// Fig. 13.7: LinkLabelTest.cs
// Using LinkLabels to create hyperlinks.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace UsingLinkLabels
{
   /// <summary>
   /// allows users to run application by clicking a link
   /// </summary>
   public class LinkLabelTest : System.Windows.Forms.Form
   {
      // linklabels to C: drive, www.deitel.com and Notepad
      private System.Windows.Forms.LinkLabel driveLinkLabel;
      private System.Windows.Forms.LinkLabel deitelLinkLabel;
      private System.Windows.Forms.LinkLabel notepadLinkLabel;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private 
         System.ComponentModel.Container components = null;

      // default constructor
      public LinkLabelTest()
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
         this.driveLinkLabel = new System.Windows.Forms.LinkLabel();
         this.deitelLinkLabel = new System.Windows.Forms.LinkLabel();
         this.notepadLinkLabel = new System.Windows.Forms.LinkLabel();
         this.SuspendLayout();
         // 
         // driveLinkLabel
         // 
         this.driveLinkLabel.Location = new System.Drawing.Point(64, 16);
         this.driveLinkLabel.Name = "driveLinkLabel";
         this.driveLinkLabel.TabIndex = 0;
         this.driveLinkLabel.TabStop = true;
         this.driveLinkLabel.Text = "Click to browse C:\\";
         this.driveLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.driveLinkLabel_LinkClicked);
         // 
         // deitelLinkLabel
         // 
         this.deitelLinkLabel.Location = new System.Drawing.Point(64, 56);
         this.deitelLinkLabel.Name = "deitelLinkLabel";
         this.deitelLinkLabel.Size = new System.Drawing.Size(176, 24);
         this.deitelLinkLabel.TabIndex = 1;
         this.deitelLinkLabel.TabStop = true;
         this.deitelLinkLabel.Text = "Click to visit www.deitel.com";
         this.deitelLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deitelLinkLabel_LinkClicked);
         // 
         // notepadLinkLabel
         // 
         this.notepadLinkLabel.Location = new System.Drawing.Point(64, 96);
         this.notepadLinkLabel.Name = "notepadLinkLabel";
         this.notepadLinkLabel.Size = new System.Drawing.Size(128, 32);
         this.notepadLinkLabel.TabIndex = 2;
         this.notepadLinkLabel.TabStop = true;
         this.notepadLinkLabel.Text = "Click to run Notepad";
         this.notepadLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.notepadLinkLabel_LinkClicked);
         // 
         // LinkLabelTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 149);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.notepadLinkLabel,
                                                                      this.deitelLinkLabel,
                                                                      this.driveLinkLabel});
         this.Name = "LinkLabelTest";
         this.Text = "LinkLabelTest";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(new LinkLabelTest());
      }

      // browse C:\ drive
      private void driveLinkLabel_LinkClicked( object sender, 
         System.Windows.Forms.LinkLabelLinkClickedEventArgs e )
      {
         driveLinkLabel.LinkVisited = true;
         System.Diagnostics.Process.Start( "C:\\" );
      }

      // load www.deitel.com in Web broswer
      private void deitelLinkLabel_LinkClicked( object sender, 
         System.Windows.Forms.LinkLabelLinkClickedEventArgs e )
      {
         deitelLinkLabel.LinkVisited = true;
         System.Diagnostics.Process.Start( 
            "IExplore", "http://www.deitel.com" );
      }

      // run application Notepad
      private void notepadLinkLabel_LinkClicked( 
         object sender, 
         System.Windows.Forms.LinkLabelLinkClickedEventArgs e )
      {
         notepadLinkLabel.LinkVisited = true;

         // program called as if in run
         // menu and full path not needed
         System.Diagnostics.Process.Start( "notepad" );
      }

   } // end class LinkLabelTest
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
