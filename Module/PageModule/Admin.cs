using ElectronicLibrary.Entity;
using ElectronicLibrary.Repository;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ElectronicLibrary
{
    public partial class Admin : Form
    {
        AdminUsersRepository adminUsersRepository = new AdminUsersRepository();
        AdminBooksRepository adminBooksRepository = new AdminBooksRepository();
        AdminCategoriesRepository adminCategoriesRepository = new AdminCategoriesRepository();

        public Admin()
        {
            InitializeComponent();
            users_dgv.DataSource = adminUsersRepository.AdminAllUser();
            books_dgv.DataSource = adminBooksRepository.AdminAllBook();
            ctg_dgv.DataSource = adminCategoriesRepository.AdminAllCategory();

            foreach (DataRow row in adminBooksRepository.AdminAllCategory().Rows)
            {
                choose_ctg.Items.Add(row.ItemArray[1].ToString());
            }
            choose_ctg.Items.Add("All categories");

            books_dgv.Columns[1].Width = 150;
            books_dgv.Columns[2].Width = 227;
            books_dgv.Columns[3].Width = 226;
            books_dgv.Columns[4].Width = 120;
            ctg_dgv.Columns[1].Width = 263;
        }
        private void users_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
        private void books_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }
        private void ctg_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void search_box_Enter(object sender, EventArgs e)
        {
            if (search_box.Text == "Search by author or book")
            {
                search_box.Text = "";
                search_box.ForeColor = Color.Black;
            }
        }

        private void search_box_Leave(object sender, EventArgs e)
        {
            if (search_box.Text == "")
            {
                search_box.Text = "Search by author or book";
                search_box.ForeColor = Color.DimGray;
            }
        }

        private void logout1_Click(object sender, EventArgs e)
        {
            Close();
            Login login = new Login();
            login.Show();
        }

        private void logout2_Click(object sender, EventArgs e)
        {
            Close();
            Login login = new Login();
            login.Show();
        }

        private void logout3_Click(object sender, EventArgs e)
        {
            Close();
            Login login = new Login();
            login.Show();
        }

        private void add_user_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
            users_dgv.DataSource = adminUsersRepository.AdminAllUser();
        }

        private void del_user_Click(object sender, EventArgs e)
        {
            if (users_dgv.CurrentRow.Index >= 0)
            {
                int count = adminUsersRepository.AdminDeleteUser(Convert.ToInt32(users_dgv.CurrentRow.Cells[0].Value));
                if (count >= 0)
                {
                    users_dgv.DataSource = adminUsersRepository.AdminAllUser();
                    MessageBox.Show($"{count} user successfully removed!", "Successful");
                }
            }
        }

        private void edit_user_Click(object sender, EventArgs e)
        {
            if (users_dgv.CurrentRow.Index >= 0)
            {
                Entity.User user = new Entity.User 
                { 
                    Id = Convert.ToInt32(users_dgv.CurrentRow.Cells[0].Value),
                    Fullname = users_dgv.CurrentRow.Cells[1].Value.ToString(), 
                    Username = users_dgv.CurrentRow.Cells[2].Value.ToString(), 
                    Phone = users_dgv.CurrentRow.Cells[3].Value.ToString(),
                    Address = users_dgv.CurrentRow.Cells[4].Value.ToString(),
                    Password = users_dgv.CurrentRow.Cells[5].Value.ToString()
                };
                AddUser addUser = new AddUser(user);
                addUser.ShowDialog();
                users_dgv.DataSource = adminUsersRepository.AdminAllUser();
            }
        }

        private void add_book_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();    
            addBook.ShowDialog();
            books_dgv.DataSource = adminBooksRepository.AdminAllBook();
        }

        private void del_book_Click(object sender, EventArgs e)
        {
            if (books_dgv.CurrentRow.Index >= 0)
            {
                int count = adminBooksRepository.AdminDeleteBook(Convert.ToInt32(books_dgv.CurrentRow.Cells[0].Value));
                if (count >= 0)
                {
                    books_dgv.DataSource = adminBooksRepository.AdminAllBook();
                    MessageBox.Show($"{count} book successfully removed!", "Successful");
                }
            }
        }
        private void edit_book_Click(object sender, EventArgs e)
        {
            if (books_dgv.CurrentRow.Index >= 0)
            {
                string time = books_dgv.CurrentRow.Cells[4].Value.ToString() + "-10-10";
                Book book = new Book
                {
                    Id = Convert.ToInt32(books_dgv.CurrentRow.Cells[0].Value),
                    Category = books_dgv.CurrentRow.Cells[1].Value.ToString(),
                    Name = books_dgv.CurrentRow.Cells[2].Value.ToString(),
                    Author = books_dgv.CurrentRow.Cells[3].Value.ToString(),
                    Publish_year = Convert.ToDateTime(time)
                };
                AddBook addBook = new AddBook(book);
                addBook.ShowDialog();
                books_dgv.DataSource = adminBooksRepository.AdminAllBook();
            }
        }
        private void add_ctg_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.ShowDialog();
            ctg_dgv.DataSource = adminCategoriesRepository.AdminAllCategory();
        }

        private void del_ctg_Click(object sender, EventArgs e)
        {
            if (books_dgv.CurrentRow.Index >= 0)
            {
                int count = adminCategoriesRepository.AdminDeleteCategory(Convert.ToInt32(ctg_dgv.CurrentRow.Cells[0].Value));
                if (count >= 0)
                {
                    ctg_dgv.DataSource = adminCategoriesRepository.AdminAllCategory();
                    MessageBox.Show($"{count} category successfully removed!", "Successful");
                }
            }
        }
        
        private void edit_ctg_Click(object sender, EventArgs e)
        {
            if (ctg_dgv.CurrentRow.Index >= 0)
            {
                Category category = new Category()
                {
                    Id = Convert.ToInt32(ctg_dgv.CurrentRow.Cells[0].Value),
                    Name = ctg_dgv.CurrentRow.Cells[1].Value.ToString()
                };
                AddCategory addCategory = new AddCategory(category);
                addCategory.ShowDialog();
                ctg_dgv.DataSource = adminCategoriesRepository.AdminAllCategory();
            }
        }

        private void users_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (users_dgv.CurrentRow.Index >= 0)
            {
                ucard_dgv.DataSource = adminUsersRepository.AdminAllUserCard(users_dgv.CurrentRow.Cells[2].Value.ToString());
                ucard_dgv.Columns[3].Width = 141;
                ucard_dgv.Columns[4].Width = 141;
                ucard_dgv.Columns[5].Width = 141;
            }
        }

        private void choose_ctg_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_box.Text = "Search by author or book";
            search_box.ForeColor = Color.DimGray;
            if (choose_ctg.Text == "All categories")
                books_dgv.DataSource = adminBooksRepository.AdminAllBook();
            else
                books_dgv.DataSource = adminBooksRepository.AdminFindBookCategory(choose_ctg.Text);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (search_box.Text == "Search by author or book")
                MessageBox.Show("Cannot empty this place!", "Alert");
            else
            {
                choose_ctg.Text = "Choose category";
                books_dgv.DataSource = adminBooksRepository.AdminFindBookNameAuthor(search_box.Text);
                search_box.Text = "Search by author or book";
                search_box.ForeColor = Color.DimGray;
            }

        }
    }
}
