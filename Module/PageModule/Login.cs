using ElectronicLibrary.Repository;
using System;
using System.Windows.Forms;

namespace ElectronicLibrary
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            show.BringToFront();
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (pass_box.PasswordChar == '•')
            {
                hide.BringToFront();
                pass_box.PasswordChar = '\0';
            }
        }

        private void hide_Click(object sender, EventArgs e)
        {
            if (pass_box.PasswordChar == '\0')
            {
                show.BringToFront();
                pass_box.PasswordChar = '•';
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (name_box.Text == "" || pass_box.Text == "")
            {
                MessageBox.Show("Please, fill all the gaps!", "Alert");
            }
            else
            {
                bool isAdmin = admin.Checked ? true : false;
                Entity.User user = new Entity.User();
                user.Username = name_box.Text;
                user.Password = pass_box.Text;
                user.IsAdmin = isAdmin;
                LoginRepository loginRepository = new LoginRepository();
                switch (loginRepository.Login(user))
                {
                    case 1:
                        Hide();
                        Admin adminForm = new Admin();
                        adminForm.ShowDialog();
                        break;
                    case 0:
                        Hide();
                        User userForm = new User(user.Username);
                        userForm.ShowDialog();
                        break;
                    default:
                        MessageBox.Show("User cannot be find!", "Alert");
                        name_box.Text = "";
                        pass_box.Text = "";
                        break;
                }
            }
        }
    }
}
