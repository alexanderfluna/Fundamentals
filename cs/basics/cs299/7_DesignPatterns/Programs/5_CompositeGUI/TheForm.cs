using System;
using System.Windows.Forms;
using System.Drawing;

// In System:
// public delegate void EventHandler (Object sender, EventArgs e)

public class Window: Form{

  Button b1, b2, paBt;
  Panel pa;
  TextBox tb, paTb;

  // Constructor
  public Window (){
    this.Size=new Size(150,300);

    b1 = new Button();
    b1.Text="Click Me";
    b1.Size=new Size(100,25);
    b1.Location = new Point(25,25);
    b1.BackColor = Color.Yellow;
    b1.Click += ClickHandler; 
                              // Alternatively:
                              // b1.Click+=new EventHandler(ClickHandler);
    b2 = new Button();
    b2.Text="Erase";
    b2.Size=new Size(100,25);
    b2.Location = new Point(25,55);
    b2.BackColor=Color.Green; 
    b2.Click += EraseHandler; 
                              // Alternatively:
                              // b2.Click+=new EventHandler(EraseHandler);
    tb = new TextBox();
    tb.Location = new Point(25,100);
    tb.Size=new Size(100,25);
    tb.BackColor=Color.White;
    tb.ReadOnly=true;
    tb.RightToLeft=RightToLeft.Yes;

    pa = new Panel();
    pa.Location = new Point(25,150);
    pa.Size=new Size(100, 75);
    pa.BackColor=Color.Red;

    paBt = new Button();
    paBt.Text="A";
    paBt.Location = new Point(10,10);
    paBt.Size=new Size(25,25);
    paBt.BackColor=Color.Blue; 
    paBt.Click += PanelButtonClickHandler;

    paTb = new TextBox();
    paTb.Location = new Point(10,40);
    paTb.Size=new Size(50,25);
    paTb.BackColor=Color.Gray;
    paTb.ReadOnly=true;
    paTb.RightToLeft=RightToLeft.Yes;

    this.Controls.Add(b1);
    this.Controls.Add(b2);
    this.Controls.Add(tb);

    pa.Controls.Add(paBt);
    pa.Controls.Add(paTb);

    this.Controls.Add(pa);
  }

  // Eventhandler:
  private void ClickHandler(object obj, EventArgs ea) {
    tb.Text = "You clicked me";
  }

  // Eventhandler:
  private void PanelButtonClickHandler(object obj, EventArgs ea) {
    paTb.Text += "A";
  }

  // Eventhandler:
  private void EraseHandler(object obj, EventArgs ea) {
    tb.Text = "";
  }

}

class ButtonTest{

  public static void Main(){
    Window win = new Window();
    Application.Run(win);
  }

}

