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
    public partial class FileOperations : Form
    {
        private static FileStream filestream = new FileStream(@"E:\csharp\Delegates_csharp\Mimsys_App\TimerLog.txt", FileMode.OpenOrCreate, FileAccess.Write);
        private static StreamWriter streamWriter = new StreamWriter(filestream);


        private void Form1_Load(object sender, EventArgs e)
        {

        }



        public FileOperations()
        {
            InitializeComponent();
        }


        public void buttonMoveFile_Click(object sender, EventArgs e)
        { 
        
        }

        public void buttonCopy_Click(object sender, EventArgs e)
        {

        }

        public void buttonDelete_Click(object sender, EventArgs e)
        {

        }


    }
}
