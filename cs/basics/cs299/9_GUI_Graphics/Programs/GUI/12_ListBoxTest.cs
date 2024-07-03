// Fig 13.11: ListBoxTest.cs
// Program to add, remove and clear list box items.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace UsingListBoxes
{
   /// <summary>
   /// allows users to add, remove and clear list box items
   /// </summary>
   public class ListBoxTest : System.Windows.Forms.Form
   {
      // contains user-input list of elements
      private System.Windows.Forms.ListBox displayListBox;

      // user input textbox
      private System.Windows.Forms.TextBox inputTextBox;

      // add, remove, clear and exit command buttons
      private System.Windows.Forms.Button addButton;
      private System.Windows.Forms.Button removeButton;
      private System.Windows.Forms.Button clearButton;
      private System.Windows.Forms.Button exitButton;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private 
         System.ComponentModel.Container components = null;

      // deafault constructor
      public ListBoxTest()
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
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.addButton = new System.Windows.Forms.Button();
         this.removeButton = new System.Windows.Forms.Button();
         this.clearButton = new System.Windows.Forms.Button();
         this.exitButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // displayListBox
         // 
         this.displayListBox.Location = new System.Drawing.Point(16, 16);
         this.displayListBox.Name = "displayListBox";
         this.displayListBox.Size = new System.Drawing.Size(120, 290);
         this.displayListBox.TabIndex = 0;
         // 
         // inputTextBox
         // 
         this.inputTextBox.Location = new System.Drawing.Point(168, 16);
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.TabIndex = 1;
         this.inputTextBox.Text = "";
         // 
         // addButton
         // 
         this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.addButton.Location = new System.Drawing.Point(168, 48);
         this.addButton.Name = "addButton";
         this.addButton.Size = new System.Drawing.Size(104, 48);
         this.addButton.TabIndex = 2;
         this.addButton.Text = "Add";
         this.addButton.Click += new System.EventHandler(this.addButton_Click);
         // 
         // removeButton
         // 
         this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.removeButton.Location = new System.Drawing.Point(168, 112);
         this.removeButton.Name = "removeButton";
         this.removeButton.Size = new System.Drawing.Size(104, 48);
         this.removeButton.TabIndex = 3;
         this.removeButton.Text = "Remove";
         this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
         // 
         // clearButton
         // 
         this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.clearButton.Location = new System.Drawing.Point(168, 176);
         this.clearButton.Name = "clearButton";
         this.clearButton.Size = new System.Drawing.Size(104, 48);
         this.clearButton.TabIndex = 4;
         this.clearButton.Text = "Clear";
         this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
         // 
         // exitButton
         // 
         this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.exitButton.Location = new System.Drawing.Point(168, 240);
         this.exitButton.Name = "exitButton";
         this.exitButton.Size = new System.Drawing.Size(104, 48);
         this.exitButton.TabIndex = 5;
         this.exitButton.Text = "Exit";
         this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
         // 
         // ListBoxTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 325);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.exitButton,
                                                                      this.clearButton,
                                                                      this.removeButton,
                                                                      this.addButton,
                                                                      this.inputTextBox,
                                                                      this.displayListBox});
         this.Name = "ListBoxTest";
         this.Text = "ListBoxTest";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new ListBoxTest() );
      }

      // add new item (text from input box) 
      // and clear input box
      private void addButton_Click(
         object sender, System.EventArgs e)
      {
         displayListBox.Items.Add( inputTextBox.Text );
         inputTextBox.Clear();
      }

      // remove item if one selected
      private void removeButton_Click(
         object sender, System.EventArgs e )
      {
         // remove only if item selected
         if ( displayListBox.SelectedIndex != -1 )
            displayListBox.Items.RemoveAt( 
               displayListBox.SelectedIndex );
      }

      // clear all items
      private void clearButton_Click(
         object sender, System.EventArgs e )
      {
         displayListBox.Items.Clear();
      }

      // exit application
      private void exitButton_Click( 
         object sender, System.EventArgs e )
      {
         Application.Exit();
      }

   } // end class ListBoxTest
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