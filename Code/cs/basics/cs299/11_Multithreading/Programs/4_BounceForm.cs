using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;

namespace WindowsApplication1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.Button StartButton;
		private	int xCoord = 5 , yCoord = 5;
		private	int dx = 3, dy = 3;
		private bool stopped = false;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{   

			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			stopped = true;
			Thread.Sleep(50);
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
			this.StartButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// StartButton
			// 
			this.StartButton.BackColor = System.Drawing.Color.LightGray;
			this.StartButton.Location = new System.Drawing.Point(56, 136);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(80, 32);
			this.StartButton.TabIndex = 0;
			this.StartButton.Text = "Start";
			this.StartButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.BackColor = System.Drawing.Color.LightGray;
			this.CloseButton.Location = new System.Drawing.Point(160, 136);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(64, 32);
			this.CloseButton.TabIndex = 1;
			this.CloseButton.Text = "Close";
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(292, 173);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.StartButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}		
	

		private void button1_Click(object sender, System.EventArgs e)
		{
			Thread thread = new Thread(new ThreadStart(go));
			thread.Priority = ThreadPriority.Normal;
			thread.Start();
		}

		private void go(){
			Graphics g = this.CreateGraphics();
			SolidBrush brush = new SolidBrush( Color.Blue );
			SolidBrush whiteBrush = new SolidBrush(Color.White);
			while(! stopped)
			{   			
				if ((xCoord <= 0) || (xCoord >= 280))
					dx = - dx;
				if ((yCoord <= 0) || (yCoord >= 165))
					dy = - dy;
				g.FillEllipse( whiteBrush, xCoord, yCoord, 10, 10 );
				xCoord = xCoord + dx;
				yCoord = yCoord + dy;				
				g.FillEllipse( brush, xCoord, yCoord, 10, 10 );
				Thread.Sleep(30);
			}

		}

		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			stopped = true;
			Thread.Sleep(50);
			Application.Exit();
		}



	}// end class Form1
	

}// end namespace
