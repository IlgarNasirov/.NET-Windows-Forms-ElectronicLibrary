using ElectronicLibrary.Entity;
using ElectronicLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicLibrary
{
    public partial class AddCategory : Form
    {
        AdminAddCategoryRepository adminAddCategoryRepository = new AdminAddCategoryRepository();
        Category category = new Category();
        int id = -1, count = 0;
        public AddCategory()
        {
            InitializeComponent();
        }

        public AddCategory(Category category)
        {
            InitializeComponent();
            Text = "Edit Category";
            label6.Text = "Edit Category";
            add_btn.Text = "Change";
            id = category.Id;
            ctgname.Text = category.Name;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (ctgname.Text == "")
                MessageBox.Show("Please, fill the gap!", "Alert");
            else
            {
                category.Name = ctgname.Text;
                category.Id = id;
                if (id >= 0)
                {
                    category.Id = id;
                    count = adminAddCategoryRepository.AdminUpdateCategory(category);
                    if (count >= 0)
                        MessageBox.Show($"{count} category successfully edited!", "Successful");
                    else
                        MessageBox.Show("Please, enter the unique value!", "Alert");
                }
                else
                {
                    count = adminAddCategoryRepository.AdminAddCategory(category);
                    if (count >= 0)
                        MessageBox.Show($"{count} category successfully added!", "Successful");
                    else
                        MessageBox.Show("Please, enter the unique value!", "Alert");
                }
                Close();
            }
        }
    }
}
