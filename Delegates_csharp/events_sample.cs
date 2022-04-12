using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestWindowsApplication
{
    class formTest:Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClickMe = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonClickMe
            // 
            this.buttonClickMe.ForeColor = System.Drawing.Color.Orange;
            this.buttonClickMe.Location = new System.Drawing.Point(60, 62);
            this.buttonClickMe.Name = "buttonClickMe";
            this.buttonClickMe.Size = new System.Drawing.Size(75, 23);
            this.buttonClickMe.TabIndex = 0;
            this.buttonClickMe.Text = "Click Me";
            this.buttonClickMe.UseVisualStyleBackColor = true;
            this.buttonClickMe.Click += new System.EventHandler(this.buttonClickMe_Click);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(14, 12);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(214, 23);
            this.textBoxDisplay.TabIndex = 1;
            this.textBoxDisplay.MouseLeave += new System.EventHandler(this.textBoxDisplay_MouseLeave);
            this.textBoxDisplay.MouseHover += new System.EventHandler(this.textBoxDisplay_MouseHover);
            // 
            // formTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(244, 122);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.buttonClickMe);
            this.Name = "formTest";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		
	
        public formTest()
        {
            InitializeComponent();
        }

        private void buttonClickMe_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "Welcome to the world!";
            textBoxDisplay.BackColor = Color.Aqua;
        }

        private void textBoxDisplay_MouseHover(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "The mouse if hovering on top of you!";
        
        }

        private void textBoxDisplay_MouseLeave(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "";
            textBoxDisplay.BackColor = Color.White;

        }
    

<div class="row">
	<div class="col-md-4">
	<div class="col-md-4">
	<div class="col-md-4">
</div>


<div class="form-group">
	<div class="col-md-4">
	<div class="col-md-4">
	<div class="col-md-4">
</div>

		
		
		
		

        #endregion

        private System.Windows.Forms.Button buttonClickMe;
        private System.Windows.Forms.TextBox textBoxDisplay;
    }
	
	public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formTest());
        }
    }
}

















 