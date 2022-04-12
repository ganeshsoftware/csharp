using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace AwaitAsynDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private Int32 CountFileSizeInBytes()
        {
            Int32 count;
            string content = "";
            using (StreamReader reader = new StreamReader("e:\\Postman-win64-8.3.1-Setup.exe"))
            {

                content = reader.ReadToEnd();
                count = content.Length;
            }
            return count;
        }


        private async void buttonDataSize_Click(object sender, EventArgs e)
        {
            Task<Int32> task = new Task<Int32>(CountFileSizeInBytes);
            task.Start();

            labelDisplau.Text = "The application is processing the request...";
            //Thread.Sleep(5000);

            labelDisplau.Text = (await task).ToString();

        }
    }
}
