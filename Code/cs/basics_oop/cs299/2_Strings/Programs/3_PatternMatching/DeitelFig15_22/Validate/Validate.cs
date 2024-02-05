// Fig. 15.22: Validate.cs
// Validate user information using regular expressions.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;

namespace Validate
{
   /// <summary>
   /// use regular expressions to validate strings
   /// </summary>
   public class validateForm : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label phoneLabel;
      private System.Windows.Forms.Label zipLabel;
      private System.Windows.Forms.Label stateLabel;
      private System.Windows.Forms.Label cityLabel;
      private System.Windows.Forms.Label addressLabel;
      private System.Windows.Forms.Label firstLabel;
      private System.Windows.Forms.Label lastLabel;

      private System.Windows.Forms.Button OkButton;

      private System.Windows.Forms.TextBox phoneTextBox;
      private System.Windows.Forms.TextBox zipTextBox;
      private System.Windows.Forms.TextBox stateTextBox;
      private System.Windows.Forms.TextBox cityTextBox;
      private System.Windows.Forms.TextBox addressTextBox;
      private System.Windows.Forms.TextBox firstTextBox;
      private System.Windows.Forms.TextBox lastTextBox;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      public validateForm()
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
         this.phoneLabel = new System.Windows.Forms.Label();
         this.zipLabel = new System.Windows.Forms.Label();
         this.stateLabel = new System.Windows.Forms.Label();
         this.cityLabel = new System.Windows.Forms.Label();
         this.addressLabel = new System.Windows.Forms.Label();
         this.firstLabel = new System.Windows.Forms.Label();
         this.lastLabel = new System.Windows.Forms.Label();
         this.OkButton = new System.Windows.Forms.Button();
         this.phoneTextBox = new System.Windows.Forms.TextBox();
         this.zipTextBox = new System.Windows.Forms.TextBox();
         this.stateTextBox = new System.Windows.Forms.TextBox();
         this.cityTextBox = new System.Windows.Forms.TextBox();
         this.addressTextBox = new System.Windows.Forms.TextBox();
         this.firstTextBox = new System.Windows.Forms.TextBox();
         this.lastTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // phoneLabel
         // 
         this.phoneLabel.Location = new System.Drawing.Point(10, 240);
         this.phoneLabel.Name = "phoneLabel";
         this.phoneLabel.Size = new System.Drawing.Size(80, 24);
         this.phoneLabel.TabIndex = 29;
         this.phoneLabel.Text = "Phone";
         this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // zipLabel
         // 
         this.zipLabel.Location = new System.Drawing.Point(10, 205);
         this.zipLabel.Name = "zipLabel";
         this.zipLabel.Size = new System.Drawing.Size(80, 24);
         this.zipLabel.TabIndex = 28;
         this.zipLabel.Text = "Zip";
         this.zipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // stateLabel
         // 
         this.stateLabel.Location = new System.Drawing.Point(10, 170);
         this.stateLabel.Name = "stateLabel";
         this.stateLabel.Size = new System.Drawing.Size(80, 24);
         this.stateLabel.TabIndex = 27;
         this.stateLabel.Text = "State";
         this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // cityLabel
         // 
         this.cityLabel.Location = new System.Drawing.Point(10, 135);
         this.cityLabel.Name = "cityLabel";
         this.cityLabel.Size = new System.Drawing.Size(80, 24);
         this.cityLabel.TabIndex = 26;
         this.cityLabel.Text = "City";
         this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // addressLabel
         // 
         this.addressLabel.Location = new System.Drawing.Point(10, 100);
         this.addressLabel.Name = "addressLabel";
         this.addressLabel.Size = new System.Drawing.Size(80, 24);
         this.addressLabel.TabIndex = 25;
         this.addressLabel.Text = "Address";
         this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // firstLabel
         // 
         this.firstLabel.Location = new System.Drawing.Point(10, 65);
         this.firstLabel.Name = "firstLabel";
         this.firstLabel.Size = new System.Drawing.Size(80, 24);
         this.firstLabel.TabIndex = 24;
         this.firstLabel.Text = "First Name";
         this.firstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // lastLabel
         // 
         this.lastLabel.Location = new System.Drawing.Point(10, 30);
         this.lastLabel.Name = "lastLabel";
         this.lastLabel.Size = new System.Drawing.Size(80, 24);
         this.lastLabel.TabIndex = 23;
         this.lastLabel.Text = "LastName";
         this.lastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // OkButton
         // 
         this.OkButton.Location = new System.Drawing.Point(112, 296);
         this.OkButton.Name = "OkButton";
         this.OkButton.TabIndex = 30;
         this.OkButton.Text = "OK";
         this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
         // 
         // phoneTextBox
         // 
         this.phoneTextBox.Location = new System.Drawing.Point(100, 240);
         this.phoneTextBox.Name = "phoneTextBox";
         this.phoneTextBox.Size = new System.Drawing.Size(136, 20);
         this.phoneTextBox.TabIndex = 22;
         this.phoneTextBox.Text = "";
         // 
         // zipTextBox
         // 
         this.zipTextBox.Location = new System.Drawing.Point(100, 205);
         this.zipTextBox.Name = "zipTextBox";
         this.zipTextBox.Size = new System.Drawing.Size(136, 20);
         this.zipTextBox.TabIndex = 21;
         this.zipTextBox.Text = "";
         // 
         // stateTextBox
         // 
         this.stateTextBox.Location = new System.Drawing.Point(100, 170);
         this.stateTextBox.Name = "stateTextBox";
         this.stateTextBox.Size = new System.Drawing.Size(136, 20);
         this.stateTextBox.TabIndex = 20;
         this.stateTextBox.Text = "";
         // 
         // cityTextBox
         // 
         this.cityTextBox.Location = new System.Drawing.Point(100, 135);
         this.cityTextBox.Name = "cityTextBox";
         this.cityTextBox.Size = new System.Drawing.Size(136, 20);
         this.cityTextBox.TabIndex = 19;
         this.cityTextBox.Text = "";
         // 
         // addressTextBox
         // 
         this.addressTextBox.Location = new System.Drawing.Point(100, 100);
         this.addressTextBox.Name = "addressTextBox";
         this.addressTextBox.Size = new System.Drawing.Size(136, 20);
         this.addressTextBox.TabIndex = 18;
         this.addressTextBox.Text = "";
         // 
         // firstTextBox
         // 
         this.firstTextBox.Location = new System.Drawing.Point(100, 65);
         this.firstTextBox.Name = "firstTextBox";
         this.firstTextBox.Size = new System.Drawing.Size(136, 20);
         this.firstTextBox.TabIndex = 17;
         this.firstTextBox.Text = "";
         // 
         // lastTextBox
         // 
         this.lastTextBox.Location = new System.Drawing.Point(100, 30);
         this.lastTextBox.Name = "lastTextBox";
         this.lastTextBox.Size = new System.Drawing.Size(136, 20);
         this.lastTextBox.TabIndex = 16;
         this.lastTextBox.Text = "";
         // 
         // validateForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(312, 341);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.phoneLabel,
                                                                      this.zipLabel,
                                                                      this.stateLabel,
                                                                      this.cityLabel,
                                                                      this.addressLabel,
                                                                      this.firstLabel,
                                                                      this.lastLabel,
                                                                      this.OkButton,
                                                                      this.phoneTextBox,
                                                                      this.zipTextBox,
                                                                      this.stateTextBox,
                                                                      this.cityTextBox,
                                                                      this.addressTextBox,
                                                                      this.firstTextBox,
                                                                      this.lastTextBox});
         this.Name = "validateForm";
         this.Text = "Validate";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(new validateForm());
      }

      // handles OkButton Click event
      private void OkButton_Click(object sender, System.EventArgs e)
      {
         // ensures no textboxes are empty
         if ( lastTextBox.Text == "" || firstTextBox.Text == "" ||
            addressTextBox.Text == "" || cityTextBox.Text == "" ||
            stateTextBox.Text == "" || zipTextBox.Text == "" ||
            phoneTextBox.Text == "" )
         {
            // display popup box
            MessageBox.Show( "Please fill in all fields", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error );

            // set focus to lastTextBox
            lastTextBox.Focus();

            return;
         }

         // if last name format invalid show message
         if ( !Regex.Match( lastTextBox.Text, 
            @"^[A-Z][a-zA-Z]*$" ).Success )
         {
            // last name was incorrect
            MessageBox.Show( "Invalid Last Name", "Message",
               MessageBoxButtons.OK, MessageBoxIcon.Error );
            lastTextBox.Focus();

            return;
         }

         // if first name format invalid show message
         if ( !Regex.Match( firstTextBox.Text, 
            @"^[A-Z][a-zA-Z]*$" ).Success )
         {
            // first name was incorrect
            MessageBox.Show( "Invalid First Name", "Message",
               MessageBoxButtons.OK, MessageBoxIcon.Error );
            firstTextBox.Focus();

            return;
         }

         // if address format invalid show message
         if ( !Regex.Match( addressTextBox.Text, 
            @"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$" ).Success )
         {
            // address was incorrect
            MessageBox.Show( "Invalid Address", "Message",
               MessageBoxButtons.OK, MessageBoxIcon.Error );
            addressTextBox.Focus();

            return;
         }

         // if city format invalid show message
         if ( !Regex.Match( cityTextBox.Text, 
            @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$" ).Success )
         {
            // city was incorrect
            MessageBox.Show( "Invalid City", "Message",
               MessageBoxButtons.OK, MessageBoxIcon.Error );
            cityTextBox.Focus();

            return;
         }

         // if state format invalid show message
         if ( !Regex.Match( stateTextBox.Text, 
            @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$" ).Success )
         {
            // state was incorrect
            MessageBox.Show( "Invalid State", "Message",
               MessageBoxButtons.OK, MessageBoxIcon.Error );
            stateTextBox.Focus();

            return;
         }

         // if zip code format invalid show message
         if ( !Regex.Match( zipTextBox.Text, @"^\d{5}$" ).Success )
         {
            // zip was incorrect
            MessageBox.Show( "Invalid Zip Code", "Message",
               MessageBoxButtons.OK, MessageBoxIcon.Error );
            zipTextBox.Focus();

            return;
         }

         // if phone number format invalid show message
         if ( !Regex.Match( phoneTextBox.Text, 
            @"^[1-9]\d{2}-[1-9]\d{2}-\d{4}$" ).Success )
         {
            // phone number was incorrect
            MessageBox.Show( "Invalid Phone Number", "Message",
               MessageBoxButtons.OK, MessageBoxIcon.Error );
            phoneTextBox.Focus();

            return;
         }

         // information is valid, signal user and exit application
         this.Hide();
         MessageBox.Show( "Thank You!", "Information Correct",
            MessageBoxButtons.OK, MessageBoxIcon.Information );

         Application.Exit();

      } // end method OkButton_Click

   } // end class validateForm
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
