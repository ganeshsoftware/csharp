using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;


namespace Ganesh.Tasks
{
	public class Form1:Form
	{
		private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox listBox1;
		
	
		public Form1()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			this.btnStart = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnRaise
			// 
			this.btnStart.Location = new System.Drawing.Point(57, 111);
			this.btnStart.Name = "btnRaise";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(343, 207);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.btnStart);
			this.Name = "Form1";
			this.Text = "Mimsys Master Form";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		

		// This is a Long process.
		public static Task PopulateDoctorsList()
		{
			// A huge code that will run simulating a longer operation.
			return Task.Run( () => {
				System.Threading.Thread.Sleep(5000);
			});
		}
		

		// 
		public async void CallPopulateDoctors()
		{
			await PopulateDoctorsList();
			listBox1.Items.Add("Long Process Finished!");
		}		
		
		private void Form1_Load(object sender, EventArgs e)
		{
						
		}
		
		public void btnStart_Click(object obj, EventArgs e)
		{
			CallPopulateDoctors();	
			listBox1.Items.Add("Program finish");				
		}		

	}
	
	static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

//await GetAllDoctorRecords();