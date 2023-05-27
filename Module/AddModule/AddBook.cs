using ElectronicLibrary.Entity;
using ElectronicLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ElectronicLibrary
{
    public partial class AddBook : Form
    {
        AdminCategoriesRepository adminCategoriesRepository = new AdminCategoriesRepository();
        AdminAddBookRepository adminAddBookRepository = new AdminAddBookRepository();
        Book book = new Book();
        int id = -1, count = 0;
        public AddBook()
        {
            InitializeComponent();
            if (adminCategoriesRepository.AdminAllCategory().Rows.Count > 0)
            {
                category.Items.Clear();
                foreach (DataRow row in adminCategoriesRepository.AdminAllCategory().Rows)
                {
                    category.Items.Add(row.ItemArray[1].ToString());
                }
            }
        }

        public AddBook(Book book)
        {
            InitializeComponent();
            Text = "Edit Book";
            label6.Text = "Edit Book";
            add_btn.Text = "Change";
            add_book.Visible = false;
            category.Items.Clear();
            foreach (DataRow row in adminCategoriesRepository.AdminAllCategory().Rows)
            {
                category.Items.Add(row.ItemArray[1].ToString());
            }

            bname.Text = book.Name;
            author.Text = book.Author;
            string[] temp = book.Publish_year.ToString().Split();

            publish.Text = temp[0].Split('.')[2];
            category.Text = book.Category;
            id = book.Id;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (bname.Text == "" || author.Text == "" || publish.Text == "" || category.Text == "" )
                MessageBox.Show("Please, fill all the gaps!", "Alert");
            else
            {
                book.Name = bname.Text;
                book.Author = author.Text;
                book.Publish_year = Convert.ToDateTime(publish.Text+"-10-10");
                book.Category = category.Text;

                if (id >= 0)
                {
                    book.Id = id;
                    count = adminAddBookRepository.AdminUpdateBook(book);
                    if (count >= 0)
                        MessageBox.Show($"{count} book successfully edited!", "Successful");
                }
                else
                {
                    count = adminAddBookRepository.AdminAddBook(book);
                    if (count >= 0)
                        MessageBox.Show($"{count} book successfully added!", "Successful");
                }
                Close();
            }
        }
    }
}
