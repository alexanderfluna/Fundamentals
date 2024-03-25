// Fig 13.4: MenuTest.cs
// Using menus to change font colors and styles.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace UsingMenus
{
   /// <summary>
   /// allows user to change font characteristics of text
   /// through interaction with a menu
   /// </summary>
   public class MenuTest : System.Windows.Forms.Form
   {
      // display label
      private System.Windows.Forms.Label displayLabel;

      // main menu (contains file and format menu)
      private System.Windows.Forms.MainMenu mainMenu;
      
      // file menu
      private System.Windows.Forms.MenuItem fileMenuItem;
      private System.Windows.Forms.MenuItem aboutMenuItem;
      private System.Windows.Forms.MenuItem exitMenuItem;

      // format menu
      private System.Windows.Forms.MenuItem formatMenuItem;

      // color submenu
      private System.Windows.Forms.MenuItem colorMenuItem;
      private System.Windows.Forms.MenuItem blackMenuItem;
      private System.Windows.Forms.MenuItem blueMenuItem;
      private System.Windows.Forms.MenuItem redMenuItem;
      private System.Windows.Forms.MenuItem greenMenuItem;

      // font submenu
      private System.Windows.Forms.MenuItem timesMenuItem;
      private System.Windows.Forms.MenuItem courierMenuItem;
      private System.Windows.Forms.MenuItem comicMenuItem;
      private System.Windows.Forms.MenuItem boldMenuItem;
      private System.Windows.Forms.MenuItem italicMenuItem;
      private System.Windows.Forms.MenuItem fontMenuItem;

      
      private System.Windows.Forms.MenuItem separatorMenuItem;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private 
         System.ComponentModel.Container components = null;

      // default constructor
      public MenuTest()
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
         this.displayLabel = new System.Windows.Forms.Label();
         this.mainMenu = new System.Windows.Forms.MainMenu();
         this.fileMenuItem = new System.Windows.Forms.MenuItem();
         this.aboutMenuItem = new System.Windows.Forms.MenuItem();
         this.exitMenuItem = new System.Windows.Forms.MenuItem();
         this.formatMenuItem = new System.Windows.Forms.MenuItem();
         this.colorMenuItem = new System.Windows.Forms.MenuItem();
         this.blackMenuItem = new System.Windows.Forms.MenuItem();
         this.blueMenuItem = new System.Windows.Forms.MenuItem();
         this.redMenuItem = new System.Windows.Forms.MenuItem();
         this.greenMenuItem = new System.Windows.Forms.MenuItem();
         this.fontMenuItem = new System.Windows.Forms.MenuItem();
         this.timesMenuItem = new System.Windows.Forms.MenuItem();
         this.courierMenuItem = new System.Windows.Forms.MenuItem();
         this.comicMenuItem = new System.Windows.Forms.MenuItem();
         this.separatorMenuItem = new System.Windows.Forms.MenuItem();
         this.boldMenuItem = new System.Windows.Forms.MenuItem();
         this.italicMenuItem = new System.Windows.Forms.MenuItem();
         this.SuspendLayout();
         // 
         // displayLabel
         // 
         this.displayLabel.Font = new System.Drawing.Font("Times New Roman", 14F);
         this.displayLabel.Location = new System.Drawing.Point(16, 8);
         this.displayLabel.Name = "displayLabel";
         this.displayLabel.Size = new System.Drawing.Size(264, 88);
         this.displayLabel.TabIndex = 0;
         this.displayLabel.Text = "Use the Format menu to change the appearance of this text.";
         // 
         // mainMenu
         // 
         this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                 this.fileMenuItem,
                                                                                 this.formatMenuItem});
         // 
         // fileMenuItem
         // 
         this.fileMenuItem.Index = 0;
         this.fileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                     this.aboutMenuItem,
                                                                                     this.exitMenuItem});
         this.fileMenuItem.Text = "File";
         // 
         // aboutMenuItem
         // 
         this.aboutMenuItem.Index = 0;
         this.aboutMenuItem.Text = "About";
         this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
         // 
         // exitMenuItem
         // 
         this.exitMenuItem.Index = 1;
         this.exitMenuItem.Text = "Exit";
         this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
         // 
         // formatMenuItem
         // 
         this.formatMenuItem.Index = 1;
         this.formatMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                       this.colorMenuItem,
                                                                                       this.fontMenuItem});
         this.formatMenuItem.Text = "Format";
         // 
         // colorMenuItem
         // 
         this.colorMenuItem.Index = 0;
         this.colorMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                      this.blackMenuItem,
                                                                                      this.blueMenuItem,
                                                                                      this.redMenuItem,
                                                                                      this.greenMenuItem});
         this.colorMenuItem.Text = "Color";
         // 
         // blackMenuItem
         // 
         this.blackMenuItem.Index = 0;
         this.blackMenuItem.RadioCheck = true;
         this.blackMenuItem.Text = "Black";
         this.blackMenuItem.Click += new System.EventHandler(this.blackMenuItem_Click);
         // 
         // blueMenuItem
         // 
         this.blueMenuItem.Index = 1;
         this.blueMenuItem.RadioCheck = true;
         this.blueMenuItem.Text = "Blue";
         this.blueMenuItem.Click += new System.EventHandler(this.blueMenuItem_Click);
         // 
         // redMenuItem
         // 
         this.redMenuItem.Index = 2;
         this.redMenuItem.RadioCheck = true;
         this.redMenuItem.Text = "Red";
         this.redMenuItem.Click += new System.EventHandler(this.redMenuItem_Click);
         // 
         // greenMenuItem
         // 
         this.greenMenuItem.Index = 3;
         this.greenMenuItem.RadioCheck = true;
         this.greenMenuItem.Text = "Green";
         this.greenMenuItem.Click += new System.EventHandler(this.greenMenuItem_Click);
         // 
         // fontMenuItem
         // 
         this.fontMenuItem.Index = 1;
         this.fontMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                     this.timesMenuItem,
                                                                                     this.courierMenuItem,
                                                                                     this.comicMenuItem,
                                                                                     this.separatorMenuItem,
                                                                                     this.boldMenuItem,
                                                                                     this.italicMenuItem});
         this.fontMenuItem.Text = "Font";
         // 
         // timesMenuItem
         // 
         this.timesMenuItem.Index = 0;
         this.timesMenuItem.Text = "Times New Roman";
         this.timesMenuItem.Click += new System.EventHandler(this.timesMenuItem_Click);
         // 
         // courierMenuItem
         // 
         this.courierMenuItem.Index = 1;
         this.courierMenuItem.Text = "Courier";
         this.courierMenuItem.Click += new System.EventHandler(this.courierMenuItem_Click);
         // 
         // comicMenuItem
         // 
         this.comicMenuItem.Index = 2;
         this.comicMenuItem.Text = "Comic Sans";
         this.comicMenuItem.Click += new System.EventHandler(this.comicMenuItem_Click);
         // 
         // separatorMenuItem
         // 
         this.separatorMenuItem.Index = 3;
         this.separatorMenuItem.Text = "-";
         // 
         // boldMenuItem
         // 
         this.boldMenuItem.Index = 4;
         this.boldMenuItem.Text = "Bold";
         this.boldMenuItem.Click += new System.EventHandler(this.boldMenuItem_Click);
         // 
         // italicMenuItem
         // 
         this.italicMenuItem.Index = 5;
         this.italicMenuItem.Text = "Italic";
         this.italicMenuItem.Click += new System.EventHandler(this.italicMenuItem_Click);
         // 
         // MenuTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 97);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.displayLabel});
         this.Menu = this.mainMenu;
         this.Name = "MenuTest";
         this.Text = "MenuTest";
         this.ResumeLayout(false);

      }
      #endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new MenuTest() );
      }

      // display MessageBox
      private void aboutMenuItem_Click(
         object sender, System.EventArgs e )
      {
         MessageBox.Show( 
            "This is an example\nof using menus.",
            "About", MessageBoxButtons.OK, 
            MessageBoxIcon.Information );
      }

      // exit program
      private void exitMenuItem_Click(
         object sender, System.EventArgs e )
      {
         Application.Exit();
      }

      // reset color
      private void ClearColor()
      {
         // clear all checkmarks
         blackMenuItem.Checked = false;
         blueMenuItem.Checked = false;
         redMenuItem.Checked = false;
         greenMenuItem.Checked = false;
      }

      // update menu state and color display black
      private void blackMenuItem_Click(
         object sender, System.EventArgs e )
      {
         // reset checkmarks for color menu items
         ClearColor();

         // set color to black
         displayLabel.ForeColor = Color.Black;
         blackMenuItem.Checked = true;
      }

      // update menu state and color display blue
      private void blueMenuItem_Click(
         object sender, System.EventArgs e )
      {
         // reset checkmarks for color menu items
         ClearColor();

         // set color to blue
         displayLabel.ForeColor = Color.Blue;
         blueMenuItem.Checked = true;
      }

      // update menu state and color display red
      private void redMenuItem_Click(
         object sender, System.EventArgs e )
      {
         // reset checkmarks for color menu items
         ClearColor();

         // set color to red
         displayLabel.ForeColor = Color.Red;
         redMenuItem.Checked = true;
      }

      // update menu state and color display green
      private void greenMenuItem_Click(
         object sender, System.EventArgs e )
      {
         // reset checkmarks for color menu items
         ClearColor();

         // set color to green
         displayLabel.ForeColor = Color.Green;
         greenMenuItem.Checked = true;
      }

      // reset font types
      private void ClearFont()
      {
         // clear all checkmarks
         timesMenuItem.Checked = false;
         courierMenuItem.Checked = false;
         comicMenuItem.Checked = false;
      }

      // update menu state and set font to Times
      private void timesMenuItem_Click(
         object sender, System.EventArgs e )
      {
         // reset checkmarks for font menu items
         ClearFont();

         // set Times New Roman font
         timesMenuItem.Checked = true;
         displayLabel.Font = new Font( 
            "Times New Roman", 14, displayLabel.Font.Style );
      }

      // update menu state and set font to Courier
      private void courierMenuItem_Click(
         object sender, System.EventArgs e )
      {
         // reset checkmarks for font menu items
         ClearFont();

         // set Courier font
         courierMenuItem.Checked = true;
         displayLabel.Font = new Font( 
            "Courier New", 14, displayLabel.Font.Style );
      }

      // update menu state and set font to Comic Sans MS
      private void comicMenuItem_Click(
         object sender, System.EventArgs e )
      {
         // reset checkmarks for font menu items
         ClearFont();

         // set Comic Sans font
         comicMenuItem.Checked = true;
         displayLabel.Font = new Font( 
            "Comic Sans MS", 14, displayLabel.Font.Style );
      }

      // toggle checkmark and toggle bold style
      private void boldMenuItem_Click(
         object sender, System.EventArgs e )
      {
         // toggle checkmark
         boldMenuItem.Checked = !boldMenuItem.Checked;

         // use Xor to toggle bold, keep all other styles
         displayLabel.Font = new Font( 
            displayLabel.Font.FontFamily, 14,
            displayLabel.Font.Style ^ FontStyle.Bold );
      }

      // toggle checkmark and toggle italic style
      private void italicMenuItem_Click(
         object sender, System.EventArgs e)
      {
         // toggle checkmark
         italicMenuItem.Checked = !italicMenuItem.Checked;

         // use Xor to toggle bold, keep all other styles
         displayLabel.Font = new Font( 
            displayLabel.Font.FontFamily, 14,
            displayLabel.Font.Style ^ FontStyle.Italic );
      }

   } // end class MenuTest
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
