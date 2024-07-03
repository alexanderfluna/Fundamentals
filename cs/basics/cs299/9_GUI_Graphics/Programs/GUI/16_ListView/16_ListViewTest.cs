// Fig. 13.24: ListViewTest.cs
// Displaying directories and their contents in ListView.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace UsingListView
{
   /// <summary>
   /// allows users to browse directories
   /// </summary>
   public class ListViewTest : System.Windows.Forms.Form
   {
      // display labels for current location 
      // in directory tree     
      private System.Windows.Forms.Label currentLabel;
      private System.Windows.Forms.Label displayLabel;

      // display contents of current directory
      private System.Windows.Forms.ListView browserListView;
      private System.ComponentModel.IContainer components;

      // specifies images for file icons and folder icons
      private System.Windows.Forms.ImageList fileFolder;

      // get current directory
      string currentDirectory = 
         Directory.GetCurrentDirectory();

      // default constructor
      public ListViewTest()
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
         this.components = new System.ComponentModel.Container();
         this.browserListView = new System.Windows.Forms.ListView();
         this.displayLabel = new System.Windows.Forms.Label();
         this.currentLabel = new System.Windows.Forms.Label();
         this.fileFolder = new System.Windows.Forms.ImageList(this.components);
         this.SuspendLayout();
         // 
         // browserListView
         // 
         this.browserListView.Location = new System.Drawing.Point(24, 88);
         this.browserListView.Name = "browserListView";
         this.browserListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
         this.browserListView.Size = new System.Drawing.Size(448, 232);
         this.browserListView.SmallImageList = this.fileFolder;
         this.browserListView.TabIndex = 5;
         this.browserListView.View = System.Windows.Forms.View.List;
         this.browserListView.Click += new System.EventHandler(this.browserListView_Click);
         // 
         // displayLabel
         // 
         this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.displayLabel.ForeColor = System.Drawing.SystemColors.WindowText;
         this.displayLabel.Location = new System.Drawing.Point(136, 16);
         this.displayLabel.Name = "displayLabel";
         this.displayLabel.Size = new System.Drawing.Size(344, 56);
         this.displayLabel.TabIndex = 4;
         // 
         // currentLabel
         // 
         this.currentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.currentLabel.ForeColor = System.Drawing.SystemColors.WindowText;
         this.currentLabel.Location = new System.Drawing.Point(24, 16);
         this.currentLabel.Name = "currentLabel";
         this.currentLabel.Size = new System.Drawing.Size(112, 23);
         this.currentLabel.TabIndex = 3;
         this.currentLabel.Text = "Now in Directory:";
         // 
         // fileFolder
         // 
         this.fileFolder.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
         this.fileFolder.ImageSize = new System.Drawing.Size(16, 16);
         this.fileFolder.TransparentColor = System.Drawing.Color.Transparent;
         // 
         // ListViewTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(568, 349);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.browserListView,
                                                                      this.displayLabel,
                                                                      this.currentLabel});
         this.Name = "ListViewTest";
         this.Text = "ListViewTest";
         this.Load += new System.EventHandler(this.ListViewTest_Load);
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new ListViewTest() );
      }

      // browse directory user clicked or go up one level
      private void browserListView_Click(
         object sender, System.EventArgs e )
      {
         // ensure item selected
         if ( browserListView.SelectedItems.Count != 0 )
         {
            // if first item selected, go up one level
            if ( browserListView.Items[ 0 ].Selected )
            {
               // create DirectoryInfo object for directory
               DirectoryInfo directoryObject = 
                  new DirectoryInfo( currentDirectory );

               // if directory has parent, load it
               if ( directoryObject.Parent != null )
                  LoadFilesInDirectory( 
                     directoryObject.Parent.FullName );
            }

               // selected directory or file
            else
            {
               // directory or file chosen
               string chosen = 
                  browserListView.SelectedItems[ 0 ].Text;

               // if item selected is directory
               if ( Directory.Exists( currentDirectory + 
                  "\\" + chosen ) )
               {
                  // load subdirectory
                  // if in c:\, do not need '\', 
                  // otherwise we do
                  if ( currentDirectory == "C:\\" )
                     LoadFilesInDirectory( 
                        currentDirectory + chosen );
                  else
                     LoadFilesInDirectory( 
                        currentDirectory + "\\" + chosen );
               } //end if

            } // end else
            
            // update displayLabel
            displayLabel.Text = currentDirectory;

         } // end if

      } // end method browserListView_Click

      // display files/subdirectories of current directory
      public void LoadFilesInDirectory( 
         string currentDirectoryValue )
      {
         // load directory information and display
         try
         {
            // clear ListView and set first item
            browserListView.Items.Clear();
            browserListView.Items.Add( "Go Up One Level" );

            // update current directory
            currentDirectory = currentDirectoryValue;
            DirectoryInfo newCurrentDirectory = 
               new DirectoryInfo( currentDirectory );

            // put files and directories into arrays
            DirectoryInfo[] directoryArray = 
               newCurrentDirectory.GetDirectories();

            FileInfo[] fileArray = 
               newCurrentDirectory.GetFiles();

            // add directory names to ListView
            foreach ( DirectoryInfo dir in directoryArray )
            {
               // add directory to ListView
               ListViewItem newDirectoryItem = 
                  browserListView.Items.Add( dir.Name );

               // set directory image
               newDirectoryItem.ImageIndex = 0;
            }

            // add file names to ListView
            foreach ( FileInfo file in fileArray )
            {
               // add file to ListView
               ListViewItem newFileItem = 
                  browserListView.Items.Add( file.Name );

               newFileItem.ImageIndex = 1;  // set file image
            }
         } // end try

            // access denied
         catch ( UnauthorizedAccessException exception )
         {
            MessageBox.Show( 
               "Warning: Some fields may not be " +
               "visible due to permission settings", 
               "Attention", 0, MessageBoxIcon.Warning );
         }

      } // end method LoadFilesInDirectory

      // handle load event when Form displayed for first time
      private void ListViewTest_Load(
         object sender, System.EventArgs e )
      {
         // set image list
         Image folderImage = Image.FromFile( 
            currentDirectory + "\\images\\folder.bmp" );

         Image fileImage = Image.FromFile( currentDirectory +
            "\\images\\file.bmp" );

         fileFolder.Images.Add( folderImage );
         fileFolder.Images.Add( fileImage );

         // load current directory into browserListView
         LoadFilesInDirectory( currentDirectory );
         displayLabel.Text = currentDirectory;

      }  // end method ListViewTest_Load

   } // end class ListViewTest
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
