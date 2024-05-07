// Server.cs
// Set up a Server that will receive a connection from a client,
// send a string to the client, and close the connection.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace ChatServer
{
   // server that awaits client connections (one at a time) and
   // allows a conversation between client and server
   public class Server : System.Windows.Forms.Form
   {
      private System.Windows.Forms.TextBox inputTextBox;
      private System.Windows.Forms.TextBox displayTextBox;
      private Socket connection;
      private Thread readThread;

      private System.ComponentModel.Container components = null;
      private NetworkStream socketStream;
      private BinaryWriter writer;
      private BinaryReader reader;


      // default constructor
      public Server()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();

         //
         // TODO: Add any constructor code after InitializeComponent call
         //

         // create a new thread from the server
         readThread = new Thread( new ThreadStart( RunServer ) );
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
         this.displayTextBox = new System.Windows.Forms.TextBox();
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
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
         // inputTextBox
         // 
         this.inputTextBox.Location = new System.Drawing.Point(8, 8);
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.Size = new System.Drawing.Size(272, 20);
         this.inputTextBox.TabIndex = 0;
         this.inputTextBox.Text = "";
         this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
         // 
         // Server
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 261);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.displayTextBox,
                                                                      this.inputTextBox});
         this.Name = "Server";
         this.Text = "Server";
         this.Closing += new System.ComponentModel.CancelEventHandler(this.Server_Closing);
         this.ResumeLayout(false);

      }
      #endregion

      [STAThread]
      static void Main() 
      {
         Application.Run( new Server() );
      }

      protected void Server_Closing( 
         object sender, CancelEventArgs e )
      {         
         System.Environment.Exit( System.Environment.ExitCode );
      }

      // sends the text typed at the server to the client
      protected void inputTextBox_KeyDown(  
         object sender, KeyEventArgs e )
      {
         // sends the text to the client
         try
         {         
            if ( e.KeyCode == Keys.Enter && connection != null )
            {
               writer.Write( "SERVER>>> " + inputTextBox.Text );
         
               displayTextBox.Text += 
                  "\r\nSERVER>>> " + inputTextBox.Text;

               // if the user at the server signaled termination
               // sever the connection to the client
               if ( inputTextBox.Text == "TERMINATE" )
                  connection.Close();

               inputTextBox.Clear();
            }
         }
         catch ( SocketException )
         {
            displayTextBox.Text += "\nError writing object";
         }
      }

      // allows a client to connect and displays the text it sends
      public void RunServer()
      {
         TcpListener listener;
         int counter = 1;

         // wait for a client connection and display the text
         // that the client sends
         try
         {
            // Step 1: create TcpListener
            // listener = new TcpListener( 5000 );
			 listener = new TcpListener( 1234 );

            // Step 2: TcpListener waits for connection request
            listener.Start();

            // Step 3: establish connection upon client request
            while ( true )
            {
               displayTextBox.Text = "Waiting for connection\r\n";

               // accept an incoming connection
               connection = listener.AcceptSocket();

               // create NetworkStream object associated with socket
               socketStream = new NetworkStream( connection );

               // create objects for transferring data across stream
               writer = new BinaryWriter( socketStream );
               reader = new BinaryReader( socketStream );

               displayTextBox.Text += "Connection " + counter +
                  " received.\r\n";

               // inform client that connection was successfull
                  writer.Write( "SERVER>>> Connection successful" );

               inputTextBox.ReadOnly = false;
               string theReply = "";

               // Step 4: read String data sent from client
               do
               {
                  try
                  {   
                     // read the string sent to the server
                     theReply = reader.ReadString();

                     // display the message
                     displayTextBox.Text += "\r\n" + theReply;
                  }

                     // handle exception if error reading data
                  catch ( Exception )
                  {
                     break;
                  }

               } while ( theReply != "CLIENT>>> TERMINATE"  &&
                  connection.Connected );

               displayTextBox.Text += 
                  "\r\nUser terminated connection";

               // Step 5: close connection
               inputTextBox.ReadOnly = true;
               writer.Close();
               reader.Close();
               socketStream.Close();
               connection.Close();

               ++counter;
            }
         } // end try

         catch ( Exception error )
         {
            MessageBox.Show( error.ToString() );
         }

      } // end method RunServer

   } // end class Server
}

