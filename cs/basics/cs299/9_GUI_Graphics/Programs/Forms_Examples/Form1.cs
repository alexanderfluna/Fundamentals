using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csh2013_FormsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2Ref = new Form2();
            form2Ref.btnClose.Enabled = false;
            form2Ref.Show(); 

            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2Ref = new Form2();
            form2Ref.btnExit.Enabled = false;
            form2Ref.btnToForm1.Enabled = false;
            form2Ref.ShowDialog();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
