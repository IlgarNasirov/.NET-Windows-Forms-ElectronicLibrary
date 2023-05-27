using ElectronicLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ElectronicLibrary
{
    public partial class AddUser : Form
    {
        AdminAddUserRepository adminAddUserRepository = new AdminAddUserRepository();
        Entity.User user = new Entity.User();
        int id = -1, count = 0;
        public AddUser()
        {
            InitializeComponent();
        }

        public AddUser(Entity.User user)
        {
            InitializeComponent();
            Text = "Change User Information";
            label6.Text = "Change User Information";
            add_btn.Text = "Change";
            add_user.Visible = false;

            uname.Text = user.Username;
            pass.Text = user.Password;
            name.Text = user.Fullname;
            phone.Text = user.Phone;
            address.Text = user.Address;
            id = user.Id;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (uname.Text == "" || pass.Text == "" || name.Text == "" || phone.Text == "" || address.Text == "")
                MessageBox.Show("Please, fill all the gaps!", "Alert");
            else
            {
                user.Username = uname.Text;
                user.Password = pass.Text;
                user.Fullname = name.Text;
                user.Phone = phone.Text;
                user.Address = address.Text;

                if (id >= 0)
                {
                    user.Id = id;
                    count = adminAddUserRepository.AdminUpdateUser(user);
                    if (count >= 0)
                        MessageBox.Show($"{count} user information successfully changed!", "Successful");
                    else
                        MessageBox.Show("Please, enter the unique value!", "Alert");
                }
                else
                {
                    count = adminAddUserRepository.AdminAddUser(user);
                    if (count >= 0)
                        MessageBox.Show($"{count} user successfully added!", "Successful");
                    else
                        MessageBox.Show("Please, enter the unique value!", "Alert");
                }
                Close();
            }
        }
    }
}
