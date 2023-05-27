using ElectronicLibrary.Entity;
using ElectronicLibrary.Repository;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ElectronicLibrary
{
    public partial class User : Form
    {
        UserBooksRepository userBooksRepository = new UserBooksRepository();
        UserUserCardRepository userUserCardRepository = new UserUserCardRepository();
        string userName;
        const double f = 0.2;
        public User(string username)
        {
            InitializeComponent();
            books_dgv.DataSource = userBooksRepository.UserAllBook();
            foreach (DataRow row in userBooksRepository.UserAllCategory().Rows)
            {
                choose_ctg.Items.Add(row.ItemArray[1].ToString());
            }
            choose_ctg.Items.Add("All categories");
            this.userName = username;
            ucard_dgv.DataSource = userUserCardRepository.UserAllUserCard(false, username);
            books_dgv.Columns[1].Width = 227;
            books_dgv.Columns[2].Width = 226;
            books_dgv.Columns[3].Width = 150;
            books_dgv.Columns[4].Width = 120;

            ucard_dgv.Columns[0].Width = 40;
            ucard_dgv.Columns[3].Width = 84;
            ucard_dgv.Columns[5].Width = 70;
            ucard_dgv.Columns[6].Width = 117;
            ucard_dgv.Columns[8].Width = 117;
            ucard_dgv.Columns[9].Width = 40;
            ucard_dgv.Columns[10].Width = 55;

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void books_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void ucard_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
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

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (search_box.Text == "Search by author or book")
                MessageBox.Show("Cannot empty this place!", "Alert");
            else
            {
                choose_ctg.Text = "Choose category";
                books_dgv.DataSource = userBooksRepository.UserFindBookNameAuthor(search_box.Text);
                search_box.Text = "";
                search_box.Text = "Search by author or book";
                search_box.ForeColor = Color.DimGray;
            }
        }

        private void choose_ctg_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_box.Text = "Search by author or book";
            search_box.ForeColor = Color.DimGray;
            if (choose_ctg.Text == "All categories")
                books_dgv.DataSource = userBooksRepository.UserAllBook();
            else
                books_dgv.DataSource = userBooksRepository.UserFindBookCategory(choose_ctg.Text);
        }

        private void brw_btn_Click(object sender, EventArgs e)
        {
            if (books_dgv.CurrentRow.Index >= 0)
            {
                Report report = new Report();
                report.Username = userName;
                report.Book_id = Convert.ToInt32(books_dgv.CurrentRow.Cells[0].Value);
                report.Receive_date = DateTime.Now;
                report.Deadline = DateTime.Now.AddDays(14);
                int result = userBooksRepository.UserAddUserCard(report);
                MessageBox.Show($"Added {result} book!", "Success");
                books_dgv.DataSource = userBooksRepository.UserAllBook();
                choose_ctg.Text = "Choose category";
                search_box.Text = "Search by author or book";
                search_box.ForeColor = Color.DimGray;
                ucard_dgv.DataSource = userUserCardRepository.UserAllUserCard(false, userName);

            }
        }

        private void show_chb_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = show_chb.Checked ? true : false;
            ucard_dgv.DataSource = userUserCardRepository.UserAllUserCard(isChecked, userName);
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            if (ucard_dgv.CurrentRow.Index >= 0)
            {
                DateTime deadline = Convert.ToDateTime(ucard_dgv.CurrentRow.Cells[7].Value);
                Report report = new Report();
                report.Return_date = DateTime.Now;
                double fine;
                if (DateTime.Now > deadline)
                {
                    double days = Math.Round(DateTime.Now.Subtract(deadline).TotalDays);
                    fine = Math.Floor(days * f);
                }
                else
                    fine = 0;
                report.Fine = fine;
                report.Id = Convert.ToInt32(ucard_dgv.CurrentRow.Cells[0].Value);
                report.Book_id = Convert.ToInt32(ucard_dgv.CurrentRow.Cells[2].Value);
                int result = userUserCardRepository.UserReturnBook(report);
                if (result > 0)
                {
                    MessageBox.Show($"{result} book successfully returned!", "Success");
                    books_dgv.DataSource = userBooksRepository.UserAllBook();
                    choose_ctg.Text = "Choose category";
                    show_chb.Checked = false;
                    search_box.Text = "Search by author or book";
                    search_box.ForeColor = Color.DimGray;
                    ucard_dgv.DataSource = userUserCardRepository.UserAllUserCard(false, userName);
                }
                else
                    MessageBox.Show("This operation is not possible!", "Alert");
            }
        }
    }
}
