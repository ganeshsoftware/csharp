using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObservableCollectionDemo
{
    public partial class Form1 : Form
    {
        private ObservableCollection<Person> person;


        public Form1()
        {
            InitializeComponent();
         person = new ObservableCollection<Person>()
         {
             new Person(){Name="Prabhat", Address="India"},
             new Person(){Name="Smith", Address="US"}
         };

      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNames_Click(object sender, EventArgs e)
        {
            InitilizeDataGrid();
            person.Add(new Person() { Name = txtName.Text, Address = txtAddress.Text });
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }


        public void InitilizeDataGrid()
        {
            // Create an unbound DataGridView by declaring a column count.
            dgvPersons.ColumnCount = 4;
            dgvPersons.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgvPersons.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            dgvPersons.Columns[0].Name = "Recipe";
            dgvPersons.Columns[1].Name = "Category";
            dgvPersons.Columns[2].Name = "Main Ingredients";
            dgvPersons.Columns[3].Name = "Rating";

            // Populate the rows.
            string[] row1 = new string[] { "Meatloaf", "Main Dish", "ground beef", "**" };
            string[] row2 = new string[] { "Key Lime Pie", "Dessert", "lime juice, evaporated milk", "****" };
            string[] row3 = new string[] { "Orange-Salsa Pork Chops", "Main Dish", "pork chops, salsa, orange juice", "****" };
            string[] row4 = new string[] { "Black Bean and Rice Salad", "Salad", "black beans, brown rice", "****" };
            string[] row5 = new string[] { "Chocolate Cheesecake", "Dessert", "cream cheese", "***" };
            string[] row6 = new string[] { "Black Bean Dip", "Appetizer", "black beans, sour cream", "***" };

            object[] rows = new object[] { row1, row2, row3, row4, row5, row6 };

            foreach (string[] rowArray in rows)
            {
                dgvPersons.Rows.Add(rowArray);
            }
        }
    }
}
