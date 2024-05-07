// Server.cs
// Set up a Server that will receive packets from a
// client and send packets to a client.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace DatagramServer
{
	/// <summary>
	/// create the UDP server
	/// </summary>
	public class Server : System.Windows.Forms.Form
	{
      private System.Windows.Forms.TextBox displayTextBox;
      private UdpClient client;
      private IPEndPoint receivePoint;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

      // no-argument constructor
		public Server()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

         client = new UdpClient( 5000 );
         receivePoint = new IPEndPoint( new IPAddress( 0 ), 0 );
         Thread readThread = new Thread( 
            new ThreadStart( WaitForPackets ) );

         readThread.Start();
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
         this.displayTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // displayTextBox
         // 
         this.displayTextBox.Location = new System.Drawing.Point(8, 8);
         this.displayTextBox.Multiline = true;
         this.displayTextBox.Name = "displayTextBox";
         this.displayTextBox.ReadOnly = true;
         this.displayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.displayTextBox.Size = new System.Drawing.Size(264, 248);
         this.displayTextBox.TabIndex = 0;
         this.displayTextBox.Text = "";
         // 
         // Server
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(280, 261);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.displayTextBox});
         this.Name = "Server";
         this.Text = "Server";
         this.Closing += new System.ComponentModel.CancelEventHandler(this.Server_Closing);
         this.ResumeLayout(false);

      }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run( new Server() );
		}

      // shut down the server
      protected void Server_Closing( 
         object sender, CancelEventArgs e )
      {         
         System.Environment.Exit( System.Environment.ExitCode );
      }

      // wait for a packet to arrive
      public void WaitForPackets()
      {
         while ( true )
         {
            // set up packet
            byte[] data = client.Receive( ref receivePoint );
            displayTextBox.Text += "\r\nPacket received:" +
               "\r\nLength: " + data.Length +
               "\r\nContaining: " + 
               System.Text.Encoding.ASCII.GetString( data );           

            // echo information from packet back to client
            displayTextBox.Text += 
               "\r\n\r\nEcho data back to client...";

            client.Send( data, data.Length, receivePoint );
            displayTextBox.Text += "\r\nPacket sent\r\n";
         }

      } // end method WaitForPackets

	} // end class Server
}

