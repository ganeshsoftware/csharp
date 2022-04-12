using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManager
{
    public partial class Form1 : Form
    {
        bool checkbin = false;
        bool checkxml = false;

        Employee emp;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFemale.Checked == true)
            {
                checkBoxMale.Checked = false;
                checkBoxOther.Checked = false;
            }
        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMale.Checked == true)
            {
                checkBoxFemale.Checked = false;
                checkBoxOther.Checked = false;
            }
        }

        private void checkBoxOther_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOther.Checked == true)
            {
                checkBoxMale.Checked = false;
                checkBoxFemale.Checked = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            emp = new Employee();
            emp.Id = Convert.ToInt32(textBoxId.Text);
            emp.Name = textBoxName.Text;
            emp.Gender = this.GetGender(comboBoxDepartment.Text);
            emp.Department = comboBoxDepartment.Text;

            if (checkBoxXML.Checked.Equals(true))
            {
                checkxml = true;
            }
            else
            {
                checkxml = false;
            }

            if (checkBoxBinary.Checked.Equals(true))
            {
                checkbin = true;
            }
            else
            {
                checkbin = false;
            }

        }


        public char GetGender(string value)
        {
            char gend = 'N';

            if (value == "Administration")
            {
                gend = 'A';
            }
            else if (value == "Technical")
            {
                gend = 'T';
            }
            else if (value == "Finance")
            {
                gend = 'F';
            }
            else if (value == "HR")
            {
                gend = 'H';
            }
            else if (value == "Operations")
            {
                gend = 'O';
            }
            return gend;
        }





        public void CreateBinFile(Employee e)
        {

        }

        public void CreateXMLFile(Employee e)
        {


        }




    }
}
