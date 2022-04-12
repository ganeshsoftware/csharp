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
    public partial class Form3 : Form
    {
             
        public Form3()
        {
            InitializeComponent();
        }



        private Int32 CountCharactersOfTheFile()
        {
                Int32 charcount = 0;
                using (StreamReader reader = new StreamReader(@"E:\csharp\Delegates_csharp\Mimsys_App\Definition.txt"))
                {
                    string fileContent = reader.ReadToEnd();
                    charcount = fileContent.Length;
                   
                    /// i am deliberatly introducing a delay of 15 sec.
                    Thread.Sleep(15000);
                };

            return charcount;
        }




        public async void btnCountChars_Click(object obj, EventArgs e)
        {
            Task<Int32> task = new Task<Int32>(CountCharactersOfTheFile);
            task.Start();

            lblInfo.Text = "Please wait!! The operation of reading the file is in progress...";

            // awaitable. 
            int count = await task;

            //int count = CountCharactersOfTheFile();
            lblInfo.Text = "The number of characters in the file are:  " + count + "  characters";
        }

    }
}
