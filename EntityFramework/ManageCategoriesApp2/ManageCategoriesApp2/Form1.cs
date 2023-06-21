using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageCategoriesApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadCategories()
        {
            var categories = ManageCategories.Instance.GetCategories();
            txtid.DataBindings.Clear();
            txtname.DataBindings.Clear();
            txtid.DataBindings.Add("Text", categories, "CategoryID");
            txtname.DataBindings.Add("Text", categories, "CategoryName");
            dataGridView1.DataSource = categories;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category { CategoryName = txtname.Text };
                ManageCategories.Instance.InsertCategory(category);
                LoadCategories();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Inserted Category");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category {
                    CategoryId = int.Parse(txtid.Text),
                    CategoryName = txtname.Text };
                    
                ManageCategories.Instance.UpdateCategory(category);
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Updated Category");

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category
                {
                    CategoryId = int.Parse(txtid.Text)
                };

                ManageCategories.Instance.DeleteCategory(category);
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Deleted Category");

            }
        }
    }
}
