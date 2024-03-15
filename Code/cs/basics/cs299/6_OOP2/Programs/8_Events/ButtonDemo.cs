// ButtonDemo.cs - A Window with two buttons and a textbox. 

using System;
using System.Windows.Forms;
using System.Drawing;


namespace ConsoleApplication1
{
	// In System:
	// public delegate void EventHandler (Object sender, EventArgs e)

	public class Window: Form
	{

		Button b1, b2;
		TextBox tb;

		// Constructor
		public Window ()
		{
			this.Size=new Size(150,200);

			b1 = new Button();
			b1.Text="Click Me";
			b1.Size=new Size(100,25);
			b1.Location = new Point(25,25);
			b1.BackColor = Color.Yellow;	
			// Add a handler to the event Click of button b1
			b1.Click+=new EventHandler(ClickHandler);
			// Alternatively from C# Version 2.0
			// b1.Click += ClickHandler;
			b2 = new Button();
			b2.Text="Erase";
			b2.Size=new Size(100,25);
			b2.Location = new Point(25,55);
			b2.BackColor=Color.Green;
			// Add a handler to the event Click of button b2
			b2.Click+=new EventHandler(EraseHandler);
			// Alternatively from C# Version 2.0
			// b2.Click += EraseHandler; 
			tb = new TextBox();
			tb.Location = new Point(25,100);
			tb.Size=new Size(100,25);
			tb.BackColor=Color.White;
			tb.ReadOnly=true;
			tb.RightToLeft=RightToLeft.Yes;

			this.Controls.Add(b1);
			this.Controls.Add(b2);
			this.Controls.Add(tb);
		}

		// Eventhandler:
		private void ClickHandler(object obj, EventArgs ea) 
		{
			tb.Text = "You clicked me";
		}

		// Eventhandler:
		private void EraseHandler(object obj, EventArgs ea) 
		{
			tb.Text = "";
		}

	}

	class ButtonTest
	{

		public static void Main()
		{
			Window win = new Window();
			Application.Run(win);
		}

	}



}
