// Client.cs
// Client for the TicTacToe program.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace TicTacToeClient
{
   /// <summary>
   /// represents a tic-tac-toe player
   /// </summary>
   public class Client : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label idLabel;

      private System.Windows.Forms.TextBox displayTextBox;

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.Panel panel5;
      private System.Windows.Forms.Panel panel6;
      private System.Windows.Forms.Panel panel4;
      private System.Windows.Forms.Panel panel7;
      private System.Windows.Forms.Panel panel8;
      private System.Windows.Forms.Panel panel9;

      private Square[ , ] board;
      private Square currentSquare;

      private Thread outputThread;

      private TcpClient connection;
      private NetworkStream stream;
      private BinaryWriter writer;
      private BinaryReader reader;

      private char myMark;
      private bool myTurn;

      private SolidBrush brush;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      bool done = false;

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

         board = new Square[ 3, 3 ];

         // create 9 Square objects and place them on the 
         // board
         board[ 0, 0 ] = new Square( panel1, ' ', 0 );
         board[ 0, 1 ] = new Square( panel2, ' ', 1 );
         board[ 0, 2 ] = new Square( panel3, ' ', 2 );
         board[ 1, 0 ] = new Square( panel4, ' ', 3 );
         board[ 1, 1 ] = new Square( panel5, ' ', 4 );
         board[ 1, 2 ] = new Square( panel6, ' ', 5 );
         board[ 2, 0 ] = new Square( panel7, ' ', 6 );
         board[ 2, 1 ] = new Square( panel8, ' ', 7 );
         board[ 2, 2 ] = new Square( panel9, ' ', 8 );

         // create a SolidBrush for writing on the Squares
         brush = new SolidBrush( Color.Black );
  
         // Make connection to sever and get the associated 
         // network stream. Start separate thread to allow this
         // program to continually update its output in textbox.      
         // connection = new TcpClient( "localhost", 5000 );
		  connection = new TcpClient( "localhost", 1234 );
         stream = connection.GetStream();

         writer = new BinaryWriter( stream );
         reader = new BinaryReader( stream );

         // start a new thread for sending and receiving messages
         outputThread = new Thread( new ThreadStart( Run ) );
         outputThread.Start();
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
         this.panel8 = new System.Windows.Forms.Panel();
         this.panel9 = new System.Windows.Forms.Panel();
         this.panel4 = new System.Windows.Forms.Panel();
         this.panel5 = new System.Windows.Forms.Panel();
         this.panel6 = new System.Windows.Forms.Panel();
         this.panel7 = new System.Windows.Forms.Panel();
         this.panel1 = new System.Windows.Forms.Panel();
         this.panel2 = new System.Windows.Forms.Panel();
         this.panel3 = new System.Windows.Forms.Panel();
         this.displayTextBox = new System.Windows.Forms.TextBox();
         this.idLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // panel8
         // 
         this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel8.Location = new System.Drawing.Point(136, 112);
         this.panel8.Name = "panel8";
         this.panel8.Size = new System.Drawing.Size(32, 32);
         this.panel8.TabIndex = 9;
         this.panel8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.square_MouseUp);
         // 
         // panel9
         // 
         this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel9.Location = new System.Drawing.Point(168, 112);
         this.panel9.Name = "panel9";
         this.panel9.Size = new System.Drawing.Size(32, 32);
         this.panel9.TabIndex = 10;
         this.panel9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.square_MouseUp);
         // 
         // panel4
         // 
         this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel4.Location = new System.Drawing.Point(104, 80);
         this.panel4.Name = "panel4";
         this.panel4.Size = new System.Drawing.Size(32, 32);
         this.panel4.TabIndex = 5;
         this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.square_MouseUp);
         // 
         // panel5
         // 
         this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel5.Location = new System.Drawing.Point(136, 80);
         this.panel5.Name = "panel5";
         this.panel5.Size = new System.Drawing.Size(32, 32);
         this.panel5.TabIndex = 6;
         this.panel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.square_MouseUp);
         // 
         // panel6
         // 
         this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel6.Location = new System.Drawing.Point(168, 80);
         this.panel6.Name = "panel6";
         this.panel6.Size = new System.Drawing.Size(32, 32);
         this.panel6.TabIndex = 7;
         this.panel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.square_MouseUp);
         // 
         // panel7
         // 
         this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel7.Location = new System.Drawing.Point(104, 112);
         this.panel7.Name = "panel7";
         this.panel7.Size = new System.Drawing.Size(32, 32);
         this.panel7.TabIndex = 8;
         this.panel7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.square_MouseUp);
         // 
         // panel1
         // 
         this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel1.Location = new System.Drawing.Point(104, 48);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(32, 32);
         this.panel1.TabIndex = 2;
         this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.square_MouseUp);
         // 
         // panel2
         // 
         this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel2.Location = new System.Drawing.Point(136, 48);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(32, 32);
         this.panel2.TabIndex = 3;
         this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.square_MouseUp);
         // 
         // panel3
         // 
         this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel3.Location = new System.Drawing.Point(168, 48);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(32, 32);
         this.panel3.TabIndex = 4;
         this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.square_MouseUp);
         // 
         // displayTextBox
         // 
         this.displayTextBox.Location = new System.Drawing.Point(8, 184);
         this.displayTextBox.Multiline = true;
         this.displayTextBox.Name = "displayTextBox";
         this.displayTextBox.ReadOnly = true;
         this.displayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.displayTextBox.Size = new System.Drawing.Size(272, 80);
         this.displayTextBox.TabIndex = 1;
         this.displayTextBox.Text = "";
         // 
         // idLabel
         // 
         this.idLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.idLabel.Location = new System.Drawing.Point(8, 8);
         this.idLabel.Name = "idLabel";
         this.idLabel.TabIndex = 0;
         // 
         // Client
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 273);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.panel9,
                                                                      this.panel8,
                                                                      this.panel7,
                                                                      this.panel6,
                                                                      this.panel5,
                                                                      this.panel3,
                                                                      this.panel2,
                                                                      this.panel1,
                                                                      this.displayTextBox,
                                                                      this.idLabel,
                                                                      this.panel4});
         this.Name = "Client";
         this.Text = "Tic Tac Toe Client";
         this.Closing += new System.ComponentModel.CancelEventHandler(this.Client_Closing);
         this.Paint += new System.Windows.Forms.PaintEventHandler(this.Client_Paint);
         this.ResumeLayout(false);

      }
		#endregion

      [STAThread]
      static void Main() 
      {
         Application.Run( new Client() );
      }

      protected void Client_Paint (
         object sender, System.Windows.Forms.PaintEventArgs e )
      {
         PaintSquares();
      }

      protected void Client_Closing(
         object sender, CancelEventArgs e )
      {
         done = true;
      }

      // draws the mark of each square
      public void PaintSquares()
      {
         Graphics g;

         // draw the appropriate mark on each panel
         for ( int row = 0; row < 3; row++ )
            for ( int column = 0; column < 3; column++ )
            {
               // get the Graphics for each Panel
               g = board[ row, column ].SquarePanel.CreateGraphics();

               // draw the appropriate letter on the panel
               g.DrawString( board[ row, column ].Mark.ToString(), 
                  this.Font, brush, 8, 8 );
            }
      } // end method PaintSquares

      // send location of the clicked square to server
      protected void square_MouseUp( 
         object sender, System.Windows.Forms.MouseEventArgs e )
      {
         // for each square check if that square was clicked
         for ( int row = 0; row < 3; row++ )
            for ( int column = 0; column < 3; column++ )
               if ( board[ row, column ].SquarePanel == sender )
               {
                  CurrentSquare = board[ row, column ];

                  // send the move to the server
                  SendClickedSquare( board[ row, column ].Location );
               }
      } // end method square_MouseUp

      // control thread that allows continuous update of the
      // textbox display
      public void Run()
      {
         // first get players's mark (X or O)
         myMark = reader.ReadChar();
         idLabel.Text = "You are player \"" + myMark + "\"";
         myTurn = ( myMark == 'X' ? true : false );

         // process incoming messages
         try
         {
            // receive messages sent to client
            while ( true )
               ProcessMessage( reader.ReadString() );
         }
         catch ( EndOfStreamException )
         {
            MessageBox.Show( "Server is down, game over", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error );
         }

      } // end method Run

      // process messages sent to client
      public void ProcessMessage( string message )
      {
         // if the move player sent to the server is valid
         // update the display, set that square's mark to be
         // the mark of the current player and repaint the board
         if ( message == "Valid move." )
         {
            displayTextBox.Text += 
               "Valid move, please wait.\r\n";
            currentSquare.Mark = myMark;
            PaintSquares();
         }

            // if the move is invalid, display that and it is now
            // this player's turn again
         else if ( message == "Invalid move, try again" )
         {
            displayTextBox.Text += message + "\r\n";
            myTurn = true;
         }

            // if opponent moved
         else if ( message == "Opponent moved" )
         {
            // find location of their move
            int location = reader.ReadInt32();

            // set that square to have the opponents mark and
            // repaint the board
            board[ location / 3, location % 3 ].Mark =
               ( myMark == 'X' ? 'O' : 'X' );
            PaintSquares();

            displayTextBox.Text += 
               "Opponent moved.  Your turn.\r\n";

            // it is now this player's turn
            myTurn = true;
         }

            // display the message
         else
            displayTextBox.Text += message + "\r\n";

      } // end method ProcessMessage

      // sends the server the number of the clicked square
      public void SendClickedSquare( int location )
      {
         // if it is the current player's move right now
         if ( myTurn )
         {
            // send the location of the move to the server
            writer.Write( location );

            // it is now the other player's turn
            myTurn = false;
         }
      }

      // write-only property for the current square
      public Square CurrentSquare
      {
         set
         {
            currentSquare = value;
         }
      }

   } // end class Client
}

