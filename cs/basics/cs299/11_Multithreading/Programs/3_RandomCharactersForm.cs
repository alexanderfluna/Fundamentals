using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;

namespace Threads2Windows
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblThread1;
		private System.Windows.Forms.Label lblThread2;
		private System.Windows.Forms.Label lblThread3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;

		private Thread [] threads = new Thread [3];
        private const int C_T_MAX = 1000;
        private int compIndex = -1;
        private Thread[] compThreads = new Thread[C_T_MAX];
		private bool [] suspended = new bool [3];
		private bool [] selfish = {false, false, false};
		private string [] names = {"Thread 1", "Thread 2", "Thread 3"};
		private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		Random []random = {new Random(1), new Random(2), new Random(3)};
		private System.Windows.Forms.CheckBox chkSelfish1;
		private System.Windows.Forms.CheckBox chkSelfish2;
		private System.Windows.Forms.CheckBox chkSelfish3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbHigh1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton rbHigh2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton rbHigh3;
        private Button button1;
        private Button button2;
        private Label lblComp;
		
	
		

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
			if( disposing )
			{
                for (int i = 0; i <= compIndex; i++)
                {
                    compThreads[i].Abort();
                }
                if(checkBox1.Checked)
					checkBox1.Checked = false;
				if(checkBox2.Checked)
					checkBox2.Checked = false;
				if(checkBox3.Checked)
					checkBox3.Checked = false;
				for (int i = 0; i < 3; i++)
				{			
					threads[i].Abort();
				}
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
            this.lblThread1 = new System.Windows.Forms.Label();
            this.lblThread2 = new System.Windows.Forms.Label();
            this.lblThread3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.chkSelfish1 = new System.Windows.Forms.CheckBox();
            this.chkSelfish2 = new System.Windows.Forms.CheckBox();
            this.chkSelfish3 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbHigh1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rbHigh2 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.rbHigh3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblComp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThread1
            // 
            this.lblThread1.BackColor = System.Drawing.Color.Lime;
            this.lblThread1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblThread1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThread1.Location = new System.Drawing.Point(16, 40);
            this.lblThread1.Name = "lblThread1";
            this.lblThread1.Size = new System.Drawing.Size(152, 24);
            this.lblThread1.TabIndex = 0;
            this.lblThread1.Text = "Thread 1:";
            // 
            // lblThread2
            // 
            this.lblThread2.BackColor = System.Drawing.Color.Lime;
            this.lblThread2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblThread2.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThread2.Location = new System.Drawing.Point(16, 120);
            this.lblThread2.Name = "lblThread2";
            this.lblThread2.Size = new System.Drawing.Size(152, 24);
            this.lblThread2.TabIndex = 1;
            this.lblThread2.Text = "Thread 2:";
            // 
            // lblThread3
            // 
            this.lblThread3.BackColor = System.Drawing.Color.Lime;
            this.lblThread3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblThread3.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThread3.Location = new System.Drawing.Point(16, 200);
            this.lblThread3.Name = "lblThread3";
            this.lblThread3.Size = new System.Drawing.Size(152, 24);
            this.lblThread3.TabIndex = 2;
            this.lblThread3.Text = "Thread 3:";
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(184, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Suspended";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(184, 120);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(112, 24);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Suspended";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(184, 200);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(112, 24);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Suspended";
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkSelfish1
            // 
            this.chkSelfish1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelfish1.Location = new System.Drawing.Point(312, 32);
            this.chkSelfish1.Name = "chkSelfish1";
            this.chkSelfish1.Size = new System.Drawing.Size(88, 40);
            this.chkSelfish1.TabIndex = 6;
            this.chkSelfish1.Text = "Selfish";
            this.chkSelfish1.CheckedChanged += new System.EventHandler(this.chkSelfish1_CheckedChanged);
            // 
            // chkSelfish2
            // 
            this.chkSelfish2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelfish2.Location = new System.Drawing.Point(312, 112);
            this.chkSelfish2.Name = "chkSelfish2";
            this.chkSelfish2.Size = new System.Drawing.Size(88, 40);
            this.chkSelfish2.TabIndex = 7;
            this.chkSelfish2.Text = "Selfish";
            this.chkSelfish2.CheckedChanged += new System.EventHandler(this.chkSelfish2_CheckedChanged);
            // 
            // chkSelfish3
            // 
            this.chkSelfish3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelfish3.Location = new System.Drawing.Point(312, 192);
            this.chkSelfish3.Name = "chkSelfish3";
            this.chkSelfish3.Size = new System.Drawing.Size(88, 40);
            this.chkSelfish3.TabIndex = 8;
            this.chkSelfish3.Text = "Selfish";
            this.chkSelfish3.CheckedChanged += new System.EventHandler(this.chkSelfish3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rbHigh1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(424, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 64);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Priority";
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(96, 24);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Low";
            // 
            // rbHigh1
            // 
            this.rbHigh1.Checked = true;
            this.rbHigh1.Location = new System.Drawing.Point(16, 24);
            this.rbHigh1.Name = "rbHigh1";
            this.rbHigh1.Size = new System.Drawing.Size(64, 24);
            this.rbHigh1.TabIndex = 0;
            this.rbHigh1.TabStop = true;
            this.rbHigh1.Text = "High";
            this.rbHigh1.CheckedChanged += new System.EventHandler(this.rbHigh1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.rbHigh2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(424, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 64);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Priority";
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(96, 24);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(56, 24);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.Text = "Low";
            // 
            // rbHigh2
            // 
            this.rbHigh2.Checked = true;
            this.rbHigh2.Location = new System.Drawing.Point(16, 24);
            this.rbHigh2.Name = "rbHigh2";
            this.rbHigh2.Size = new System.Drawing.Size(64, 24);
            this.rbHigh2.TabIndex = 0;
            this.rbHigh2.TabStop = true;
            this.rbHigh2.Text = "High";
            this.rbHigh2.CheckedChanged += new System.EventHandler(this.rbHigh2_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.rbHigh3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(424, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 64);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Priority";
            // 
            // radioButton5
            // 
            this.radioButton5.Location = new System.Drawing.Point(96, 24);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(56, 24);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.Text = "Low";
            // 
            // rbHigh3
            // 
            this.rbHigh3.Checked = true;
            this.rbHigh3.Location = new System.Drawing.Point(16, 24);
            this.rbHigh3.Name = "rbHigh3";
            this.rbHigh3.Size = new System.Drawing.Size(64, 24);
            this.rbHigh3.TabIndex = 0;
            this.rbHigh3.TabStop = true;
            this.rbHigh3.Text = "High";
            this.rbHigh3.CheckedChanged += new System.EventHandler(this.rbHigh3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(206, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add Computation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(405, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 36);
            this.button2.TabIndex = 15;
            this.button2.Text = "Remove Computation";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComp.Location = new System.Drawing.Point(17, 272);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(160, 24);
            this.lblComp.TabIndex = 17;
            this.lblComp.Text = "Computations: 0";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(616, 316);
            this.Controls.Add(this.lblComp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkSelfish3);
            this.Controls.Add(this.chkSelfish2);
            this.Controls.Add(this.chkSelfish1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblThread3);
            this.Controls.Add(this.lblThread2);
            this.Controls.Add(this.lblThread1);
            this.Name = "Form1";
            this.Text = "Random Characters";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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

		private void Form1_Load(object sender, System.EventArgs e)
		{
                  
            for (int i = 0; i < 3; i++)
			{
				threads[i] = new Thread(new ThreadStart(DoWork));
				threads[i].Name = names[i]; 
				threads[i].Start();				
			}
		}
		private void DoWork()
		{
			Thread current = Thread.CurrentThread;
			string name = current.Name;
			int index;
			if (name == "Thread 1")
				index = 0;
			else if (name == "Thread 2")
				index = 1;
			else
				index = 2;
			string displayChar;

			while ( threads[ index ] == current ) 
			{
				
				
				if(! selfish[index])
					// sleep from 0 to 1 second				
					Thread.Sleep((int)(random[index].NextDouble() * 100));
				int ind = (int)(random[index].NextDouble() * 26);
				displayChar = alphabet.Substring(ind,1);
				switch (index)
				{
					case 0: lblThread1.Text = current.Name + ": " 
								+ displayChar;
						break;
					case 1: lblThread2.Text = current.Name + ": " 
								+ displayChar;
						break;
					case 2: lblThread3.Text = current.Name + ": "
								+ displayChar;
						break;
				}		
			}
		}

        private void Computation()
        {
            const long LIMIT = 100000;
            Random  random = new Random();
            while (true)
            {
                double[] numbers = new double[LIMIT];
                for (int i = 0; i < LIMIT; i++)
                    numbers[i] = random.NextDouble();
                Array.Sort(numbers);
                Thread.Sleep((int)(random.NextDouble() * 1000));
                //Console.WriteLine("Computed");
            }

        }


        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (checkBox1.Checked)
			{
				threads[0].Suspend();
				lblThread1.BackColor= Color.Red;
			}
			else 
			{
				threads[0].Resume();
				lblThread1.BackColor= Color.Lime;
			}

		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			if (checkBox2.Checked)
			{
				threads[1].Suspend();
				lblThread2.BackColor= Color.Red;
			}
			else 
			{
				threads[1].Resume();
				lblThread2.BackColor= Color.Lime;
			}
		}

		private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
		{
			if (checkBox3.Checked)
			{
				threads[2].Suspend();
				lblThread3.BackColor= Color.Red;
			}
			else 
			{
				threads[2].Resume();
				lblThread3.BackColor= Color.Lime;
			}
		}

		private void chkSelfish1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkSelfish1.Checked)
				selfish[0] = true;
			else
				selfish[0] = false;
		}

		private void chkSelfish2_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkSelfish2.Checked)
				selfish[1] = true;
			else
				selfish[1] = false;
		
		}

		private void chkSelfish3_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkSelfish3.Checked)
				selfish[2] = true;
			else
				selfish[2] = false;
		}

        private void rbHigh1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHigh1.Checked)
                threads[0].Priority = ThreadPriority.Highest;
            else
                threads[0].Priority = ThreadPriority.Lowest;
        }

        private void rbHigh2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHigh2.Checked)
                threads[1].Priority = ThreadPriority.Highest;
            else
                threads[1].Priority = ThreadPriority.Lowest;
        }

        private void rbHigh3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHigh3.Checked)
                threads[2].Priority = ThreadPriority.Highest;
            else
                threads[2].Priority = ThreadPriority.Lowest;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (compIndex < C_T_MAX-1)
            {               
                compIndex++;
                compThreads[compIndex] = new Thread(new ThreadStart(Computation));
                compThreads[compIndex].Priority = ThreadPriority.Normal;
                compThreads[compIndex].Start();                
            }
            lblComp.Text = "Computations: " + (compIndex+1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (compIndex >= 0)
            {
                compThreads[compIndex].Abort();
                compIndex--;
            }
            lblComp.Text = "Computations: " + (compIndex+1);
        }

	}
}
