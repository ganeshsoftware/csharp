using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;



namespace Mimsys_App
{
    public partial class Form4 : Form
    {
        private static FileStream filestream = new FileStream(@"E:\csharp\Delegates_csharp\Mimsys_App\TimerLog.txt", FileMode.OpenOrCreate, FileAccess.Write);
        private static StreamWriter streamWriter = new StreamWriter(filestream);


        private void Form1_Load(object sender, EventArgs e)
        {
            // Write to the file using StreamWriter class    
            streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            streamWriter.Write(" File Write Operation Starts : ");
            streamWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            streamWriter.WriteLine("===================================== \n");
            // Flushing the stream writer is mandatory.
            streamWriter.Flush();
        }



        public Form4()
        {
            InitializeComponent();
        }


        


        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            streamWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            streamWriter.Flush();
        }
    }
}
