// Server.cs
// This class maintains a game of Tic-Tac-Toe for two
// client applications.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace TicTacToeServer
{
   /// <summary>
   /// awaits connections from two clients and allows them to
   /// play tic-tac-toe against each other
   /// </summary>
   public class Server : System.Windows.Forms.Form
   {
      private System.Windows.Forms.TextBox displayTextBox;

      private byte[] board;

      private Player[] players;
      private Thread[] playerThreads;

      private TcpListener listener;
      private int currentPlayer;
      private Thread getPlayers;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;
      private Button btnExit;

      internal bool disconnected = false;

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

         board = new byte[ 9 ];
      
         players = new Player[ 2 ];
         playerThreads = new Thread[ 2 ];
         currentPlayer = 0;

         // accept connections on a different thread
         getPlayers = new Thread( new ThreadStart( SetUp ) );
         getPlayers.Start();        
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
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(8, 8);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayTextBox.Size = new System.Drawing.Size(272, 256);
            this.displayTextBox.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(198, 217);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 32);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Server
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.displayTextBox);
            this.Name = "Server";
            this.Text = "Tic Tac Toe Server";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Server_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

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
         disconnected = true;
      }

      // accepts connections from 2 players
      public void SetUp()
      {
         // set up Socket
         // listener = new TcpListener( 5000 );
		  listener = new TcpListener( 1234 );
         listener.Start();

         // accept first player and start a thread for him or her
         players[ 0 ] = 
            new Player( listener.AcceptSocket(), this, 0 );
         playerThreads[ 0 ] = new Thread( 
            new ThreadStart( players[ 0 ].Run ) );
         playerThreads[ 0 ].Start();

         // accept second player and start a thread for him or her
         players[ 1 ] = 
            new Player( listener.AcceptSocket(), this, 1 );
         playerThreads[ 1 ] = 
            new Thread( new ThreadStart( players[ 1 ].Run ) );
         playerThreads[ 1 ].Start();

         // let the first player know that the other player has
         // connected
         lock ( players[ 0 ] )
         {
            players[ 0 ].threadSuspended = false;
            Monitor.Pulse( players[ 0 ] );
         }
      } // end method SetUp

      // appends the argument to text in displayTextBox
      public void Display( string message )
      {
         displayTextBox.Text += message + "\r\n";
      }

      // determine if a move is valid
      public bool ValidMove( int location, int player )
      {
         // prevent another thread from making a move
         lock ( this )
         {
            // while it is not the current player's turn, wait
            while ( player != currentPlayer )
               Monitor.Wait( this );

            // if the desired square is not occupied
            if ( !IsOccupied( location ) )
            {
               // set the board to contain the current player's mark
               board[ location ] = ( byte ) ( currentPlayer == 0 ? 
                  'X' : 'O' );

               // set the currentPlayer to be the other player
               currentPlayer = ( currentPlayer + 1 ) % 2;

               // notify the other player of the move
               players[ currentPlayer ].OtherPlayerMoved( location );

               // alert the other player it's time to move
               Monitor.Pulse( this );

               return true;
            }
            else
               return false;
         }
      } // end method ValidMove

      // determines whether the specified square is occupied
      public bool IsOccupied( int location )
      {
         if ( board[ location ] == 'X' || board[ location ] == 'O' )
            return true;
         else
            return false;
      }

      // determines if the game is over
      public bool GameOver()
      {
         // place code here to test for a winner of the game
         return false;
      }

      private void btnExit_Click(object sender, EventArgs e)
      {
          Application.Exit();
      }

   } // end class Server

   public class Player
   {
      internal Socket connection;
      private NetworkStream socketStream;
      private Server server;
      private BinaryWriter writer;
      private BinaryReader reader;

      private int number;
      private char mark;
      internal bool threadSuspended = true;

      // constructor requiring Socket, Server and int objects
      // as arguments
      public Player( Socket socket, Server serverValue, int newNumber )
      {
         mark = ( newNumber == 0 ? 'X' : 'O' );

         connection = socket;

         server = serverValue;
         number = newNumber;

         // create NetworkStream object for Socket
         socketStream = new NetworkStream( connection );

         // create Streams for reading/writing bytes
         writer = new BinaryWriter( socketStream );
         reader = new BinaryReader( socketStream );

      } // end constructor

      // signal other player of move
      public void OtherPlayerMoved( int location )
      {
         // signal that opponent moved
         writer.Write( "Opponent moved" );
         writer.Write( location ); // send location of move
      }

      // allows the players to make moves and receives moves
      // from other player
      public void Run()
      {
         bool done = false;

         // display on the server that a connection was made
         server.Display( "Player " + ( number == 0 ? 'X' : 'O' )
            + " connected" );

         // send the current player's mark to the server
         writer.Write( mark );
   
         // if number equals 0 then this player is X, so send
         writer.Write( "Player " + ( number == 0 ? 
            "X connected\r\n" : "O connected, please wait\r\n" ) );

         // wait for another player to arrive
         if ( mark == 'X' )
         {
            writer.Write( "Waiting for another player" );

            // wait for notification from server that another 
            // player has connected
            lock ( this )
            {
               while ( threadSuspended )
                  Monitor.Wait( this );
            }

            writer.Write( "Other player connected. Your move" );
         
         } // end if

         // play game
         while ( !done )
         {            
            // wait for data to become available
            while ( connection.Available == 0 )
            {
               Thread.Sleep( 1000 );

               if ( server.disconnected )
                  return; 
            }

            // receive data
            int location = reader.ReadInt32();

            // if the move is valid, display the move on the
            // server and signal the move is valid
            if ( server.ValidMove( location, number ) )
            {
               server.Display( "loc: " + location );
               writer.Write( "Valid move." );
            }

               // signal the move is invalid
            else
               writer.Write( "Invalid move, try again" );

            // if game is over, set done to true to exit while loop
            if ( server.GameOver() )
               done = true;

         } // end while loop

         // close the socket connection
         writer.Close();
         reader.Close();
         socketStream.Close();
         connection.Close();

      } // end method Run

   } // end class Player
}

