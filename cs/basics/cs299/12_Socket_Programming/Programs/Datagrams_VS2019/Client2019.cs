// Client.cs
// Set up a Client that sends packets to a server and receives 
// packets from a server.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace DatagramClient
{
	/// <summary>
	/// run the UDP client
	/// </summary>
	public class Client : System.Windows.Forms.Form
	{
      private System.Windows.Forms.TextBox inputTextBox;
      private System.Windows.Forms.TextBox displayTextBox;

      private UdpClient client; 
      private IPEndPoint receivePoint;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

      // no-argument constructor
		public Client()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

         receivePoint = new IPEndPoint( new IPAddress( 0 ), 0 );
         client = new UdpClient( 5001 );
         Thread thread = 
            new Thread( new ThreadStart( WaitForPackets ) );
         thread.Start();  
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
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // displayTextBox
         // 
         this.displayTextBox.Location = new System.Drawing.Point(8, 40);
         this.displayTextBox.Multiline = true;
         this.displayTextBox.Name = "displayTextBox";
         this.displayTextBox.ReadOnly = true;
         this.displayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.displayTextBox.Size = new System.Drawing.Size(264, 216);
         this.displayTextBox.TabIndex = 1;
         this.displayTextBox.Text = "";
         // 
         // inputTextBox
         // 
         this.inputTextBox.Location = new System.Drawing.Point(8, 8);
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.Size = new System.Drawing.Size(264, 20);
         this.inputTextBox.TabIndex = 0;
         this.inputTextBox.Text = "";
         this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
         // 
         // Client
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(280, 261);
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

      // shut down the client
      protected void Client_Closing( 
         object sender, CancelEventArgs e )
      {
         System.Environment.Exit( System.Environment.ExitCode );
      }

      // send a packet
      protected void inputTextBox_KeyDown( 
         object sender, KeyEventArgs e )
      {
         if ( e.KeyCode == Keys.Enter )
         {
            // create packet (datagram) as string
            string packet = inputTextBox.Text;
            displayTextBox.Text += 
               "\r\nSending packet containing: " + packet;

            // convert packet to byte array
            byte[] data = 
               System.Text.Encoding.ASCII.GetBytes( packet );

            // send packet to server on port 5000
            client.Send( data, data.Length, "localhost", 5000 );
            displayTextBox.Text += "\r\nPacket sent\r\n";
            inputTextBox.Clear();
         }
      } // end method inputTextBox_KeyDown

      // wait for packets to arrive
      public void WaitForPackets()
      {
         while ( true )
         {
            // receive byte array from server 
            byte[] data = client.Receive( ref receivePoint );

            // output packet data to TextBox
            displayTextBox.Text += "\r\nPacket received:" +
               "\r\nLength: " + data.Length + "\r\nContaining: " + 
               System.Text.Encoding.ASCII.GetString( data ) + 
               "\r\n";
         }

      } // end method WaitForPackets

   } // end class Client
}

