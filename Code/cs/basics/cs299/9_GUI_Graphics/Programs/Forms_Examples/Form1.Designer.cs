namespace Csh2013_FormsProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnToForm2 = new System.Windows.Forms.Button();
            this.btnForm2Dialog = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToForm2
            // 
            this.btnToForm2.Location = new System.Drawing.Point(69, 42);
            this.btnToForm2.Name = "btnToForm2";
            this.btnToForm2.Size = new System.Drawing.Size(137, 34);
            this.btnToForm2.TabIndex = 0;
            this.btnToForm2.Text = "Go To Form 2";
            this.btnToForm2.UseVisualStyleBackColor = true;
            this.btnToForm2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnForm2Dialog
            // 
            this.btnForm2Dialog.Location = new System.Drawing.Point(69, 102);
            this.btnForm2Dialog.Name = "btnForm2Dialog";
            this.btnForm2Dialog.Size = new System.Drawing.Size(137, 33);
            this.btnForm2Dialog.TabIndex = 1;
            this.btnForm2Dialog.Text = "Form2 Dialog";
            this.btnForm2Dialog.UseVisualStyleBackColor = true;
            this.btnForm2Dialog.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(69, 161);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 34);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnForm2Dialog);
            this.Controls.Add(this.btnToForm2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnToForm2;
        public System.Windows.Forms.Button btnForm2Dialog;
        public System.Windows.Forms.Button btnExit;
    }
}

