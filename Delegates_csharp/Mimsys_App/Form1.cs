using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Mimsys_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        // event handler method.
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Pink;
            textBox1.Text = "Purushottham!!!";
          

            
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Green;
            textBox1.ForeColor = Color.Yellow;
        }

        private void textBox1_MouseLeave()
        {
            textBox1.BackColor = Color.Yellow;
        }



    }
}
