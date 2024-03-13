// Fig. 10.25: BubbleSortForm.cs
// Demonstrates bubble sort using delegates to determine
// the sort order.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Delegates
{
   /// <summary>
   /// Summary description for BubbleSortForm.
   /// </summary>
   public class BubbleSortForm : System.Windows.Forms.Form
   {
      private System.Windows.Forms.TextBox originalTextBox;
      private System.Windows.Forms.TextBox sortedTextBox;
      private System.Windows.Forms.Button createButton;
      private System.Windows.Forms.Button ascendingButton;
      private System.Windows.Forms.Button descendingButton;
      private System.Windows.Forms.Label originalLabel;
      private System.Windows.Forms.Label sortedLabel;

      private int[] elementArray = new int[ 10 ];

      private System.ComponentModel.Container components = null;

      public BubbleSortForm()
      {
         InitializeComponent();
      }

      protected override void Dispose( bool disposing )
      {
         if( disposing )
         {
            if(components != null)
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
         this.originalTextBox = new System.Windows.Forms.TextBox();
         this.sortedTextBox = new System.Windows.Forms.TextBox();
         this.createButton = new System.Windows.Forms.Button();
         this.ascendingButton = new System.Windows.Forms.Button();
         this.descendingButton = new System.Windows.Forms.Button();
         this.originalLabel = new System.Windows.Forms.Label();
         this.sortedLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // originalTextBox
         // 
         this.originalTextBox.Location = new System.Drawing.Point(16, 32);
         this.originalTextBox.Multiline = true;
         this.originalTextBox.Name = "originalTextBox";
         this.originalTextBox.Size = new System.Drawing.Size(112, 184);
         this.originalTextBox.TabIndex = 0;
         this.originalTextBox.Text = "";
         this.originalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // sortedTextBox
         // 
         this.sortedTextBox.Location = new System.Drawing.Point(160, 32);
         this.sortedTextBox.Multiline = true;
         this.sortedTextBox.Name = "sortedTextBox";
         this.sortedTextBox.Size = new System.Drawing.Size(112, 184);
         this.sortedTextBox.TabIndex = 1;
         this.sortedTextBox.Text = "";
         this.sortedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // createButton
         // 
         this.createButton.Location = new System.Drawing.Point(35, 224);
         this.createButton.Name = "createButton";
         this.createButton.TabIndex = 2;
         this.createButton.Text = "Create Data";
         this.createButton.Click += new System.EventHandler(this.createButton_Click);
         // 
         // ascendingButton
         // 
         this.ascendingButton.Location = new System.Drawing.Point(168, 224);
         this.ascendingButton.Name = "ascendingButton";
         this.ascendingButton.Size = new System.Drawing.Size(96, 23);
         this.ascendingButton.TabIndex = 3;
         this.ascendingButton.Text = "Sort Ascending";
         this.ascendingButton.Click += new System.EventHandler(this.ascendingButton_Click);
         // 
         // descendingButton
         // 
         this.descendingButton.Location = new System.Drawing.Point(168, 256);
         this.descendingButton.Name = "descendingButton";
         this.descendingButton.Size = new System.Drawing.Size(96, 23);
         this.descendingButton.TabIndex = 4;
         this.descendingButton.Text = "Sort Descending";
         this.descendingButton.Click += new System.EventHandler(this.descendingButton_Click);
         // 
         // originalLabel
         // 
         this.originalLabel.Location = new System.Drawing.Point(16, 0);
         this.originalLabel.Name = "originalLabel";
         this.originalLabel.Size = new System.Drawing.Size(112, 23);
         this.originalLabel.TabIndex = 5;
         this.originalLabel.Text = "Original Order";
         this.originalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // sortedLabel
         // 
         this.sortedLabel.Location = new System.Drawing.Point(160, 0);
         this.sortedLabel.Name = "sortedLabel";
         this.sortedLabel.Size = new System.Drawing.Size(112, 23);
         this.sortedLabel.TabIndex = 6;
         this.sortedLabel.Text = "Sorted Order";
         this.sortedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // BubbleSortForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 285);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.sortedLabel,
                                                                      this.originalLabel,
                                                                      this.descendingButton,
                                                                      this.ascendingButton,
                                                                      this.createButton,
                                                                      this.sortedTextBox,
                                                                      this.originalTextBox});
         this.Name = "BubbleSortForm";
         this.Text = "BubbleSortForm";
         this.ResumeLayout(false);

      }
      #endregion

      // create randomly generated set of numbers to sort
      private void createButton_Click( object sender, 
         System.EventArgs e )
      {
         // clear TextBoxes
         originalTextBox.Clear();
         sortedTextBox.Clear();

         // create random-number generator
         Random randomNumber = new Random();

         // populate elementArray with random integers
         for ( int i = 0; i < elementArray.Length; i++ )
         {
            elementArray[ i ] = randomNumber.Next( 100 );
            originalTextBox.Text += elementArray[ i ] + "\r\n";
         }
      } 
    
      // delegate implementation for ascending sort
      private bool SortAscending( int element1, int element2 )
      {
         return element1 > element2;
      }

      // sort randomly generated numbers in ascending order
      private void ascendingButton_Click( object sender, 
         System.EventArgs e )
      {
         // sort array, passing delegate for SortAscending
         DelegateBubbleSort.SortArray( elementArray, 
            new DelegateBubbleSort.Comparator( 
               SortAscending ) );

         DisplayResults();      
      }

      // delegate implementation for descending sort
      private bool SortDescending( int element1, int element2 )
      {
         return element1 < element2;
      }  
      
      // sort randomly generating numbers in descending order
      private void descendingButton_Click( object sender, 
         System.EventArgs e)
      {
         // sort array, passing delegate for SortDescending
         DelegateBubbleSort.SortArray( elementArray, 
            new DelegateBubbleSort.Comparator( 
               SortDescending ) );

         DisplayResults();       
      }   

      // display the sorted array in sortedTextBox
      private void DisplayResults()
      {
         sortedTextBox.Clear();

         foreach ( int element in elementArray )
            sortedTextBox.Text += element + "\r\n";
      }

      // main entry point for application
      public static void Main( string[] args )
      {
         Application.Run( new BubbleSortForm() );
      }
   }
}
