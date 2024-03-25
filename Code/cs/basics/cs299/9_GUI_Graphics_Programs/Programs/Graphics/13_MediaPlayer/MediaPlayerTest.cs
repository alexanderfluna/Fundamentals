// Fig. 16.27: MediaPlayerTest.cs
// Demonstrates the Windows Media Player control

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MediaPlayerTest
{
	// allows users to play media files using a
   // Windows Media Player control
	public class MediaPlayer : System.Windows.Forms.Form
	{
      private System.Windows.Forms.OpenFileDialog openMediaFileDialog;
      private System.Windows.Forms.MainMenu applicationMenu;
      private AxMediaPlayer.AxMediaPlayer player;
      private System.Windows.Forms.MenuItem fileItem;
      private System.Windows.Forms.MenuItem openItem;
      private System.Windows.Forms.MenuItem exitItem;
      private System.Windows.Forms.MenuItem aboutItem;
      private System.Windows.Forms.MenuItem aboutMessageItem;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MediaPlayer()
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
         System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MediaPlayer));
         this.player = new AxMediaPlayer.AxMediaPlayer();
         this.openMediaFileDialog = new System.Windows.Forms.OpenFileDialog();
         this.applicationMenu = new System.Windows.Forms.MainMenu();
         this.fileItem = new System.Windows.Forms.MenuItem();
         this.openItem = new System.Windows.Forms.MenuItem();
         this.exitItem = new System.Windows.Forms.MenuItem();
         this.aboutItem = new System.Windows.Forms.MenuItem();
         this.aboutMessageItem = new System.Windows.Forms.MenuItem();
         ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
         this.SuspendLayout();
         // 
         // player
         // 
         this.player.Name = "player";
         this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
         this.player.Size = new System.Drawing.Size(312, 304);
         this.player.TabIndex = 0;
         // 
         // applicationMenu
         // 
         this.applicationMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                        this.fileItem,
                                                                                        this.aboutItem});
         // 
         // fileItem
         // 
         this.fileItem.Index = 0;
         this.fileItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                 this.openItem,
                                                                                 this.exitItem});
         this.fileItem.Text = "File";
         // 
         // openItem
         // 
         this.openItem.Index = 0;
         this.openItem.Text = "Open";
         this.openItem.Click += new System.EventHandler(this.openItem_Click);
         // 
         // exitItem
         // 
         this.exitItem.Index = 1;
         this.exitItem.Text = "Exit";
         this.exitItem.Click += new System.EventHandler(this.exitItem_Click);
         // 
         // aboutItem
         // 
         this.aboutItem.Index = 1;
         this.aboutItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                  this.aboutMessageItem});
         this.aboutItem.Text = "About";
         // 
         // aboutMessageItem
         // 
         this.aboutMessageItem.Index = 0;
         this.aboutMessageItem.Text = "About Windows Media Player";
         this.aboutMessageItem.Click += new System.EventHandler(this.aboutMessageItem_Click);
         // 
         // MediaPlayer
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(312, 305);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.player});
         this.Menu = this.applicationMenu;
         this.Name = "MediaPlayer";
         this.Text = "MediaPlayer";
         ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
         this.ResumeLayout(false);

      }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run( new MediaPlayer() );
		}

      // open new media file in Windows Media Player
      private void openItem_Click(
         object sender, System.EventArgs e)
      {
         openMediaFileDialog.ShowDialog();

         player.FileName = openMediaFileDialog.FileName;

         // adjust the size of the Media Player control and
         // the Form according to the size of the image
         player.Size = new Size( player.ImageSourceWidth,
            player.ImageSourceHeight );

         this.Size = new Size( player.Size.Width + 20,
            player.Size.Height + 60 );

      } // end method openItem_Click

      private void exitItem_Click(
         object sender, System.EventArgs e)
      {
         Application.Exit();

      } // end method exitItem_Click

      private void aboutMessageItem_Click(
         object sender, System.EventArgs e)
      {
         player.AboutBox();
      
      } // end method aboutMessageItem_Click

	} // end class MediaPlayer

} // end namespace MediaPlayerTest

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
