// Fig. 13.13: CheckedListBoxTest.cs
// Using the checked list boxes to add items to a list box

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace UsingChckedListBoxes
{
   /// <summary>
   /// allows users to add items to a list box by checking 
   /// items in a checked list box
   /// </summary>
   public class CheckedListBoxTest : System.Windows.Forms.Form
   {
      // list of available book titles      
      private System.Windows.Forms.CheckedListBox 
         inputCheckedListBox;

      // user selection list
      private System.Windows.Forms.ListBox displayListBox;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private 
         System.ComponentModel.Container components = null;

      // default constructor
      public CheckedListBoxTest()
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
         this.displayListBox = new System.Windows.Forms.ListBox();
         this.inputCheckedListBox = new System.Windows.Forms.CheckedListBox();
         this.SuspendLayout();
         // 
         // displayListBox
         // 
         this.displayListBox.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
         this.displayListBox.HorizontalScrollbar = true;
         this.displayListBox.Location = new System.Drawing.Point(184, 16);
         this.displayListBox.Name = "displayListBox";
         this.displayListBox.Size = new System.Drawing.Size(128, 121);
         this.displayListBox.TabIndex = 4;
         // 
         // inputCheckedListBox
         // 
         this.inputCheckedListBox.HorizontalScrollbar = true;
         this.inputCheckedListBox.Items.AddRange(new object[] {
                                                                 "C++ HTP",
                                                                 "Java HTP",
                                                                 "VB HTP",
                                                                 "Internet & WWW",
                                                                 "Perl HTP",
                                                                 "Python HTP",
                                                                 "Wireless Internet HTP",
                                                                 "Advanced Java HTP"});
         this.inputCheckedListBox.Location = new System.Drawing.Point(16, 16);
         this.inputCheckedListBox.Name = "inputCheckedListBox";
         this.inputCheckedListBox.Size = new System.Drawing.Size(152, 124);
         this.inputCheckedListBox.TabIndex = 3;
         this.inputCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.inputCheckedListBox_ItemCheck);
         // 
         // CheckedListBoxTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(344, 165);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.displayListBox,
                                                                      this.inputCheckedListBox});
         this.Name = "CheckedListBoxTest";
         this.Text = "CheckedListBoxTest";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(new CheckedListBoxTest());
      }

      // item about to change, 
      // add or remove from displayListBox
      private void inputCheckedListBox_ItemCheck(
         object sender, 
         System.Windows.Forms.ItemCheckEventArgs e )
      {
         // obtain reference of selected item
         string item = 
            inputCheckedListBox.SelectedItem.ToString();
         
         // if item checked add to listbox
         // otherwise remove from listbox
         if ( e.NewValue == CheckState.Checked )
            displayListBox.Items.Add( item );
         else
            displayListBox.Items.Remove( item );
         
      } // end method inputCheckedListBox_Click

   } // end class CheckedListBox
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