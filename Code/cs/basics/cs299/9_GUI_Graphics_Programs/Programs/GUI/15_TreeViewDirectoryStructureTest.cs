// Fig. 13.21: TreeViewDirectoryStructureTest.cs
// Using TreeView to display directory structure

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace UsingTreeView
{
   /// <summary>
   /// displays the structure of directories in a TreeView
   /// </summary>
   public class TreeViewDirectoryStructureTest 
      : System.Windows.Forms.Form
   {
      // contains view of c: drive directory structure
      private System.Windows.Forms.TreeView directoryTreeView;
   	private System.Windows.Forms.ImageList imageList1;
   	private System.ComponentModel.IContainer components;

      // default constructor
      public TreeViewDirectoryStructureTest()
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
		  this.directoryTreeView = new System.Windows.Forms.TreeView();
		  this.imageList1 = new System.Windows.Forms.ImageList(this.components);
		  this.SuspendLayout();
		  // 
		  // directoryTreeView
		  // 
		  this.directoryTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
		  this.directoryTreeView.ImageIndex = -1;
		  this.directoryTreeView.Location = new System.Drawing.Point(0, 0);
		  this.directoryTreeView.Name = "directoryTreeView";
		  this.directoryTreeView.SelectedImageIndex = -1;
		  this.directoryTreeView.Size = new System.Drawing.Size(292, 273);
		  this.directoryTreeView.TabIndex = 1;
		  // 
		  // imageList1
		  // 
		  this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
		  this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
		  // 
		  // TreeViewDirectoryStructureTest
		  // 
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(292, 273);
		  this.Controls.Add(this.directoryTreeView);
		  this.Name = "TreeViewDirectoryStructureTest";
		  this.Text = "TreeViewDirectoryStructureTest";
		  this.Load += new System.EventHandler(this.TreeViewDirectoryStructureTest_Load);
		  this.ResumeLayout(false);

	  }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(
            new TreeViewDirectoryStructureTest());		  
      }

      public void PopulateTreeView( 
         string directoryValue, TreeNode parentNode )
      {
         // populate current node with subdirectories
         string[] directoryArray = 
            Directory.GetDirectories( directoryValue );

         // populate current node with subdirectories
         try
         {
			Console.WriteLine("Populating");
            if ( directoryArray.Length != 0 )
            {
               // for every subdirectory, create new TreeNode,
               // add as child of current node and recursively
               // populate child nodes with subdirectories
               foreach ( string directory in directoryArray )
               {
                  // create TreeNode for current directory
                  TreeNode myNode = new TreeNode( directory );

                  // add current directory node to parent node
                  parentNode.Nodes.Add( myNode );

                  // recursively populate every subdirectory
                  PopulateTreeView( directory, myNode );
               }

            } // end if
         }

            // catch exception
         catch ( UnauthorizedAccessException )
         {  
            parentNode.Nodes.Add( "Access denied" );
         }
                                         
      } // end PopulateTreeView 

      // called by system when form loads
      private void TreeViewDirectoryStructureTest_Load(
         object sender, System.EventArgs e)
      {
         // add c:\ drive to directoryTreeView and 
         // insert its subfolders
         directoryTreeView.Nodes.Add( "C:\\" );
         PopulateTreeView( 
            "C:\\", directoryTreeView.Nodes[ 0 ] );
		  Console.WriteLine("\nFinished");
      } 

   } // end class TreeViewDirectoryStructure
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
