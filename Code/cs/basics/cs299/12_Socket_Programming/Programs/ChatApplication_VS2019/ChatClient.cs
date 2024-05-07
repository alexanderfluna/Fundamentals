// Client.cs
// Set up a Client that will read information sent
// from a Server and display the information.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace ChatClient
{
   /// <summary>
   /// connects to a chat server
   /// </summary>
   public class Client : System.Windows.Forms.Form
   {
      private System.Windows.Forms.TextBox inputTextBox;
      private System.Windows.Forms.TextBox displayTextBox;

      private NetworkStream output;
      private BinaryWriter writer;
      private BinaryReader reader;

      private string message = "";

      private Thread readThread;

      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      // default constructor
      public Client()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();

         //
         // TODO: Add any constructor code after InitializeComponent call
         //

         readThread = new Thread( new ThreadStart( RunClient ) );
         readThread.Start();
      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
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
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.displayTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // inputTextBox
         // 
         this.inputTextBox.Location = new System.Drawing.Point(8, 8);
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.Size = new System.Drawing.Size(272, 20);
         this.inputTextBox.TabIndex = 0;
         this.inputTextBox.Text = "";
         this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
         // 
         // displayTextBox
         // 
         this.displayTextBox.Location = new System.Drawing.Point(8, 40);
         this.displayTextBox.Multiline = true;
         this.displayTextBox.Name = "displayTextBox";
         this.displayTextBox.ReadOnly = true;
         this.displayTextBox.Size = new System.Drawing.Size(272, 208);
         this.displayTextBox.TabIndex = 1;
         this.displayTextBox.Text = "";
         // 
         // Client
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 261);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.displayTextBox,
                                                                      this.inputTextBox});
         this.Name = "Client";
         this.Text = "Client";
         this.Closing += new System.ComponentModel.CancelEventHandler(this.Client_Closing);
         this.ResumeLayout(false);

      }
		#endregion

      [STAThread]
      static void Main() 
      {
         Application.Run( new Client() );
      }

      protected void Client_Closing( 
         object sender, CancelEventArgs e )
      {         
         System.Environment.Exit( System.Environment.ExitCode );
      }

      // sends text the user typed to server
      protected void inputTextBox_KeyDown ( 
         object sender, KeyEventArgs e )
      {
         try
         {         
            if ( e.KeyCode == Keys.Enter )
            {
               writer.Write( "CLIENT>>> " + inputTextBox.Text );

               displayTextBox.Text += 
                  "\r\nCLIENT>>> " + inputTextBox.Text;
         
               inputTextBox.Clear();            
            }
         }
         catch ( SocketException )
         {
            displayTextBox.Text += "\nError writing object";
         }

      } // end method inputTextBox_KeyDown

      // connect to server and display server-generated text
      public void RunClient()
      {
         TcpClient client;

         // instantiate TcpClient for sending data to server
         try
         { 
            displayTextBox.Text += "Attempting connection\r\n";

            // Step 1: create TcpClient and connect to server
            client = new TcpClient();
            // client.Connect( "localhost", 5000 );
			 client.Connect( "localhost", 1234 );

            // Step 2: get NetworkStream associated with TcpClient
            output = client.GetStream();

            // create objects for writing and reading across stream
            writer = new BinaryWriter( output );
            reader = new BinaryReader( output );

            displayTextBox.Text += "\r\nGot I/O streams\r\n";

            inputTextBox.ReadOnly = false;
      
            // loop until server signals termination
            do
            {

               // Step 3: processing phase
               try
               {
                  // read message from server
                  message = reader.ReadString();
                  displayTextBox.Text += "\r\n" + message; 
               }

                  // handle exception if error in reading server data
               catch ( Exception )
               {
                  System.Environment.Exit( 
                     System.Environment.ExitCode );
               }
            } while( message != "SERVER>>> TERMINATE" );
      
            displayTextBox.Text += "\r\nClosing connection.\r\n";

            // Step 4: close connection
            writer.Close();
            reader.Close();
            output.Close();
            client.Close();
            Application.Exit();
         }

            // handle exception if error in establishing connection
         catch ( Exception error )
         {
            MessageBox.Show( error.ToString() );
         }

      } // end method RunClient

   } // end class Client
}

