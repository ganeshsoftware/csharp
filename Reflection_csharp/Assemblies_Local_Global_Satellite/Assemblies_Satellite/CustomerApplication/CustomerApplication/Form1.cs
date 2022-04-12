using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

using System.Threading; //For Threading
using System.Globalization; //For CultureInfo


namespace CustomerApplication
{
    public partial class Form1 : Form
    {
        string sLangCode;

        public Form1()
        {
            InitializeComponent();
        }

        System.Resources.ResourceManager rm = new System.Resources.ResourceManager("CustomerApplication.string", Assembly.GetExecutingAssembly());

       


        private void ChangeCulture(string sLangCode)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(sLangCode);
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(sLangCode);

            //  lblMultiLangResult.Text = rm.GetString("lblResult");
            labelID.Text = rm.GetString("labelId");

            labelName.Text = rm.GetString("labelName");
            labelAddress.Text = rm.GetString("labelAddress");
            labelPhone.Text = rm.GetString("labelPhone");
            labelEMail.Text = rm.GetString("labelEMail");
            buttonSave.Text  = rm.GetString("buttonSave");
            buttonCancel.Text = rm.GetString("buttonCancel");
        }
            
        private void buttonEnglish_Click(object sender, EventArgs e)
        {

            sLangCode = "en-US";
            ChangeCulture(sLangCode);
            foreach (Control control in groupBox2.Controls)
            {
                if (control.GetType().Equals(typeof(System.Windows.Forms.Button)))
                {
                    if (String.Equals(((Button)control), ((Button)sender)))
                    {
                        ((Button)sender).BackColor = Color.OrangeRed;
                    }
                    else
                    {
                        ((Button)control).BackColor = Color.LightGray;
                    }
                }

            }
           
        }

        private void buttonKannada_Click(object sender, EventArgs e)
        {

            sLangCode = "ka";
            ChangeCulture(sLangCode);
            foreach (Control control in groupBox2.Controls)
            {
                if(control.GetType().Equals(typeof(System.Windows.Forms.Button)))
                {
                    if (String.Equals(((Button)control),((Button)sender)))
                    {
                        ((Button)sender).BackColor = Color.OrangeRed;
                    }
                    else
                    {
                        ((Button)control).BackColor = Color.LightGray; 
                    }
                }
    
            }
        }

        private void buttonHindi_Click(object sender, EventArgs e)
        {
            sLangCode = "hi";
            ChangeCulture(sLangCode);
            foreach (Control control in groupBox2.Controls)
            {
                if (control.GetType().Equals(typeof(System.Windows.Forms.Button)))
                {
                    if (String.Equals(((Button)control), ((Button)sender)))
                    {
                        ((Button)sender).BackColor = Color.OrangeRed;
                    }
                    else
                    {
                        ((Button)control).BackColor = Color.LightGray;
                    }
                }

            }

        }

        private void buttonTamil_Click(object sender, EventArgs e)
        {
            sLangCode = "ta";
            ChangeCulture(sLangCode);
            foreach (Control control in groupBox2.Controls)
            {
                if (control.GetType().Equals(typeof(Button)))
                {
                    if (String.Equals(((Button)control), ((Button)sender)))
                    {
                        ((Button)sender).BackColor = Color.OrangeRed;
                    }
                    else
                    {
                        ((Button)control).BackColor = Color.LightGray;
                    }
                }

            }
        }

        private void ganesh(object sender, EventArgs e)
        {
            MessageBox.Show("Hey! Where are you tresspassing? ");
        }
    }
}
